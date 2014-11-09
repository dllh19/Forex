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
            var query = "SELECT * FROM tbl_client WHERE type = 'Individual' isblacklisted = '1' ";
            CrystalReportViewer crv = new CrystalReportViewer(Common.ReportType.BlacklistedIndividuals,query);
            crv.Show();
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            var query = "SELECT * FROM tbl_client WHERE type = 'Bank' AND isblacklisted = '1' ";
            CrystalReportViewer crv = new CrystalReportViewer(Common.ReportType.BlacklistedBank,query);
            crv.Show();
        }

        private void btnCorporate_Click(object sender, EventArgs e)
        {
            var query = "SELECT * FROM tbl_client WHERE type = 'Corporate' AND isblacklisted = '1' ";
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
            var currencies = Common.getAllCurrency();
            cmbCurrency1.DataSource = currencies;
            cmbCurrency1.DisplayMember = "symbol";
            cmbCurrency1.ValueMember = "symbol";

            cmbCurrency2.DataSource = currencies;
            cmbCurrency2.DisplayMember = "symbol";
            cmbCurrency2.ValueMember = "symbol";
            
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

        private void btnBuyTransacPeriod_Click(object sender, EventArgs e)
        {
            DateTime start = dtpBuyTransacStart.Value;
            DateTime end = dtpBuyTransacEnd.Value;

            CrystalReportViewer crv = new CrystalReportViewer(Common.ReportType.TransactionReportPeriod, "Buy", start, end);
            crv.Show();
        }

        private void btnBuyTransacDaily_Click(object sender, EventArgs e)
        {
            DateTime start = dtpBuyTransacDaily.Value;

            CrystalReportViewer crv = new CrystalReportViewer(Common.ReportType.TransactionReportDaily, "Buy", start);

            crv.Show();
        }

        private void btnSellTransacPeriod_Click(object sender, EventArgs e)
        {
            DateTime start = dtpSellTransacStart.Value;
            DateTime end = dtpSellTransacEnd.Value;

            CrystalReportViewer crv = new CrystalReportViewer(Common.ReportType.TransactionReportPeriod, "Sell", start, end);
            crv.Show();
        }

        private void btnSellTransacDaily_Click(object sender, EventArgs e)
        {
            DateTime start = dtpSellTransacDaily.Value;

            CrystalReportViewer crv = new CrystalReportViewer(Common.ReportType.TransactionReportDaily, "Sell", start);
            crv.Show();
        }

        private void btnWaccPeriod_Click(object sender, EventArgs e)
        {
            DateTime start = dtpWaccStart.Value;
            DateTime end = dtpWaccEnd.Value;

            var op = (cmbCurrency1.SelectedItem as Currency).symbol;

            CrystalReportViewer crv = new CrystalReportViewer(Common.ReportType.WaccPeiod, op.ToString() , start, end);
            crv.Show();
        }

        private void btnWaccDaily_Click(object sender, EventArgs e)
        {
            DateTime start = dtpWaccDaily.Value;

            var op = (cmbCurrency1.SelectedItem as Currency).symbol;

            CrystalReportViewer crv = new CrystalReportViewer(Common.ReportType.WaccDaily, op.ToString() , start);
            crv.Show();
        }

        private void grpBlackList_Enter(object sender, EventArgs e)
        {

        }

        private void btnActualTransacDaily_Click(object sender, EventArgs e)
        {
            DateTime start = dtpActualTransacDaily.Value;

            CrystalReportViewer crv = new CrystalReportViewer(Common.ReportType.ActualTransactionDaily, "Actual", start);
            crv.Show();
        }

        private void btnActualTransacPeriod_Click(object sender, EventArgs e)
        {
            DateTime start = dtpActualTransactionStart.Value;
            DateTime end = dtpActualTransactionEnd.Value;

            CrystalReportViewer crv = new CrystalReportViewer(Common.ReportType.ActualTransactionPeriod, "Actual", start, end);
            crv.Show();
        }

           

         
    }
}
