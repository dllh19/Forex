using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEx.Classes
{
    class TransactionData
    {
        public string Currency { get; set; }
        public string Amount { get; set; }
        public string Rates { get; set; }
        public string Total { get; set; }
        public string DateCreated { get; set; }
        public string TellerUsername { get; set; }
        public string ReceiptId { get; set; }
        public string ClientName { get; set; }
        public string ClientType { get; set; }
        public string TransactionType { get; set; }
        public string DateRange { get; set; }

    }
}
