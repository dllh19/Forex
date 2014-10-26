using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForEx.Classes;

namespace ForEx
{
    public partial class ManagerDashboard : Form
    {
        public ManagerDashboard()
        {
            InitializeComponent();
        }

        private void btnClientManagement_Click(object sender, EventArgs e)
        {
            var form = new frmClientManagement();
            form.Show();
        }

        private void btnRateManagement_Click(object sender, EventArgs e)
        {
            var form = new RateManagement();
            form.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var form = new frmReports();
            form.Show();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            var form = new Transaction();
            form.Show();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            var form = new UserManagement();
            form.Show();
        }

        private void ManagerDashboard_Load(object sender, EventArgs e)
        {
            BindGridRate();
        }

        private void BindGridRate()
        {
            var rates = Common.getRateforToday();

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

            this.dataGridView1.AllowUserToResizeRows = false;
        }
    }
}
