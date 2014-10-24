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
using Telerik.WinControls.Data;

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

            bs.DataSource = typeof(Rate);
            bs.Add(new Rate(1, "MUR", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            bs.Add(new Rate(2, "AED", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            bs.Add(new Rate(3, "AUD", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            bs.Add(new Rate(4, "CAD", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            bs.Add(new Rate(5, "CHF", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            bs.Add(new Rate(6, "EUR", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            bs.Add(new Rate(7, "GBP", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            bs.Add(new Rate(8, "HKD", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            bs.Add(new Rate(9, "USD", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

            gridUpdateRate.DataSource = bs;                                           
            gridUpdateRate.AutoGenerateColumns = true; 
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
                MessageBox.Show("Rates have been updated for date: " + string.Format("{0:d/M/yyyy}", DateTime.Now));

        }

        private bool CheckForRatesToday()
        {
            return true;
        }

    }
}
