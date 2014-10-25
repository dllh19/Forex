using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEx
{
    public partial class frmSupervisorDashBoard : Form
    {
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
    }
}
