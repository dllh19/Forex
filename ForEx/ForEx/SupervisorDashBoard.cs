using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using ForEx.Classes;

namespace ForEx
{
    public partial class frmSupervisorDashBoard : Form
    {
        int lastMinute = 1;

        public frmSupervisorDashBoard()
        {
            InitializeComponent();
        }

        private void btnRateManagement_Click(object sender, EventArgs e)
        {
            var form = new RateManagement();
            form.Show();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            var form = new Transaction();
            form.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var form = new frmReports();
            form.Show();
        }

        private void btnClientManagement_Click(object sender, EventArgs e)
        {
            var form = new frmClientManagement();
            form.Show();
        }

        private void frmSupervisorDashBoard_Load(object sender, EventArgs e)
        {
            var myTimer = new System.Timers.Timer();
            // Tell the timer what top do when it elapses
            myTimer.Elapsed += new ElapsedEventHandler(myEvent);
            // Set it to go off every five seconds
            myTimer.Interval = 10000;
            // And start it        
            myTimer.Enabled = true;

            BindGridRate();
        }

        private void myEvent(object source, ElapsedEventArgs e)
        {
            this.Invoke((Action)(() =>
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
               BindGridRate();
                
            }));
        }
        

        private void BindGridRate()
        {
            var rates = Common.getDashBoardRates();

            BindingSource bs = new BindingSource();
            bs.DataSource = typeof(Rate);
            foreach (var rate in rates)
            {
                bs.Add(rate);
            }
            dataGridView1.DataSource = bs;

            this.dataGridView1.Columns["CurrencyId"].Visible = false;
            this.dataGridView1.Columns["PurchaseMin"].Visible = false;
            this.dataGridView1.Columns["PurchaseMax"].Visible = false;
            this.dataGridView1.Columns["SaleMin"].Visible = false;
            this.dataGridView1.Columns["SaleMax"].Visible = false;
            this.dataGridView1.Columns["SaleMidrate"].Visible = false;
            this.dataGridView1.Columns["PurchaseMidrate"].Visible = false;
            this.dataGridView1.Columns["BankPurchase"].Visible = false;
            this.dataGridView1.Columns["BankSale"].Visible = false;

            this.dataGridView1.AllowUserToResizeRows = false;
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            Common.UnsetUser();
            this.Hide();
            var login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            var transaction = new Transaction();
            transaction.Show();
        }

        private void btnTrnsactionSearch_Click(object sender, EventArgs e)
        {
            var searchtransac = new frmSearchTransaction();
            searchtransac.Show();
        }
    }
}
