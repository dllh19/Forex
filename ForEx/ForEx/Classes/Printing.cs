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
            pdoc.DefaultPageSettings.PaperSize.Height = 650;

            pdoc.DefaultPageSettings.PaperSize.Width = 170;

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
            Font font = new Font("Courier New", 5);
            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int Offset = 15;
            graphics.DrawString("   Easychange Mauritius Co Ltd", new Font("Courier New", 6),
                                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 11;
            graphics.DrawString("   Queen Mary Avenue, Floreal", new Font("Courier New", 6),
                                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 11;
            graphics.DrawString("     Mauritius Tel: 696 9107", new Font("Courier New", 6),
                                new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 25;
            graphics.DrawString("Date:" + this.CurrentDate,
                     new Font("Courier New", 7),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 11;
            graphics.DrawString("Teller :" + this.TellerName,
                     new Font("Courier New", 6),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 11;
            graphics.DrawString("Transaction ID:" + this.TransactionID,
                     new Font("Courier New", 6),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 11;
            String underLine = "------------------------------------------";


            graphics.DrawString(underLine, new Font("Courier New", 7),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            var ListBuy = transactions.Where(t => t.type == "Buy").ToList();

            if (ListBuy != null && ListBuy.Any())
            {
                Offset = Offset + 25;
                graphics.DrawString("BUYING", new Font("Courier New", 7),
                    new SolidBrush(Color.Black), startX, startY + Offset);

                Offset = Offset + 11;
                graphics.DrawString("CURR  AMT\tRATES\tTOTAL", new Font("Courier New", 7),
                    new SolidBrush(Color.Black), startX, startY + Offset);

                decimal total = 0;
                foreach (var buy in ListBuy)
                {
                    Offset = Offset + 11;
                    graphics.DrawString(string.Format("{0}   {1}\t{2}\t{3}", buy.currency.ToString().Replace(" ", "").Replace("\t", ""), buy.amount, buy.rates, buy.total), new Font("Courier New", 7),
                    new SolidBrush(Color.Black), startX, startY + Offset);

                    total = total + buy.total;
                }
                

                Offset = Offset + 25;
                String BuyingTotal = "Total: " + total;
                graphics.DrawString(BuyingTotal, new Font("Courier New", 7),
                    new SolidBrush(Color.Black), startX, startY + Offset);
            }

             var ListSell = transactions.Where(t => t.type == "Sell").ToList();

            if (ListSell != null && ListSell.Any())
            {
                Offset = Offset + 25;
                graphics.DrawString("SELLING", new Font("Courier New", 7),
                    new SolidBrush(Color.Black), startX, startY + Offset);

                Offset = Offset + 11;
                graphics.DrawString("CURR  AMT\tRATES\tTOTAL", new Font("Courier New", 7),
                    new SolidBrush(Color.Black), startX, startY + Offset);

                decimal total = 0;
                foreach (var sell in ListSell)
                {
                    Offset = Offset + 11;
                    graphics.DrawString(string.Format("{0}   {1}\t{2}\t{3}",sell.currency.ToString().Replace(" ","").Replace("\t",""),sell.amount,sell.rates,sell.total), new Font("Courier New", 7),
                    new SolidBrush(Color.Black), startX, startY + Offset);

                    total = total + sell.total;
                }

                Offset = Offset + 25;
                String Grosstotal = "Total: " + total;
                graphics.DrawString(Grosstotal, new Font("Courier New", 7),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            }

            

            Offset = Offset + 11;
            underLine = "------------------------------------------";

            graphics.DrawString(underLine, new Font("Courier New", 7),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 25;
            graphics.DrawString("Teller Signature:   _______________________", new Font("Courier New",7),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 25;
            graphics.DrawString("Client Signature:   _______________________", new Font("Courier New", 7),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 25;
            graphics.DrawString("Thanks for your business", new Font("Courier New", 7),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 11;
            graphics.DrawString("We hope to see you soon", new Font("Courier New", 7),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 11;
            graphics.DrawString("at your counter", new Font("Courier New", 7),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 11;
            underLine = "------------------------------------------";

            graphics.DrawString(underLine, new Font("Courier New", 6),
                     new SolidBrush(Color.Black), startX, startY + Offset);

        }
    }
}
