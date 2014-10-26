using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEx.Classes
{
    public class Receipt
    {
        private PrintDocument pdoc;
        public DateTime CurrentDate { get; set; }
        public string TellerName { get; set; }

        public int TransactionID { get; set; }
        public List<Classes.Transaction> transactions { get; set; }

        public Receipt()
        {
            
        }

        public Receipt(DateTime CurrentDate, string TellerName, List<Classes.Transaction> transactions, int TransactionID)
        {
            this.CurrentDate = CurrentDate;
            this.TellerName = TellerName;
            this.transactions = transactions;
            this.TransactionID = TransactionID;
        }

        public void print()
        {
            PrintDialog pd = new PrintDialog();
            pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Courier New", 15);


            PaperSize psize = new PaperSize("Custom", 100, 200);
            //ps.DefaultPageSettings.PaperSize = psize;

            pd.Document = pdoc;
            pd.Document.DefaultPageSettings.PaperSize = psize;
            //pdoc.DefaultPageSettings.PaperSize.Height =320;
            pdoc.DefaultPageSettings.PaperSize.Height = 820;

            pdoc.DefaultPageSettings.PaperSize.Width = 520;

            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);

            DialogResult result = pd.ShowDialog();
            if (result == DialogResult.OK)
            {
                PrintPreviewDialog pp = new PrintPreviewDialog();
                pp.Document = pdoc;
                result = pp.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pdoc.Print();
                }
            }

        }
        void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 10);
            float fontHeight = font.GetHeight();
            int startX = 50;
            int startY = 55;
            int Offset = 40;
            graphics.DrawString("   Easychange Mauritius Co Ltd", new Font("Courier New", 14),
                                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("   Queen Mary Avenue, Floreal", new Font("Courier New", 14),
                                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("     Mauritius Tel: 696 9107", new Font("Courier New", 14),
                                new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 50;
            graphics.DrawString("Date:" + this.CurrentDate,
                     new Font("Courier New", 14),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Teller :" + this.TellerName,
                     new Font("Courier New", 12),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("Transaction ID:" + this.TransactionID,
                     new Font("Courier New", 12),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            String underLine = "------------------------------------------";


            graphics.DrawString(underLine, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            var ListBuy = transactions.Where(t => t.type == "Buy").ToList();

            if (ListBuy != null && ListBuy.Any())
            {
                Offset = Offset + 50;
                graphics.DrawString("BUYING", new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX, startY + Offset);

                Offset = Offset + 20;
                graphics.DrawString("TYPE \t CURR \t \t AMT \t RATES \t TOTAL", new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX, startY + Offset);

                decimal total = 0;
                foreach (var buy in ListBuy)
                {
                    Offset = Offset + 20;
                    graphics.DrawString(buy.type.ToString() + "\t " + buy.currency.ToString() + "\t " + buy.amount.ToString() + " \t " + buy.rates.ToString() + " \t " + buy.total.ToString() + "", new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX, startY + Offset);

                    total = total + buy.total;
                }
                

                Offset = Offset + 50;
                String BuyingTotal = "Total: " + total;
                graphics.DrawString(BuyingTotal, new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX, startY + Offset);
            }

             var ListSell = transactions.Where(t => t.type == "Sell").ToList();

            if (ListSell != null && ListSell.Any())
            {
                Offset = Offset + 50;
                graphics.DrawString("SELLING", new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX, startY + Offset);

                Offset = Offset + 20;
                graphics.DrawString("TYPE \t CURR \t \t AMT \t RATES \t TOTAL", new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX, startY + Offset);

                decimal total = 0;
                foreach (var sell in ListSell)
                {
                    Offset = Offset + 20;
                    graphics.DrawString(sell.type.ToString() + "\t " + sell.currency.ToString() + "\t " + sell.amount.ToString() + " \t " + sell.rates.ToString() + " \t " + sell.total.ToString() + "", new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX, startY + Offset);

                    total = total + sell.total;
                }

                Offset = Offset + 50;
                String Grosstotal = "Total: " + total;
                graphics.DrawString(Grosstotal, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            }

            

            Offset = Offset + 20;
            underLine = "------------------------------------------";

            graphics.DrawString(underLine, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 50;
            graphics.DrawString("Teller Signature: \t _______________________", new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 50;
            graphics.DrawString("Client Signature: \t _______________________", new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 50;
            graphics.DrawString("Thanks for your business", new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("We hope to see you soon", new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("at your counter", new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            underLine = "------------------------------------------";

            graphics.DrawString(underLine, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);

        }
    }
}
