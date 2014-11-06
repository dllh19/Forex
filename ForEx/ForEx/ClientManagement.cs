using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForEx.Classes;

namespace ForEx
{
    public partial class frmClientManagement : Form
    {
        BindingSource bs = new BindingSource();
        private SqlConnection con = new SqlConnection(Common.GetConnectionString());
        private SqlDataAdapter da = new SqlDataAdapter();
        private SqlCommand cmd = new SqlCommand();

        private int RowClickUserId = 0;

        public frmClientManagement()
        {
            InitializeComponent();
            populate_Type();
            populate_Nationality();
            populate_Country();
            populate_IDType();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //test
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string typeValue = comboType.SelectedItem.ToString();

            if (typeValue == "Individual" && validateIndividualField() && validateCommonFields())
            {                
                insertIndividualClient();
            }

            if (typeValue != "Individual" && validateOther() && validateCommonFields())
            {
                insertOtherType();
            }         
        }

        private void populate_IDType()
        {
            comboIDType.Items.Add("Passport");
            comboIDType.Items.Add("ID card");
        }

        private void populate_Type()
        {
            comboType.Items.Add("Individual");
            comboType.Items.Add("Bank");
            comboType.Items.Add("Corporate");
            this.comboType.SelectedIndexChanged += new System.EventHandler(ComboType_SelectedIndexChanged);
        }

        private void populate_Nationality()
        {
            comboNationality.Items.Add("Mauritian");
            comboNationality.Items.Add("Foreign");

            this.comboNationality.SelectedIndexChanged += new System.EventHandler(ComboNationality_SelectedIndexChanged);
        }

        private void populate_Country()
        {
            var Countries = Common.GetCountries().country.ToDictionary(x => x.countryName, y => y.countryName).OrderBy(z => z.Key);
            comboCountry.DataSource = new BindingSource(Countries, null);
            comboCountry.ValueMember = "Key";
            comboCountry.DisplayMember = "Value";

            comboCountry.SelectedValue = "Mauritius";
        }

        private void ComboNationality_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //set Country to Mauritius by default in country
        }

        private void ComboType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string TypeValue = comboType.SelectedItem.ToString();
            hideAllFields();

