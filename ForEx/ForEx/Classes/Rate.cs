using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEx.Classes
{
    class Rate
    {
        public int CurrencyId { get; set; }

        public string Symbol { get; set; }

        public decimal PurchaseMin { get; set; }

        public decimal PurchaseMax { get; set; }

        public decimal PurchaseRate { get; set; }

        public decimal PurchaseMidrate { get; set; }

        public decimal SaleMin { get; set; }

        public decimal SaleMax { get; set; }

        public decimal SaleRate { get; set; }

        public decimal SaleMidrate { get; set; }

        public decimal BankPurchase { get; set; }

        public decimal BankSale { get; set; }

        public Rate(int CurrencyId, string Symbol,decimal PurchaseMin,decimal PurchaseMax,decimal PurchaseRate,decimal PurchaseMidrate,decimal SaleMin,decimal SaleMax,decimal SaleRate,decimal SaleMidrate,decimal BankPurchase,decimal BankSale)
        {
            this.CurrencyId = CurrencyId;
            this.Symbol = Symbol;
            this.PurchaseMin = PurchaseMin;
            this.PurchaseMax = PurchaseMax;
            this.PurchaseRate = PurchaseRate;
            this.PurchaseMidrate = PurchaseMidrate;
            this.SaleMin = SaleMin;
            this.SaleMax = SaleMax;
            this.SaleRate = SaleRate;
            this.SaleMidrate = SaleMidrate;
            this.BankPurchase = BankPurchase;
            this.BankSale = BankSale;

        }

    }
}
