using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForEx.Classes;

namespace ForEx
{
    public partial class frmReports : Form
    {
 

        public frmReports()
        {
            InitializeComponent();
        }

        private void btnIndividuals_Click(object sender, EventArgs e)
        {
            var query = "SELECT * FROM tbl_client WHERE type = 'Individual'";
            CrystalReportViewer crv = new CrystalReportViewer(Common.ReportType.BlacklistedIndividuals,query);
            crv.Show();
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
         var query = "SELECT * FROM tbl_client WHERE type = 'Bank'";
            CrystalReportViewer crv = new CrystalReportViewer(Common.ReportType.BlacklistedBank,query);
            crv.Show();
        }

        private void btnCorporate_Click(object sender, EventArgs e)
        {
         var query = "SELECT * FROM tbl_client WHERE type = 'Corporate'";
            CrystalReportViewer crv = new CrystalReportViewer(Common.ReportType.BlacklistedCorporate,query);
            crv.Show();
        }

           

         
    }
}
