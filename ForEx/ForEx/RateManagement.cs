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
    public partial class RateManagement : Form
    {
        BindingSource bs = new BindingSource();
        private SqlConnection con = new SqlConnection(Common.GetConnectionString());
        private SqlDataAdapter da = new SqlDataAdapter();
        private SqlCommand cmd = new SqlCommand();
 
        public RateManagement()
        {
            InitializeComponent();
        }

        private void RateManagement_Load(object sender, EventArgs e)
        {
            gridUpdateRate.AllowUserToAddRows = false;

            con.Open();
            string query = "SELECT * FROM tbl_rate  WHERE CONVERT(VARCHAR(10),date_updated,10)=CONVERT(VARCHAR(10),@DateCreated,10) ";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@DateCreated", SqlDbType.DateTime).Value = DateTime.Now;
                var reader = cmd.ExecuteReader();

            bs.DataSource = typeof(Rate);
            if (reader.HasRows)
            {
                DataTable myTable = new DataTable();
                myTable.Load(reader);
                foreach (DataRow row in myTable.Rows)
                {
                    var CurrencyId =  Convert.ToInt32(row["CurrencyId"].ToString());
                    var Symbol =row["Symbol"].ToString();
                    var PurchaseMin = Convert.ToDecimal(row["PurchaseMin"]);
                    var PurchaseMax = Convert.ToDecimal(row["PurchaseMax"]);
                    var PurchaseRate = Convert.ToDecimal(row["PurchaseRate"]);
                    var PurchaseMidrate = Convert.ToDecimal(row["PurchaseMidrate"]);
                    var SaleMin = Convert.ToDecimal(row["SaleMin"]);
                    var SaleMax = Convert.ToDecimal(row["SaleMax"]);
                    var SaleRate = Convert.ToDecimal(row["SaleRate"]);
                    var SaleMidrate = Convert.ToDecimal(row["SaleMidrate"]);
                    var BankPurchase = Convert.ToDecimal(row["BankPurchase"]);
                    var BankSale = Convert.ToDecimal(row["BankSale"]);

                    bs.Add(new Rate(CurrencyId, Symbol, PurchaseMin, PurchaseMax,
                        PurchaseRate, PurchaseMidrate, SaleMin, 
                        SaleMax, SaleRate, SaleMidrate, BankPurchase, BankSale));
                }
        
            }
            else
            {
                
                bs.Add(new Rate(1, "MUR", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                bs.Add(new Rate(2, "AED", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                bs.Add(new Rate(3, "AUD", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                bs.Add(new Rate(4, "CAD", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                bs.Add(new Rate(5, "CHF", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                bs.Add(new Rate(6, "EUR", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                bs.Add(new Rate(7, "GBP", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                bs.Add(new Rate(8, "HKD", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                bs.Add(new Rate(9, "USD", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            }
            con.Close();
            

            gridUpdateRate.DataSource = bs;                                           
            gridUpdateRate.AutoGenerateColumns = true;

            //hide and change column name -David
            changeGridProperty();
        }

        private void gridUpdateRate_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void gridUpdateRate_DataSourceChanged(object sender, EventArgs e)
        {
            
        }

        private void gridUpdateRate_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            Rate obj = (Rate)gridUpdateRate.Rows[e.RowIndex].DataBoundItem;
            if (obj.PurchaseRate != 0)
            {
                obj.PurchaseMin = obj.PurchaseRate - 0.20M;
                obj.PurchaseMax = obj.PurchaseRate + 0.20M;
                obj.PurchaseMidrate = (obj.PurchaseMin + obj.PurchaseMax) / 2;
            }

            if (obj.SaleRate != 0)
            {
                obj.SaleMin = obj.SaleRate - 0.20M;
                obj.SaleMax = obj.SaleRate + 0.20M;
                obj.SaleMidrate = (obj.SaleMin + obj.SaleMax) / 2;
            }
        }

        private void btnUpdateRate_Click(object sender, EventArgs e)
        {
            List<Rate> lstRates = new List<Rate>();
            foreach (DataGridViewRow rows in gridUpdateRate.Rows)
            {
                lstRates.Add((Rate) rows.DataBoundItem);
            }

            bool error = true;
            DateTime currentdate = DateTime.Now;
            foreach (var rates in lstRates)
            {
                try
                {

                        cmd =
                          new SqlCommand(
                              "INSERT INTO tbl_rate VALUES ( @Symbol, @PurchaseMin,@PurchaseMax, @PurchaseRate, @PurchaseMidrate,@SaleMin,@SaleMax,@SaleRate,@SaleMidrate,@BankPurchase,@BankSale,@date_updated,@CurrencyId)");
                     
                    
                    
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@Symbol", rates.Symbol);
                    cmd.Parameters.AddWithValue("@PurchaseMin", rates.PurchaseMin);
                    cmd.Parameters.AddWithValue("@PurchaseMax", rates.PurchaseMax);
                    cmd.Parameters.AddWithValue("@PurchaseRate", rates.PurchaseRate);
                    cmd.Parameters.AddWithValue("@PurchaseMidrate", rates.PurchaseMidrate);
                    cmd.Parameters.AddWithValue("@SaleMin", rates.SaleMin);
                    cmd.Parameters.AddWithValue("@SaleMax", rates.SaleMax);
                    cmd.Parameters.AddWithValue("@SaleRate", rates.SaleRate);
                    cmd.Parameters.AddWithValue("@SaleMidrate", rates.SaleMidrate);
                    cmd.Parameters.AddWithValue("@BankPurchase", rates.BankPurchase);
                    cmd.Parameters.AddWithValue("@BankSale", rates.BankSale);
                    cmd.Parameters.AddWithValue("@date_updated", currentdate);
                    cmd.Parameters.AddWithValue("@CurrencyId", rates.CurrencyId);
                    con.Open();
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    con.Close();
                    error = true;
                    MessageBox.Show("An error has occured when trying to update the rates: " + ex.InnerException);
                }
                finally
                {
                    error = false;
                }

            }

            if (!error)
            {
                MessageBox.Show("Rates have been updated for date: " + string.Format("{0:d/M/yyyy}", DateTime.Now));
                Common.Audit(Common.Operation.RateUpdate,
                    Common.GetUser().Username + " has update the rates at " + currentdate);
            }

        }

        private bool CheckForRatesToday()
        {
            return true;
        }

        private void dtpRate_Validated(object sender, EventArgs e)
        {
           
        }

        private void dtpRate_ValueChanged(object sender, EventArgs e)
        {
            gridSearchRate.DataSource = null;
            gridSearchRate.Rows.Clear();
            gridSearchRate.Refresh();
            
            var dateSelected = dtpRate.Value;
            BindingSource bs2 = new BindingSource();

            con.Open();
            string query = "   SELECT *  FROM [ForExDB].[dbo].[tbl_rate] INNER JOIN ( select max([date_updated]) "+
                           " as MaxDate from [ForExDB].[dbo].[tbl_rate]) tm on "+
                            "[ForExDB].[dbo].[tbl_rate].[date_updated] = tm.MaxDate "+
                           "WHERE CONVERT(VARCHAR(10),[date_updated],10)=CONVERT(VARCHAR(10),@DateCreated,10)" ;
            cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@DateCreated", SqlDbType.DateTime).Value = dateSelected;
            var reader = cmd.ExecuteReader();

            bs2.DataSource = typeof(Rate);
            if (reader.HasRows)
            {
                DataTable myTable = new DataTable();
                myTable.Load(reader);
                foreach (DataRow row in myTable.Rows)
                {
                    var CurrencyId = Convert.ToInt32(row["CurrencyId"].ToString());
                    var Symbol = row["Symbol"].ToString();
                    var PurchaseMin = Convert.ToDecimal(row["PurchaseMin"]);
                    var PurchaseMax = Convert.ToDecimal(row["PurchaseMax"]);
                    var PurchaseRate = Convert.ToDecimal(row["PurchaseRate"]);
                    var PurchaseMidrate = Convert.ToDecimal(row["PurchaseMidrate"]);
                    var SaleMin = Convert.ToDecimal(row["SaleMin"]);
                    var SaleMax = Convert.ToDecimal(row["SaleMax"]);
                    var SaleRate = Convert.ToDecimal(row["SaleRate"]);
                    var SaleMidrate = Convert.ToDecimal(row["SaleMidrate"]);
                    var BankPurchase = Convert.ToDecimal(row["BankPurchase"]);
                    var BankSale = Convert.ToDecimal(row["BankSale"]);

                    bs2.Add(new Rate(CurrencyId, Symbol, PurchaseMin, PurchaseMax,
                        PurchaseRate, PurchaseMidrate, SaleMin,
                        SaleMax, SaleRate, SaleMidrate, BankPurchase, BankSale));
                }

                gridSearchRate.DataSource = bs2;
                gridSearchRate.Enabled = true;

                con.Close();
            }
        }

        private void changeGridProperty()
        {
            this.gridUpdateRate.Columns["CurrencyId"].Visible = false;
            this.gridUpdateRate.Columns["PurchaseMin"].Visible = false;
            this.gridUpdateRate.Columns["PurchaseMax"].Visible = false;
            this.gridUpdateRate.Columns["SaleMin"].Visible = false;
            this.gridUpdateRate.Columns["SaleMax"].Visible = false;
            this.gridUpdateRate.Columns["SaleMidrate"].Visible = false;
            this.gridUpdateRate.Columns["PurchaseMidrate"].Visible = false;

            this.gridUpdateRate.AllowUserToResizeRows = false;




        }

        private void gridUpdateRate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

    }
}
