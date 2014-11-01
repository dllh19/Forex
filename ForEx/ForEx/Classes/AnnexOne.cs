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

        public decimal OpeningBalanceOnHand { get; set; }
        public decimal OpeningBalanceAtBank { get; set; }

        public decimal ClosingBalanceOnHand { get; set; }
        public decimal ClosingBalanceAtBank { get; set; }

        public decimal TransactionBuyCustomer { get; set; }
        public decimal TransactionBuyBank { get; set; }

        public decimal TransactionSellCustomer { get; set; }
        public decimal TransactionSellBank { get; set; }

        public decimal TransactionCustomer { get; set; }
        public decimal TransactionBank { get; set; }

        public string DateRange { get; set; }
    }
}
