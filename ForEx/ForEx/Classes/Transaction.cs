using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEx.Classes
{
    public class Transaction
    {
        public int id;
        public string type;
        public string currency;
        public decimal amount;
        public decimal rates;
        public decimal total;
        public DateTime dateCreated;
        public string username;
        public int receiptId;
        public int clientcode;
    }
}
