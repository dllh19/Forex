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
    public partial class Transaction : Form
    {
        private Clients clients;

        private SqlConnection con = new SqlConnection(Common.GetConnectionString());
        private SqlDataAdapter da = new SqlDataAdapter();
        private SqlCommand cmd = new SqlCommand();

        public Transaction(Clients clients)
        {
            this.clients = clients;
            InitializeComponent();
            
        }

        public Transaction()
        {
            InitializeComponent();
        }

        private void populate_client()
        {
            comboClient.Items.Add("Cash");
            comboClient.SelectedItem = "Cash";
        }

        private void populate_type()
        {
            comboType.Items.Add("Sell");
            comboType.Items.Add("Buy");

            comboType.SelectedIndexChanged += new System.EventHandler(Combotype_SelectedIndexChanged);
        }

        private void populate_currency()
        {
            comboCurrency.DataSource = Common.getAllCurrency();
            comboCurrency.DisplayMember = "symbol";
            comboCurrency.ValueMember = "symbol";
            comboCurrency.SelectedItem = null;

            comboCurrency.SelectedIndexChanged += new System.EventHandler(ComboCurrency_SelectedIndexChanged);
        }

        //event trigger for type
        private void Combotype_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboCurrency.SelectedItem != null)
            {
                var latestCurrency = Common.getRateforToday();
                if (comboType.SelectedItem.ToString() == "Sell")
                {
                    var fileredCurrency = latestCurrency.Where(x => x.Symbol == comboCurrency.SelectedValue.ToString()).Select(x => x.SaleRate);
                    textRateReadOnly.Text = fileredCurrency.First().ToString();
                    textRate.Text = fileredCurrency.First().ToString();

                    textTotal.Text = null;
                    txtAmount.Text = null;
                }
                else
                {
                    var fileredCurrency = latestCurrency.Where(x => x.Symbol == comboCurrency.SelectedValue.ToString()).Select(x => x.PurchaseRate);
                    textRateReadOnly.Text = fileredCurrency.First().ToString();
                    textRate.Text = fileredCurrency.First().ToString();

                    textTotal.Text = null;
                    txtAmount.Text = null;
                }
            }
        }

        //event trigger for type
        private void ComboCurrency_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboType.SelectedItem != null)
            {
                var latestCurrency = Common.getRateforToday();

                if (latestCurrency.Count == 0)
                {
                    MessageBox.Show("No rate for the day! Please insert rate for the day!");
                    return;
                }

                if (comboType.SelectedItem.ToString() == "Sell")
                {
                    var fileredCurrency = latestCurrency.Where(x => x.Symbol == comboCurrency.SelectedValue.ToString()).Select(x => x.SaleRate);
                    textRateReadOnly.Text = fileredCurrency.First().ToString();
                    textRate.Text = fileredCurrency.First().ToString();

                    textTotal.Text = null;
                    txtAmount.Text = null;
                }
                else
                {
                    var fileredCurrency = latestCurrency.Where(x => x.Symbol == comboCurrency.SelectedValue.ToString()).Select(x => x.PurchaseRate);
                    textRateReadOnly.Text = fileredCurrency.First().ToString();
                    textRate.Text = fileredCurrency.First().ToString();

                    textTotal.Text = null;
                    txtAmount.Text = null;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void Transaction_Load(object sender, EventArgs e)
        {
            populate_client();
            populate_type();
            populate_currency();

            this.textRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);

            InitializeDataGridView();
        }

        private bool validateAndCalculate()
        {

            //calculate total
            if (string.IsNullOrEmpty(textRate.Text))
            {
                MessageBox.Show("Rate is empty");
                return false;
            }

            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Please insert an amount");
                return false;
            }

            decimal rate = Convert.ToDecimal(textRate.Text);
            decimal amount = Convert.ToDecimal(txtAmount.Text);
            decimal total = rate * amount;

            //check if CheckIn was done - TODO

            //check if stock is available -TODO

            textTotal.Text = total.ToString();

            return true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (validateAndCalculate())
            {
                //MessageBox.Show("Good");
            }
        }

        private void btnCalAdd_Click(object sender, EventArgs e)
        {
            if (validateAndCalculate())
            {
                var row1 = new object[] { comboType.SelectedItem, comboCurrency.SelectedValue, txtAmount.Text, textRate.Text, textTotal.Text };

                dgvTransaction.Rows.Add(row1);
            }
        }

        private void InitializeDataGridView()
        {
            #region type
            try
            {

                var typeTxt = new DataGridViewTextBoxColumn();
                typeTxt.HeaderText = "Type";
                typeTxt.Name = "Type";
                this.dgvTransaction.Columns.Add(typeTxt);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion

            #region Currency
            try
            {

                var currencyTxt = new DataGridViewTextBoxColumn();
                currencyTxt.HeaderText = "Currency";
                currencyTxt.Name = "Currency";
                this.dgvTransaction.Columns.Add(currencyTxt);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion

            #region Amount
            try
            {

                var amountTxt = new DataGridViewTextBoxColumn();
                amountTxt.HeaderText = "Amount";
                amountTxt.Name = "Amount";
                this.dgvTransaction.Columns.Add(amountTxt);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion

            #region Rates
            try
            {

                var rateTxt = new DataGridViewTextBoxColumn();
                rateTxt.HeaderText = "Rates";
                rateTxt.Name = "Rates";
                this.dgvTransaction.Columns.Add(rateTxt);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion

            #region total
            try
            {

                var totalTxt = new DataGridViewTextBoxColumn();
                totalTxt.HeaderText = "Total";
                totalTxt.Name = "Total";
                this.dgvTransaction.Columns.Add(totalTxt);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion

            // Create an unbound DataGridView by declaring a
            // column count.
            dgvTransaction.ColumnCount = 5;//to be modifiy if column changed
            dgvTransaction.ColumnHeadersVisible = true;
            dgvTransaction.AllowUserToAddRows = false;
            dgvTransaction.ReadOnly = true;
        }

        private int saveReceipt()
        {
            int receiptId = 0;
            try
            {
                cmd = new SqlCommand("INSERT INTO tbl_receipt (teller, date_create, num_transaction, client) VALUES (@teller, @date_created, @num_transaction, @client); " +
                                     "SELECT SCOPE_IDENTITY();");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@teller", "TEST");
                cmd.Parameters.AddWithValue("@date_created", DateTime.Now);
                cmd.Parameters.AddWithValue("@num_transaction", dgvTransaction.Rows.Count);
                cmd.Parameters.AddWithValue("@client", comboClient.SelectedItem.ToString()); // todo - change to implement client name or bank name
                
                try
                {
                    con.Open();
                    var idReturned = cmd.ExecuteScalar();
                    con.Close();
                    receiptId = Convert.ToInt32(idReturned);
                    
                    //save transactions
                    saveTransactions(receiptId);

                    MessageBox.Show("Receipt and transactions saved");
                    return receiptId;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when saving receipt: " + ex.InnerException);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return receiptId;
        }

        private void saveTransactions(int receiptId)
        {
            foreach (DataGridViewRow row in dgvTransaction.Rows)
            {
                cmd =new SqlCommand("INSERT INTO tbl_transaction (type, currency, amount, rates, total, date_created, username, receipt_id) VALUES ( @type, @currency,@amount, @rates, @total, @date_created, @username, @receipt_id)");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@type", row.Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@currency", row.Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@amount", Convert.ToDecimal(row.Cells[2].Value));
                cmd.Parameters.AddWithValue("@rates", Convert.ToDecimal(row.Cells[3].Value));
                cmd.Parameters.AddWithValue("@total", Convert.ToDecimal(row.Cells[4].Value));
                cmd.Parameters.AddWithValue("@date_created", DateTime.Now);
                cmd.Parameters.AddWithValue("@username", Common.GetUser().Username); //todo - change get username
                cmd.Parameters.AddWithValue("@receipt_id", receiptId);

                con.Open();
                int sqlrow = cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void updateBalance(Balance rsBal, Balance curBal)
        {
            List<string> distinctCurrency = new List<string>();
            decimal TotalRsBal = rsBal.balance;

            //get distinct currency in datagridview
            foreach (DataGridViewRow row in dgvTransaction.Rows)
            {
                distinctCurrency.Add(row.Cells[1].Value.ToString());
            }

            distinctCurrency = distinctCurrency.Distinct().ToList();

            List<tempBalance> tb = new List<tempBalance>();

            /*-----BUY ONLY ---------*/
            decimal RsBuytotal = dgvTransaction.Rows.Cast<DataGridViewRow>()
                    .Where(r => Convert.ToString(r.Cells[0].Value.ToString()) == "Buy")
                    .Sum(t => Convert.ToDecimal(t.Cells[4].Value));

            TotalRsBal = TotalRsBal - RsBuytotal;

            decimal newBuyBalance = TotalRsBal;

            tempBalance allBuyRs = new tempBalance();
            allBuyRs.balance = newBuyBalance;
            allBuyRs.currencyId = 1;
            allBuyRs.date = DateTime.Now;
            tb.Add(allBuyRs);

            foreach (string cur in distinctCurrency)
            {
                decimal total = dgvTransaction.Rows.Cast<DataGridViewRow>()
                .Where(r => Convert.ToString(r.Cells[0].Value.ToString()) == "Buy" && Convert.ToString(r.Cells[1].Value.ToString()) == cur)
                .Sum(t => Convert.ToDecimal(t.Cells[2].Value));

                var bo = new tempBalance
                {
                    currencyId = Common.getCurrencyId(cur),
                    balance = Common.getLatestBalanceForToday(cur).balance + total,
                    date = DateTime.Now
                };
                tb.Add(bo);
            }
            /*--------END BUY ONLY----------*/

            /*--------SELL ONLY----------*/
            decimal RsSelltotal = dgvTransaction.Rows.Cast<DataGridViewRow>()
                    .Where(r => Convert.ToString(r.Cells[0].Value.ToString()) == "Sell")
                    .Sum(t => Convert.ToDecimal(t.Cells[4].Value));

            TotalRsBal = TotalRsBal + RsSelltotal;

            decimal newSellBalance = TotalRsBal;

            tempBalance allSellRs = new tempBalance();
            allSellRs.balance = TotalRsBal;
            allSellRs.currencyId = 1;
            allSellRs.date = DateTime.Now;
            tb.Add(allSellRs);

            foreach (string cur in distinctCurrency)
            {
                decimal total = dgvTransaction.Rows.Cast<DataGridViewRow>()
                .Where(r => Convert.ToString(r.Cells[0].Value.ToString()) == "Sell" && Convert.ToString(r.Cells[1].Value.ToString()) == cur)
                .Sum(t => Convert.ToDecimal(t.Cells[2].Value));

                var bo = new tempBalance
                {
                    currencyId = Common.getCurrencyId(cur),
                    balance = Common.getLatestBalanceForToday(cur).balance - total,
                    date = DateTime.Now
                };
                tb.Add(bo);
            }
            /*--------END SELL ONLY----------*/



        }

        private bool validateRsBalance(Balance bl)
        {
            bool value = true;

            decimal total = dgvTransaction.Rows.Cast<DataGridViewRow>()
                    .Where(r => Convert.ToString(r.Cells[0].Value.ToString()) == "Buy")
                    .Sum(t => Convert.ToDecimal(t.Cells[4].Value));

            if (total > bl.balance)
            {
                MessageBox.Show("MUR balance of " + bl.balance.ToString() + " has been exceeded!");
                value = false;
            }

            return value;
        }

        private bool validateCurrencyBalance(Balance bl)
        {
            bool value = true;
            List<string> distinctCurrency = new List<string>();

            //get distinct currency in datagridview
            foreach (DataGridViewRow row in dgvTransaction.Rows)
            {
                distinctCurrency.Add(row.Cells[1].Value.ToString());
            }

            distinctCurrency = distinctCurrency.Distinct().ToList();

            foreach (string cur in distinctCurrency)
            {
                decimal total = dgvTransaction.Rows.Cast<DataGridViewRow>()
                .Where(r => Convert.ToString(r.Cells[0].Value.ToString()) == "Sell" && Convert.ToString(r.Cells[1].Value.ToString()) == cur)
                .Sum(t => Convert.ToDecimal(t.Cells[2].Value));

                if (total > bl.balance)
                {
                    MessageBox.Show(cur + " balance of " + bl.balance.ToString() + " has been exceeded!");
                    value = false;
                    break;
                }
            }

            return value;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (comboClient.SelectedItem == null)
            {
                MessageBox.Show("Please select a client");
                return;
            }

            if (dgvTransaction.Rows.Count == 0)
            {
                MessageBox.Show("No transactions");
                return;
            }

            var currencyBalance = Common.getLatestBalanceForToday(comboCurrency.SelectedValue.ToString()); // todo - not good to fix (make a list of balance)
            var RsBalance = Common.getLatestBalanceForToday("MUR");          

            if (!validateRsBalance(RsBalance))
            {
                return;
            }

            if (!validateCurrencyBalance(currencyBalance))
            {
                return;
            }

            int receiptID =  saveReceipt();

            List<Classes.Transaction> ts = new List<Classes.Transaction>();
            foreach (DataGridViewRow row in dgvTransaction.Rows)
            {
                Classes.Transaction newTs = new Classes.Transaction();
                newTs.type = row.Cells[0].Value.ToString();
                newTs.currency = row.Cells[1].Value.ToString();
                newTs.amount = Convert.ToDecimal(row.Cells[2].Value);
                newTs.rates = Convert.ToDecimal(row.Cells[3].Value);
                newTs.total = Convert.ToDecimal(row.Cells[4].Value);
                newTs.dateCreated = DateTime.Now;
                newTs.username = Common.GetUser().Username;
                newTs.receiptId = receiptID;

                ts.Add(newTs);
            }

            //create audit
            Common.Audit(Common.Operation.Transaction, Common.GetUser().Name + " " + Common.GetUser().Surname + " has processed transaction with Receipt ID: " + receiptID);

            Receipt tick = new Receipt(DateTime.Now, Common.GetUser().Name + " " + Common.GetUser().Surname, ts,receiptID);
            tick.print();

        }
    }
}
