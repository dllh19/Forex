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
using ForEx.Classes;

namespace ForEx
{
    public partial class frmSearchTransaction : Form
    {
        private SqlConnection con = new SqlConnection(Common.GetConnectionString());
        private SqlDataAdapter da = new SqlDataAdapter();
        private SqlCommand cmd = new SqlCommand();

        private BindingSource bs;

        private List<Classes.Transaction> listtransac;
 
        public frmSearchTransaction()
        {
            InitializeComponent();
        }

        private void radTransacID_CheckedChanged(object sender, EventArgs e)
        {
            if (radTransacID.Checked)
            {
                txtReceiptID.ReadOnly = true;
                txtTransactionID.ReadOnly = false;
            }
        }

        private void radReceiptID_CheckedChanged(object sender, EventArgs e)
        {
            if (radReceiptID.Checked)
            {
                txtReceiptID.ReadOnly = false;
                txtTransactionID.ReadOnly = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string procedure = string.Empty;
            int ID = 0;

            if (radReceiptID.Checked)
            {
                if (txtReceiptID.Text == "")
                {
                    MessageBox.Show("Please enter a receipt ID");
                    
                }
                else
                {
                    procedure = "SearchTransactionByReceiptID";
                    ID = Convert.ToInt32(txtReceiptID.Text);
                }
            }
            else
            {
                if (txtTransactionID.Text == "")
                {
                    MessageBox.Show("Please enter a transaction ID");
                    
                }
                else
                {
                    procedure = "SearchTransactionByID";
                    ID = Convert.ToInt32(txtTransactionID.Text);
                }
            }

            listtransac = GetTransaction(procedure, ID);

            if (listtransac.Any())
            {

                foreach (Classes.Transaction transac in listtransac)
                {
                    var row1 = new object[] { transac.type, transac.currency, transac
                        .amount.ToString(), transac.rates.ToString(), transac.total.ToString() };

                    dgvTrnsaction.Rows.Add(row1);
                }


                var clientcode = listtransac.FirstOrDefault().clientcode;

                string query = "SELECT * FROM tbl_client WHERE code = '" + clientcode + "'";
                var listclient = ListClient(query);

                if (listclient.Any())
                {
                    BindingSource bs2 = new BindingSource();
                    bs2.DataSource = typeof(Classes.Clients);
                    foreach (var client in listclient)
                    {
                        bs2.Add(client);
                    }
                    dgvClientInfo.DataSource = bs2;
                }
            }
            else
            {
                MessageBox.Show("No transaction found for this id");
            }

        }

        private List<Clients> ListClient(string query)
        {

            con.Open();

            List<Clients> ListClients = new List<Clients>();

            cmd = new SqlCommand(query, con);
            var reader = cmd.ExecuteReader();
            try
            {
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

                        int NoOfTransaction;
                        if (!string.IsNullOrEmpty(row["TotalTransaction"].ToString()))
                            NoOfTransaction = Convert.ToInt32(row["TotalTransaction"].ToString());
                        else
                            NoOfTransaction = 0;

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
                            NoOfTransaction = NoOfTransaction.ToString()
                        };

                        ListClients.Add(clients);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured while generating the report: " + ex.InnerException);
            }
            finally
            {
                con.Close();
            }

            return ListClients;
        }
        private List<Classes.Transaction> GetTransaction(string procedure, int ID)
        {
            con.Open();

            List<Classes.Transaction> transac = new List<Classes.Transaction>();

            cmd = new SqlCommand(procedure, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

            var reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    DataTable myTable = new DataTable();
                    myTable.Load(reader);
                    foreach (DataRow row in myTable.Rows)
                    {
                        int id;
                        if (!string.IsNullOrEmpty(row["transaction_id"].ToString()))
                            id = Convert.ToInt32(row["transaction_id"].ToString());
                        else
                            id = 0;

                        string type;
                        if (!string.IsNullOrEmpty(row["TransactionType"].ToString()))
                        {
                            type = (row["TransactionType"]).ToString();
                        }
                        else
                        {
                            type = "NULL";
                        }

                        string currency;
                        if (!string.IsNullOrEmpty(row["currency"].ToString()))
                        {
                            currency = (row["currency"]).ToString();
                        }
                        else
                        {
                            currency = "NULL";
                        }

                        decimal amount;
                        if (!string.IsNullOrEmpty(row["amount"].ToString()))
                            amount = Convert.ToDecimal(row["amount"].ToString());
                        else
                            amount = 0;

                        decimal rates;
                        if (!string.IsNullOrEmpty(row["rates"].ToString()))
                            rates = Convert.ToDecimal(row["rates"].ToString());
                        else
                            rates = 0;

                        decimal total;
                        if (!string.IsNullOrEmpty(row["total"].ToString()))
                            total = Convert.ToDecimal(row["total"].ToString());
                        else
                            total = 0;

                        DateTime datecreated =
                            datecreated = Convert.ToDateTime(row["DateCreated"].ToString());

                        string username;
                        if (!string.IsNullOrEmpty(row["username"].ToString()))
                        {
                            username = (row["username"]).ToString();
                        }
                        else
                        {
                            username = "NULL";
                        }


                        int receiptid;
                        if (!string.IsNullOrEmpty(row["receipt_id"].ToString()))
                            receiptid = Convert.ToInt32(row["receipt_id"].ToString());
                        else
                            receiptid = 0;

                        int client_code;
                        if (!string.IsNullOrEmpty(row["client_code"].ToString()))
                            client_code = Convert.ToInt32(row["client_code"].ToString());
                        else
                            client_code = 0;

                        Classes.Transaction transaction = new Classes.Transaction
                        {
                            id = id,
                            type = type,
                            currency = currency,
                            amount = amount,
                            rates = rates,
                            total = total,
                            dateCreated = datecreated,
                            username = username,
                            receiptId = receiptid,
                            clientcode = client_code
                        };
                        transac.Add(transaction);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured while generating the report: " + ex.InnerException);
            }
            finally
            {
                con.Close();
            }

            return transac;
        }

        private void btnShowReceipt_Click(object sender, EventArgs e)
        {
            Print(listtransac.FirstOrDefault().dateCreated, listtransac.FirstOrDefault().username, listtransac, listtransac.FirstOrDefault().receiptId);
        }

        private void Print(DateTime date, String name, List<Classes.Transaction> ts, int receiptID)
        {
            Receipt tick = new Receipt(date, name, ts, receiptID);
            tick.print();
        }

        private void frmSearchTransaction_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            #region type
            try
            {

                var typeTxt = new DataGridViewTextBoxColumn();
                typeTxt.HeaderText = "Type";
                typeTxt.Name = "Type";
                this.dgvTrnsaction.Columns.Add(typeTxt);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion

            #region Currency
            try
            {

                var currencyTxt = new DataGridViewTextBoxColumn();
                currencyTxt.HeaderText = "Currency";
                currencyTxt.Name = "Currency";
                this.dgvTrnsaction.Columns.Add(currencyTxt);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion

            #region Amount
            try
            {

                var amountTxt = new DataGridViewTextBoxColumn();
                amountTxt.HeaderText = "Amount";
                amountTxt.Name = "Amount";
                this.dgvTrnsaction.Columns.Add(amountTxt);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion

            #region Rates
            try
            {

                var rateTxt = new DataGridViewTextBoxColumn();
                rateTxt.HeaderText = "Rates";
                rateTxt.Name = "Rates";
                this.dgvTrnsaction.Columns.Add(rateTxt);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion

            #region total
            try
            {

                var totalTxt = new DataGridViewTextBoxColumn();
                totalTxt.HeaderText = "Total";
                totalTxt.Name = "Total";
                this.dgvTrnsaction.Columns.Add(totalTxt);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion

            // Create an unbound DataGridView by declaring a
            // column count.
            dgvTrnsaction.ColumnCount = 5;//to be modifiy if column changed
            dgvTrnsaction.ColumnHeadersVisible = true;
            dgvTrnsaction.AllowUserToAddRows = false;
            dgvTrnsaction.ReadOnly = true;
        }
    }
}
