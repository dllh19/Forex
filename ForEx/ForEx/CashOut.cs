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
    public partial class CashOut : Form
    {
        private SqlConnection con = new SqlConnection(Common.GetConnectionString());
        private SqlDataAdapter da = new SqlDataAdapter();
        private SqlCommand cmd = new SqlCommand();


        public CashOut()
        {
            InitializeComponent();
        }

        private void CashOut_Load(object sender, EventArgs e)
        {
            //Query to get last transaction for each currency
            con.Open();
            string query = "SELECT DISTINCT([currencyid]),[tbl_transacid],[name],[symbol],[date_inserted],[balance]" +
                           " FROM [ForExDB].[dbo].[tbl_transactemp] INNER JOIN ( select max([date_inserted])" +
                           " as MaxDate from [ForExDB].[dbo].[tbl_transactemp]) tm on" +
                           " [ForExDB].[dbo].[tbl_transactemp].[date_inserted] = tm.MaxDate " +
                           "INNER JOIN [ForExDB].[dbo].[tbl_currency] ON [ForExDB].[dbo].[tbl_currency].[currency_id]" +
                           " = [ForExDB].[dbo].[tbl_transactemp].[currencyid]";
            cmd = new SqlCommand(query, con);
            var reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                DataTable myTable = new DataTable();
                myTable.Load(reader);
                gridCashOut.DataSource = myTable;

                con.Close();


            }
            else
            {
                con.Close();
            }
   
        }

        private void btnCashOut_Click(object sender, EventArgs e)
        {
            if (!CheckCashOut())
            {
                MessageBox.Show("You have already cash out today");
            }
            else if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter the supervisor\'s username and password");
            }
            else
            {
                if (CheckSupervisor(txtUsername.Text, txtPassword.Text))
                {
                    cmd = new SqlCommand("CashOutProcedure", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                   
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                   
                    MessageBox.Show("Cash Out completed for " + string.Format("{0:d/M/yyyy}",DateTime.Now));
                    Common.Audit(Common.Operation.RateUpdate, Common.GetUser().Name + " " + Common.GetUser().Surname + " has just cash out " + DateTime.Now);

                }
            }

        }

        private bool CheckSupervisor(string username,string password)
        {
            con.Open();
            string query = "SELECT count(*) FROM tbl_users  WHERE Username=@username AND Password = @Password AND role=supervisor";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Wrong username or password has been entered");
                return false;
            }

        }

        private bool CheckCashOut()
        {

            con.Open();
            string query = "SELECT count(*) FROM [tbl_cashout] WHERE CONVERT(VARCHAR(10),[date_cashout],10) =CONVERT(VARCHAR(10),@date_cashout,10) ";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@date_cashout", SqlDbType.DateTime).Value = DateTime.Now;
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (count > 0)
            {
               return false;
            }
            else
            {
                return true;
            }

        }

    }
}
