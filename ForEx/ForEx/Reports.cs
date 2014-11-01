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

        private void btnTransacDaily_Click(object sender, EventArgs e)
        {
            DateTime start = dtpTransacDaily.Value;

            CrystalReportViewer crv = new CrystalReportViewer(Common.ReportType.AnnexOneDaily, null, start);
            crv.Show();
        }

        private void btnTransactionReportWeekly_Click(object sender, EventArgs e)
        {
            DateTime start = dtpTransacStart.Value;
            DateTime end = dtpTransacEnd.Value;

            CrystalReportViewer crv = new CrystalReportViewer(Common.ReportType.AnnexOneRange, null,start,end);
            crv.Show();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            var listAudit = Enum.GetValues(typeof(Common.Operation)).Cast<Common.Operation>();

            foreach (var value in listAudit)
            {
                Common.ComboboxItem item = new Common.ComboboxItem();
                item.Text = Common.OperationToList(value);
                item.Value = value.ToString();

                cmbAuditType1.Items.Add(item);
                cmbAuditType2.Items.Add(item);

            }
        }

        private void btnAuditDaily_Click(object sender, EventArgs e)
        {
            DateTime start = dtpAuditDaily.Value;

            var op = (cmbAuditType2.SelectedItem as Common.ComboboxItem).Value;

            CrystalReportViewer crv = new CrystalReportViewer(Common.ReportType.AuditDaily, op.ToString(), start);

            crv.Show();
        }

        private void btnAuditRange_Click(object sender, EventArgs e)
        {
            DateTime start = dtpAuditStart.Value;
            DateTime end = dtpAuditEnd.Value;

            var op = (cmbAuditType1.SelectedItem as Common.ComboboxItem).Value;

            CrystalReportViewer crv = new CrystalReportViewer(Common.ReportType.AuditRange, op.ToString(), start, end);
            crv.Show();
        }

           

         
    }
}