            if (TypeValue != "Individual")
            {
                
                panelCompanyName.Visible = true;
                panelContact.Visible = true;
                panelDOB2.Visible = true;
                panelBRN.Visible = true;
                panelVAT.Visible = true;
                panelUpload.Visible = true;
                commonVisibleFields();

            }
            else
            {
                
                panelName.Visible = true;
                panelSurname.Visible = true;
                panelDOB.Visible = true;
                panelIDType.Visible = true;
                panelPassport.Visible = true;
                panelOccupation.Visible = true;
                panelUpload.Visible = true;

                commonVisibleFields();
            }
        }

        private void hideAllFields()
        {
            panelName.Visible = false;
            panelSurname.Visible = false;
            panelCompanyName.Visible = false;
            panelContact.Visible = false;
            panelDOB.Visible = false;
            panelUpload.Visible = false;
            panelVAT.Visible = false;
            panelBRN.Visible = false;
            panelNationality.Visible = false;
            panelDOB2.Visible = false;
            panelAddress.Visible = false;
            panelCountry.Visible = false;
            panelPhone.Visible = false;
            panelEmail.Visible = false;
            panelIDType.Visible = false;
            panelPassport.Visible = false;
            panelOccupation.Visible = false;

            btnAdd.Visible = false;

        }

        private void commonVisibleFields()
        {
            panelNationality.Visible = true;
            panelCountry.Visible = true;
            panelAddress.Visible = true;
            panelPhone.Visible = true;
            panelEmail.Visible = true;
            panelUpload.Visible = true;

            btnAdd.Visible = true;
        }

        private bool CheckPhoneNumber()
        {
            if (Common.IsPhone(textPhone.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid phone number entered");
                return false;
            }
        }

        private bool validateCommonFields()
        {
            if (textAddress.Text == "")
            {
                MessageBox.Show("Address is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (textPhone.Text == "")
            {
                MessageBox.Show("Phone is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (comboNationality.SelectedItem == null)
            {
                MessageBox.Show("Please select a Nationality!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            //Enable after populating Country
            if (comboCountry.SelectedValue == null)
            {
                MessageBox.Show("Please select a country!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (textEmail.Text == "")
            {
                MessageBox.Show("Email is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (textPhone.Text == "")
            {
                MessageBox.Show("Email is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (!CheckPhoneNumber())
            {
                return false;
            }

            if (!Common.IsValidEmail(textEmail.Text))
            {
                MessageBox.Show("Email is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private bool validateIndividualField()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Name is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (txtSurname.Text == "")
            {
                MessageBox.Show("Surname is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (comboIDType.SelectedItem == null)
            {
                MessageBox.Show("Please Select an ID type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (textPassport.Text == "")
            {
                MessageBox.Show("Passport/ID No is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (textOccupation.Text == "")
            {
                MessageBox.Show("Occupation is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;

        }

        private bool validateOther()
        {
            if (textCompanyName.Text == "")
            {
                MessageBox.Show("Company Name is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (textContact.Text == "")
            {
                MessageBox.Show("Contact is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (textVAT.Text == "")
            {
                MessageBox.Show("VAT is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (textBRN.Text == "")
            {
                MessageBox.Show("BRN is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void insertIndividualClient()
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO tbl_client (type, name, surname, dob, nationality, " +
                                     "country, address, phone, email, id_type,passport_no, occupation, " +
                                     "username, isblacklisted,date_client_created) VALUES (@type, @name, @surname,@dob," +
                                     " @nationality, @country, @address, @phone, @email , @id_type," +
                                     " @passport_no, @occupation, @username , 'false',@date_client_created); " +
                                     "SELECT SCOPE_IDENTITY();");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@type", comboType.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimeDOB.Value);
                cmd.Parameters.AddWithValue("@nationality", comboNationality.SelectedItem);
                cmd.Parameters.AddWithValue("@country", comboCountry.SelectedValue);
                cmd.Parameters.AddWithValue("@address", textAddress.Text);
                cmd.Parameters.AddWithValue("@phone", textPhone.Text);
                cmd.Parameters.AddWithValue("@email", textEmail.Text);
                cmd.Parameters.AddWithValue("@id_type", comboIDType.SelectedItem);
                cmd.Parameters.AddWithValue("@passport_no", textPassport.Text);
                cmd.Parameters.AddWithValue("@occupation", textOccupation.Text);
                //cmd.Parameters.AddWithValue("@username", Common.GetUser().Username); //To change when Login implemented
                cmd.Parameters.AddWithValue("@username", "TEST"); //To delete when Login implemented
                cmd.Parameters.AddWithValue("@date_client_created", DateTime.Now);
                try
                {
                    con.Open();
                    var idReturned = cmd.ExecuteScalar();
                    con.Close();

                    int clientId = Convert.ToInt32(idReturned);
                    if (clientId > 0)
                    {
                        var filelist = GetFilesToUpload();

                        if (filelist.Any())
                        {
                            foreach (var file in filelist)
                            {
                                UploadFile(file, clientId);
                            }
                        }
                        MessageBox.Show("Client has been added successfully");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when saving client: " + ex.InnerException);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void insertOtherType()
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO tbl_client (type, company_name, " +
                                     "contact_person, date_incorporated, vat," +
                                     " nationality, country, address, phone," +
                                     " email, brn, username, isblacklisted,date_client_created)" +
                                     " VALUES (@type, @company_name, @contact_name, " +
                                     "@date_incorporated, @vat, @nationality, @country," +
                                     " @address, @phone, @email , @brn, @username ," +
                                     " 'false',@date_client_created); " +
                                     "SELECT SCOPE_IDENTITY();");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@type", comboType.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@company_name", textCompanyName.Text);
                cmd.Parameters.AddWithValue("@contact_name", textContact.Text);
                cmd.Parameters.AddWithValue("@date_incorporated", dateTimeDOB2.Value);
                cmd.Parameters.AddWithValue("@vat", textVAT.Text);
                cmd.Parameters.AddWithValue("@nationality", comboNationality.SelectedItem);
                cmd.Parameters.AddWithValue("@country", comboCountry.SelectedValue);
                cmd.Parameters.AddWithValue("@address", textAddress.Text);
                cmd.Parameters.AddWithValue("@phone", textPhone.Text);
                cmd.Parameters.AddWithValue("@email", textEmail.Text);
                cmd.Parameters.AddWithValue("@brn", textBRN.Text);
                //cmd.Parameters.AddWithValue("@username", Common.GetUser().Username); //To change when Login implemented
                cmd.Parameters.AddWithValue("@username", "TEST"); //To delete when Login implemented
                cmd.Parameters.AddWithValue("@date_client_created", DateTime.Now);

                con.Open();
                var idReturned = cmd.ExecuteScalar();
                con.Close();

                int clientId = Convert.ToInt32(idReturned);

                if (clientId > 0)
                {
                    var filelist = GetFilesToUpload();

                    if (filelist.Any())
                    {
                        foreach (var file in filelist)
                        {
                            UploadFile(file, clientId);
                        }
                    }
                    MessageBox.Show("Bank/Corporate has been added successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gridSearchClient.DataSource = null;
            gridSearchClient.Rows.Clear();
            gridSearchClient.Refresh();
            gridSearchClient.AllowUserToAddRows = false;
            bs.Clear();

            var FilterText = cmbFilter.Text;
            string query;

            //Parameterized queries not working...

            if (FilterText.Equals("By Name"))
            {
                if (string.IsNullOrEmpty(txtSearchName.Text) && string.IsNullOrEmpty(txtSearchSurname.Text))
                {
                    MessageBox.Show("Please enter a name and search to search");
                    return;
                }
                query = "SELECT * FROM tbl_client WHERE name LIKE '%" + txtSearchName.Text + "%' AND surname LIKE '%" + txtSearchSurname.Text + "%'";
            }
            else if (FilterText.Equals("By Passport"))
            {
                query = "SELECT * FROM tbl_client WHERE passport_no LIKE '%" + txtSearchPassport.Text + "%'";
            }
          
            else if (FilterText.Equals("By Type"))
            {
                query = "SELECT * FROM tbl_client WHERE type LIKE '%" + cmbSearchType.Text + "%'";
            }
            else
            {
                MessageBox.Show("Please select a filter first");
                return;
            }

            con.Open();

            cmd = new SqlCommand(query, con);
            var reader = cmd.ExecuteReader();

            bs.DataSource = typeof(Clients);
            if (reader.HasRows)
            {
                DataTable myTable = new DataTable();
                myTable.Load(reader);
                foreach (DataRow row in myTable.Rows)
                {
                    int Code;
                    if (!string.IsNullOrEmpty(row["code"].ToString()))
                        Code = Convert.ToInt32(row["code"].ToString());
                    else
                        Code = 0;

                    string Name = row["name"].ToString();
                    DateTime DateOfBirth = new DateTime();
                    if (!string.IsNullOrEmpty(row["dob"].ToString()))
                    {
                        DateOfBirth = Convert.ToDateTime(row["dob"]);
                    }

                    string PassportNo = Convert.ToString(row["passport_no"]);
                    string Address = Convert.ToString(row["address"]);
                    string Surname = Convert.ToString(row["surname"]);
                    string Phone = Convert.ToString(row["phone"]);
                    string ContactPerson = Convert.ToString(row["contact_person"]);
                    string CompanyName = Convert.ToString(row["company_name"]);

                    DateTime DateIncorporated = new DateTime();
                    if (!string.IsNullOrEmpty(row["date_incorporated"].ToString()))
                    {
                        DateIncorporated = Convert.ToDateTime(row["date_incorporated"]);
                    }

                    string Country = Convert.ToString(row["country"]);
                    string Nationality = Convert.ToString(row["nationality"]);
                    string Email = Convert.ToString(row["email"]);
                    string VAT = Convert.ToString(row["vat"]);
                    string BRN = Convert.ToString(row["brn"]);
                    string IdType = Convert.ToString(row["id_type"]);
                    string Occupation = Convert.ToString(row["occupation"]);
                    string Username = Convert.ToString(row["username"]);

                    bool IsBlackListed = false;
                    if (!string.IsNullOrEmpty(row["isblacklisted"].ToString()))
                    {
                        IsBlackListed = Convert.ToBoolean(row["isblacklisted"]);
                    }
                    string Type = Convert.ToString(row["type"]);
                    DateTime DateCreated = Convert.ToDateTime(row["date_client_created"]);


                    Clients clients = new Clients
                    {
                        Code = Code,
                        Name = Name,
                        DateOfBirth = DateOfBirth,
                        PassportNo = PassportNo,
                        Address = Address,
                        Surname = Surname,
                        Phone = Phone,
                        ContactPerson = ContactPerson,
                        CompanyName = CompanyName,
                        DateIncorporated = DateIncorporated,
                        Country = Country,
                        Nationality = Nationality,
                        Email = Email,
                        VAT = VAT,
                        BRN = BRN,
                        IdType = IdType,
                        Occupation = Occupation,
                        Username = Username,
                        IsBlackListed = IsBlackListed,
                        Type = Type,
                        DateCreated = DateCreated,
                    };
                    bs.Add(clients);
                }
           
            }
           
            con.Close();


            gridSearchClient.DataSource = bs;
            gridSearchClient.AutoGenerateColumns = true; 
        }

        private DataGridViewRow gridrow;
        private void gridSearchClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var tempRow = gridSearchClient.CurrentRow;
            if (gridrow == null)
            {
                gridrow = tempRow;
                RowClickUserId =  ((Clients)gridrow.DataBoundItem).Code;
                btnViewAttachment.Enabled = true;
            }
            else
            {
                if (gridrow == tempRow)
                {
                    //open transacform
                    var clients = (Clients) gridrow.DataBoundItem;
                    var trnsacForm = new Transaction(clients);
                    trnsacForm.Show();
                }
                else
                {
                    gridrow = tempRow;
                }
            }
        }

        private void frmClientManagement_Load(object sender, EventArgs e)
        {
            panelSearchName.Visible = false;
            panelSearchType.Visible = false;
            panelSearchpassport.Visible = false;
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = cmbFilter.Text;
            if (value == "By Name")
            {
                panelSearchName.Visible = true;
                panelSearchType.Visible = false;
                panelSearchpassport.Visible = false;

            }
            else if (value == "By Passport")
            {
                panelSearchName.Visible = false;
                panelSearchType.Visible = false;
                panelSearchpassport.Visible = true;
            }
            else if (value == "By Type")
            {
                panelSearchName.Visible = false;
                panelSearchType.Visible = true;
                panelSearchpassport.Visible = false;
            }
            else
            {
                panelSearchName.Visible = false;
                panelSearchType.Visible = false;
                panelSearchpassport.Visible = false;
            }
        }

        public void CreateFolder(string foldername)
        {
            if (!Directory.Exists(@"C:\\" + foldername))
                Directory.CreateDirectory(@"C:\\" + foldername);
        }

        private void tabAddClient_Click(object sender, EventArgs e)
        {

        }

        public long UploadFile(string FileName, int userid)
        {
            if (!File.Exists(FileName))
            {
                return -1;
            }

            FileStream fs = null;
            try
            {
                #region Reading file

                fs = new FileStream(FileName, FileMode.Open);

                //
                // Finding out the size of the file to be uploaded
                //
                FileInfo fi = new FileInfo(FileName);
                long temp = fi.Length;
                int lung = Convert.ToInt32(temp);
                // ------------------------------------------

                //
                // Reading the content of the file into an array of bytes.
                //
                byte[] picture = new byte[lung];
                fs.Read(picture, 0, lung);
                fs.Close();
                // ------------------------------------------
                #endregion
                long result = uploadFileToDatabase(picture, fi.Name,userid);

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " - " + e.StackTrace);
                return -1;
            }
        }

        private long uploadFileToDatabase(byte[] picture, string fileName, int userid)
        {
            //
            // Defining the variables required for accesing the database server.
            //

            SqlParameter kFileName = null;
            SqlParameter FileName = null;
            SqlParameter UserId = null;
            SqlParameter Dateuploaded = null;
            SqlParameter pic = null;
            // By default, we assume we have an error. If we succed in uploading
            // the file, we'll change this 
            // to the unique id of the file
            long result = -1;

            try
            {
                //
                // Connecting to database.
                //
  
                cmd = new SqlCommand("UploadFile", con);
                // We assume there is a stored procedure called UploadFile

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                // ----------------------------------------------

                //
                // Initializing parameters and assigning
                // the values to be sent to the server
                //
                kFileName = new SqlParameter("@kFileName",
                                System.Data.SqlDbType.BigInt, 8);
                kFileName.Direction = ParameterDirection.Output;
                // This parameter does not have a size because
                // we do not know what the size is going to be.
                pic = new SqlParameter("Picture", SqlDbType.Image);
                pic.Value = picture;

                FileName = new SqlParameter("FileName", SqlDbType.VarChar, 50);
                FileName.Value = fileName;

                UserId = new SqlParameter("@Userid", SqlDbType.Int);
                UserId.Value = userid;

                Dateuploaded = new SqlParameter("@CurrentDate", SqlDbType.DateTime);
                Dateuploaded.Value = DateTime.Now;
                // ----------------------------------------------

                //
                // Adding the parameters to the database.
                // Remember that the order in which the parameters 
                //  are added is VERY important!
                //
                cmd.Parameters.Add(pic);
                cmd.Parameters.Add(FileName);
                cmd.Parameters.Add(kFileName);
                cmd.Parameters.Add(UserId);
                cmd.Parameters.Add(Dateuploaded);
                // ----------------------------------------------

                //
                // Opening the connection and executing the command.
                //
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                // ----------------------------------------------

                //
                // The result is the unique identifier created on the database.
                //
                result = (long)kFileName.Value;
                // ----------------------------------------------

            }
            catch (Exception e)
            {
                //
                // If an error occurs, we report it to the user,
                // with StackTrace for debugging purposes
                //
                MessageBox.Show(e.Message + " - " + e.StackTrace);
                result = -1;
                // ----------------------------------------------
            }

            return result;
        }

        private void btnClearfiles_Click(object sender, EventArgs e)
        {
            ClearFile();
        }

        private List<string> GetFilesToUpload() 
        {
            List<string> paths = new List<string>();

            if (txtFile1.Text != "")
            paths.Add(txtFile1.Text);

            if (txtfile2.Text != "")
            paths.Add(txtfile2.Text);

            if (txtfile3.Text != "")
            paths.Add(txtfile3.Text);

            if (txtfile4.Text != "")
            paths.Add(txtfile4.Text);

            if (txtfile5.Text != "")
            paths.Add(txtfile5.Text);

            return paths;
        }

        private void ClearFile()
        {
            txtFile1.Text = string.Empty;
            txtfile2.Text = string.Empty;
            txtfile3.Text = string.Empty;
            txtfile4.Text = string.Empty;
            txtfile5.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            ofd.ShowDialog();
            if (ofd.FileName == "" || !File.Exists(ofd.FileName))
            {
                //
                // If the requested file is not ok...
                //
                return;
            }

            if (txtFile1.Text == "")
            {
                txtFile1.Text = ofd.FileName;
            }
            else if (txtfile2.Text == "")
            {
                txtfile2.Text = ofd.FileName;

            }
            else if (txtfile3.Text == "")
            {
                txtfile3.Text = ofd.FileName;

            }
            else if (txtfile4.Text == "")
            {
                txtfile4.Text = ofd.FileName;

            }
            else if (txtfile5.Text == "")
            {
                txtfile5.Text = ofd.FileName;

            }
            else
            {
                MessageBox.Show("Maximum number of uploads is five");
            }
        }

        private void btnViewAttachment_Click(object sender, EventArgs e)
        {
            frmAttachments form = new frmAttachments(RowClickUserId);
            form.Show();
        }
    }
}
