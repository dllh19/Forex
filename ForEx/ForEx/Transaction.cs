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
    public partial class Transaction : Form
    {
        private Clients clients;

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
                MessageBox.Show("Good type");
            }
        }

        //event trigger for type
        private void ComboCurrency_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboType.SelectedItem != null)
            {
                MessageBox.Show("Good currency");
            }
        }


        private void Transaction_Load(object sender, EventArgs e)
        {
            populate_client();
            populate_type();
            populate_currency();
            
        }
    }
}
