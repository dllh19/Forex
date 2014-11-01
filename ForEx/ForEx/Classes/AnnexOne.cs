using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEx.Classes
{
    class AnnexOne
    {
        public string Symbol { get; set; }

        public string OpeningBalanceOnHand { get; set; }
        public string OpeningBalanceAtBank { get; set; }

        public string ClosingBalanceOnHand { get; set; }
        public string ClosingBalanceAtBank { get; set; }

        public string TransactionBuyCustomer { get; set; }
        public string TransactionBuyBank { get; set; }

        public string TransactionSellCustomer { get; set; }
        public string TransactionSellBank { get; set; }

        public string DateRange { get; set; }
    }
}
