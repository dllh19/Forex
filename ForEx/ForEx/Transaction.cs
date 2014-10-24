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

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Transaction_Load(object sender, EventArgs e)
        {

        }
    }
}
