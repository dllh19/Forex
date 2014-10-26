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
    public partial class CashIn : Form
    {
        private SqlConnection con = new SqlConnection(Common.GetConnectionString());
        private SqlDataAdapter da = new SqlDataAdapter();
        private SqlCommand cmd = new SqlCommand();

        public CashIn()
        {
            InitializeComponent();
        }

        private void CashIn_Load(object sender, EventArgs e)
        {
            //Query to get last cash out
            con.Open();
            string query = "SELECT [name],[symbol],[date_cashout],[balance] FROM [ForExDB].[dbo].[tbl_cashout] INNER JOIN ( select max([date_cashout]) as MaxDate from [ForExDB].[dbo].[tbl_cashout]) tm on [ForExDB].[dbo].[tbl_cashout].[date_cashout] = tm.MaxDate INNER JOIN [ForExDB].[dbo].[tbl_currency] ON [ForExDB].[dbo].[tbl_currency].[currency_id] = [ForExDB].[dbo].[tbl_cashout].[currency_id]";
            cmd = new SqlCommand(query, con);
            var reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                DataTable myTable = new DataTable();
                myTable.Load(reader);
                gridCashIn.DataSource = myTable;

                con.Close();


            }
            else
            {
                con.Close();
            }
   
        }

        private void btnCashIn_Click(object sender, EventArgs e)
        {
            if (CheckCashIn())
            {
                cmd = new SqlCommand("CashInProcedure", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CurrentDate", SqlDbType.DateTime).Value = DateTime.Now;

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error has occured while trying to cash in. Find more information below :\n" +
                                    ex.InnerException);
                }
                MessageBox.Show("Cash In completed for " + string.Format("{0:d/M/yyyy}", DateTime.Now));
                Common.Audit(Common.Operation.RateUpdate, Common.GetUser().Name + " " + Common.GetUser().Surname + " has just cash in " + DateTime.Now);

            }
        }

        private bool CheckCashIn()
        {
 
                con.Open();
                string query = "SELECT count(*) FROM [tbl_cashin] WHERE CONVERT(VARCHAR(10),[date_cashin],10) =CONVERT(VARCHAR(10),@date_cashin,10) ";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@date_cashin", SqlDbType.DateTime).Value = DateTime.Now;
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

                if (count > 0)
                {
                    MessageBox.Show("You have already cash in today");
                    return false;
                }
                else
                {
                    return true;
                }

        }

    }
}
