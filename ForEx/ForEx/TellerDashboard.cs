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
    public partial class TellerDashboard : Form
    {
        public TellerDashboard()
        {
            InitializeComponent();
        }

        private void TellerDashboard_Load(object sender, EventArgs e)
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

        private void btnSignout_Click(object sender, EventArgs e)
        {
            Common.UnsetUser();
            this.Hide();
            var login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }
    }
}
