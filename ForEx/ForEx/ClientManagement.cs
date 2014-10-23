using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEx
{
    public partial class frmClientManagement : Form
    {
        private SqlConnection con;
        private SqlDataAdapter da;
        private SqlCommand cmd;

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
                con = new SqlConnection(Common.GetConnectionString());
                cmd = new SqlCommand("INSERT INTO tbl_client (type, name, surname, dob, nationality, country, address, phone, email, id_type,passport_no, occupation, username, isblacklisted) VALUES (@type, @name, @surname,@dob, @nationality, @country, @address, @phone, @email , @id_type, @passport_no, @occupation, @username , 'false')");
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
                con.Open();
                int row = cmd.ExecuteNonQuery();
                con.Close();

                if (row > 0)
                {
                    MessageBox.Show("Client has been added successfully");
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
                con = new SqlConnection(Common.GetConnectionString());
                cmd = new SqlCommand("INSERT INTO tbl_client (type, company_name, contact_person, date_incorporated, vat, nationality, country, address, phone, email, brn, username, isblacklisted) VALUES (@type, @company_name, @contact_name, @date_incorporated, @vat, @nationality, @country, @address, @phone, @email , @brn, @username , 'false')");
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
                con.Open();
                int row = cmd.ExecuteNonQuery();
                con.Close();

                if (row > 0)
                {
                    MessageBox.Show("Bank/Corporate has been added successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
