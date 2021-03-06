﻿using System;
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
    public partial class CrystalReportViewer : Form
    {
        private SqlConnection con = new SqlConnection(Common.GetConnectionString());
        private SqlDataAdapter da = new SqlDataAdapter();
        private SqlCommand cmd = new SqlCommand();


        public CrystalReportViewer()
        {
            InitializeComponent();
        }

        public CrystalReportViewer(Common.ReportType reportype, string query)
        {
            InitializeComponent();
            GenerateReport(reportype, query, DateTime.Now, DateTime.Now);
        }

        public CrystalReportViewer(Common.ReportType reportype, string query, DateTime daily)
        {
            InitializeComponent();
            GenerateReport(reportype, query, daily, DateTime.Now);
        }

        public CrystalReportViewer(Common.ReportType reportype, string query, DateTime start, DateTime end)
        {
            InitializeComponent();
            GenerateReport(reportype, query, start, end);
        }

        private void GenerateReport(Common.ReportType reportype, string query, DateTime start, DateTime end)
        {

            switch (reportype)
            {
                case (Common.ReportType.BlacklistedIndividuals):
                    Reports.BlackListedIndividuals cr = new Reports.BlackListedIndividuals();
                    crystalReportViewer1.ReportSource = cr;

                    cr.SetDataSource(BlackListedClient(query));
                    break;

                case (Common.ReportType.BlacklistedBank):
                    Reports.BlackListedBankCorporate cr2 = new Reports.BlackListedBankCorporate();
                    crystalReportViewer1.ReportSource = cr2;

                    cr2.SetDataSource(BlackListedClient(query));
                    break;

                case (Common.ReportType.BlacklistedCorporate):
                    Reports.BlackListedBankCorporate cr3 = new Reports.BlackListedBankCorporate();
                    crystalReportViewer1.ReportSource = cr3;

                    cr3.SetDataSource(BlackListedClient(query));
                    break;

                case (Common.ReportType.ClientIndividuals):
                    Reports.ListClientReport lcr = new Reports.ListClientReport();
                    crystalReportViewer1.ReportSource = lcr;

                    lcr.SetDataSource(ListClient(query));
                    break;

                case (Common.ReportType.ClientBank):
                    Reports.ListClientReport lcr2 = new Reports.ListClientReport();
                    crystalReportViewer1.ReportSource = lcr2;

                    lcr2.SetDataSource(ListClient(query));
                    break;

                case (Common.ReportType.ClientCorporate):
                    Reports.ListClientReport lcr3 = new Reports.ListClientReport();
                    crystalReportViewer1.ReportSource = lcr3;

                    lcr3.SetDataSource(ListClient(query));
                    break;

                case (Common.ReportType.TransactionPerClient):
                    break;
                case (Common.ReportType.PurchaseReportDaily):
                    break;
                case (Common.ReportType.PurchaseReportPeriod):
                    break;
                case (Common.ReportType.SaleReportDaily):
                    break;
                case (Common.ReportType.SaleReportPeriod):
                    break;
                case (Common.ReportType.WaccDaily):
                    Reports.WacReport wd = new Reports.WacReport();
                    crystalReportViewer1.ReportSource = wd;
                    wd.SetDataSource(GetWaccDaily(start, query));
                    break;
                case (Common.ReportType.WaccPeiod):
                    Reports.WacReport wp = new Reports.WacReport();
                    crystalReportViewer1.ReportSource = wp;
                    wp.SetDataSource(GetWaccPeriod(start,end, query));
                    break;
                case (Common.ReportType.TransactionReportDaily):
                    Reports.TransactionBuySellReport tr1 = new Reports.TransactionBuySellReport();
                    crystalReportViewer1.ReportSource = tr1;
                    tr1.SetDataSource(GetTransactionDaily(start, query));
                    break;

                case (Common.ReportType.TransactionReportPeriod):
                    Reports.TransactionBuySellReport tr = new Reports.TransactionBuySellReport();
                    crystalReportViewer1.ReportSource = tr;
                    tr.SetDataSource(GetTransactionRange(start, end, query));
                    break;

                case (Common.ReportType.ActualTransactionDaily):
                    Reports.ActualTransaction at1 = new Reports.ActualTransaction();
                    crystalReportViewer1.ReportSource = at1;
                    at1.SetDataSource(GetTransactionDaily(start, query));
                    break;

                case (Common.ReportType.ActualTransactionPeriod):
                    Reports.ActualTransaction at2 = new Reports.ActualTransaction();
                    crystalReportViewer1.ReportSource = at2;
                    at2.SetDataSource(GetTransactionRange(start, end, query));
                    break;

                case (Common.ReportType.AuditDaily):
                    Reports.AuditReport ar = new Reports.AuditReport();
                    crystalReportViewer1.ReportSource = ar;
                    ar.SetDataSource(GetAuditDaily(start,query));
                    break;
                case (Common.ReportType.AuditRange):
                     Reports.AuditReport ar2 = new Reports.AuditReport();
                    crystalReportViewer1.ReportSource = ar2;
                    ar2.SetDataSource(GetAuditRange(start,end,query));
                    break;

                case (Common.ReportType.AnnexOneDaily):
                    Reports.newAnnexOne an = new Reports.newAnnexOne();
                    crystalReportViewer1.ReportSource = an;
                    an.SetDataSource(GetAnnexOneDaily(start));

                    break;
                case (Common.ReportType.AnnexOneRange):
                    Reports.newAnnexOne an2 = new Reports.newAnnexOne();
                    crystalReportViewer1.ReportSource = an2;
                    an2.SetDataSource(GetAnnexOneRange(start, end));

                    break;

                default:
                    break;

            }
        }

        private List<Clients> BlackListedClient(string query)
        {

            con.Open();

            List<Clients> ListClients = new List<Clients>();

            cmd = new SqlCommand(query, con);
            var reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    DataTable myTable = new DataTable();
                    myTable.Load(reader);
                    foreach (DataRow row in myTable.Rows)
                    {
                        int Code;
                        if (!string.IsNullOrEmpty(row["code"].ToString()))
                            Code = Convert.ToInt32(row["code"].ToString());
                        else
                            Code = 0;

                        string Name = row["name"].ToString();
                        DateTime DateOfBirth = new DateTime();
                        if (!string.IsNullOrEmpty(row["dob"].ToString()))
                        {
                            DateOfBirth = Convert.ToDateTime(row["dob"]);
                        }

                        string PassportNo = Convert.ToString(row["passport_no"]);
                        string Address = Convert.ToString(row["address"]);
                        string Surname = Convert.ToString(row["surname"]);
                        string Phone = Convert.ToString(row["phone"]);
                        string ContactPerson = Convert.ToString(row["contact_person"]);
                        string CompanyName = Convert.ToString(row["company_name"]);

                        DateTime DateIncorporated = new DateTime();
                        if (!string.IsNullOrEmpty(row["date_incorporated"].ToString()))
                        {
                            DateIncorporated = Convert.ToDateTime(row["date_incorporated"]);
                        }

                        string Country = Convert.ToString(row["country"]);
                        string Nationality = Convert.ToString(row["nationality"]);
                        string Email = Convert.ToString(row["email"]);
                        string VAT = Convert.ToString(row["vat"]);
                        string BRN = Convert.ToString(row["brn"]);
                        string IdType = Convert.ToString(row["id_type"]);
                        string Occupation = Convert.ToString(row["occupation"]);
                        string Username = Convert.ToString(row["username"]);

                        bool IsBlackListed = false;
                        if (!string.IsNullOrEmpty(row["isblacklisted"].ToString()))
                        {
                            IsBlackListed = Convert.ToBoolean(row["isblacklisted"]);
                        }
                        string Type = Convert.ToString(row["type"]);
                        DateTime DateCreated = Convert.ToDateTime(row["date_client_created"]);


                        Clients clients = new Clients
                        {
                            Code = Code,
                            Name = Name,
                            DateOfBirth = DateOfBirth,
                            PassportNo = PassportNo,
                            Address = Address,
                            Surname = Surname,
                            Phone = Phone,
                            ContactPerson = ContactPerson,
                            CompanyName = CompanyName,
                            DateIncorporated = DateIncorporated,
                            Country = Country,
                            Nationality = Nationality,
                            Email = Email,
                            VAT = VAT,
                            BRN = BRN,
                            IdType = IdType,
                            Occupation = Occupation,
                            Username = Username,
                            IsBlackListed = IsBlackListed,
                            Type = Type,
                            DateCreated = DateCreated,
                        };

                        ListClients.Add(clients);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured while generating the report: " + ex.InnerException);
            }
            finally
            {
                con.Close();
            }

            return ListClients;
        }


        private List<Clients> ListClient(string query)
        {

            con.Open();

            List<Clients> ListClients = new List<Clients>();

            cmd = new SqlCommand(query, con);
            var reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    DataTable myTable = new DataTable();
                    myTable.Load(reader);
                    foreach (DataRow row in myTable.Rows)
                    {
                        int Code;
                        if (!string.IsNullOrEmpty(row["code"].ToString()))
                            Code = Convert.ToInt32(row["code"].ToString());
                        else
                            Code = 0;

                        string Name = row["name"].ToString();
                        DateTime DateOfBirth = new DateTime();
                        if (!string.IsNullOrEmpty(row["dob"].ToString()))
                        {
                            DateOfBirth = Convert.ToDateTime(row["dob"]);
                        }

                        string PassportNo = Convert.ToString(row["passport_no"]);
                        string Address = Convert.ToString(row["address"]);
                        string Surname = Convert.ToString(row["surname"]);
                        string Phone = Convert.ToString(row["phone"]);
                        string ContactPerson = Convert.ToString(row["contact_person"]);
                        string CompanyName = Convert.ToString(row["company_name"]);

                        DateTime DateIncorporated = new DateTime();
                        if (!string.IsNullOrEmpty(row["date_incorporated"].ToString()))
                        {
                            DateIncorporated = Convert.ToDateTime(row["date_incorporated"]);
                        }

                        string Country = Convert.ToString(row["country"]);
                        string Nationality = Convert.ToString(row["nationality"]);
                        string Email = Convert.ToString(row["email"]);
                        string VAT = Convert.ToString(row["vat"]);
                        string BRN = Convert.ToString(row["brn"]);
                        string IdType = Convert.ToString(row["id_type"]);
                        string Occupation = Convert.ToString(row["occupation"]);
                        string Username = Convert.ToString(row["username"]);

                        bool IsBlackListed = false;
                        if (!string.IsNullOrEmpty(row["isblacklisted"].ToString()))
                        {
                            IsBlackListed = Convert.ToBoolean(row["isblacklisted"]);
                        }
                        string Type = Convert.ToString(row["type"]);
                        DateTime DateCreated = Convert.ToDateTime(row["date_client_created"]);

                        int NoOfTransaction;
                        if (!string.IsNullOrEmpty(row["TotalTransaction"].ToString()))
                            NoOfTransaction = Convert.ToInt32(row["TotalTransaction"].ToString());
                        else
                            NoOfTransaction = 0;

                        Clients clients = new Clients
                        {
                            Code = Code,
                            Name = Name,
                            DateOfBirth = DateOfBirth,
                            PassportNo = PassportNo,
                            Address = Address,
                            Surname = Surname,
                            Phone = Phone,
                            ContactPerson = ContactPerson,
                            CompanyName = CompanyName,
                            DateIncorporated = DateIncorporated,
                            Country = Country,
                            Nationality = Nationality,
                            Email = Email,
                            VAT = VAT,
                            BRN = BRN,
                            IdType = IdType,
                            Occupation = Occupation,
                            Username = Username,
                            IsBlackListed = IsBlackListed,
                            Type = Type,
                            DateCreated = DateCreated,
                            NoOfTransaction = NoOfTransaction.ToString()
                        };

                        ListClients.Add(clients);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured while generating the report: " + ex.InnerException);
            }
            finally
            {
                con.Close();
            }

            return ListClients;
        }


        private List<AnnexOne> GetAnnexOneRange(DateTime start, DateTime end)
        {

            con.Open();

            List<AnnexOne> ListAnnexOne = new List<AnnexOne>();

            cmd = new SqlCommand("GetTransactionPeriod", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = start;
            cmd.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = end;

            var reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    DataTable myTable = new DataTable();
                    myTable.Load(reader);
                    foreach (DataRow row in myTable.Rows)
                    {
                        string symbol;
                        if (!string.IsNullOrEmpty(row["symbol"].ToString()))
                            symbol = (row["symbol"].ToString());
                        else
                            symbol = string.Empty;

                        string FirstCashIn;
                        if (!string.IsNullOrEmpty(row["FirstCashIn"].ToString()))
                        {
                            FirstCashIn = (row["FirstCashIn"]).ToString();
                        }
                        else
                        {
                            FirstCashIn = "0";
                        }

                        string ClientPurchaseTotal;
                        if (!string.IsNullOrEmpty(row["ClientPurchaseTotal"].ToString()))
                        {
                            ClientPurchaseTotal = (row["ClientPurchaseTotal"]).ToString();
                        }
                        else
                        {
                            ClientPurchaseTotal = "0";
                        }

                        string ClientSellTotal;
                        if (!string.IsNullOrEmpty(row["ClientSellTotal"].ToString()))
                        {
                            ClientSellTotal = (row["ClientSellTotal"]).ToString();
                        }
                        else
                        {
                            ClientSellTotal = "0";
                        }

                        string LastCashout;
                        if (!string.IsNullOrEmpty(row["LastCashout"].ToString()))
                        {
                            LastCashout = (row["LastCashout"]).ToString();
                        }
                        else
                        {
                            LastCashout = "0";
                        }

                        AnnexOne annex = new AnnexOne
                        {
                            Symbol = symbol,
                            OpeningBalanceAtBank = "0",
                            OpeningBalanceOnHand = FirstCashIn,
                            ClosingBalanceAtBank = "0",
                            ClosingBalanceOnHand = LastCashout,
                            TransactionBuyBank = "0",
                            TransactionSellBank = "0",
                            TransactionBuyCustomer = ClientPurchaseTotal,
                            TransactionSellCustomer = ClientSellTotal,
                            DateRange = start.ToString("ddd, MMM d, yyyy") + " - " + end.ToString("ddd, MMM d, yyyy")
                        };

                        ListAnnexOne.Add(annex);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured while generating the report: " + ex.InnerException);
            }
            finally
            {
                con.Close();
            }

            return ListAnnexOne;
        }

        private List<AuditClass> GetAuditRange(DateTime start, DateTime end, string op)
        {

            con.Open();

            List<AuditClass> ListAuditClass = new List<AuditClass>();

            cmd = new SqlCommand("GetAuditByRange", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Start", SqlDbType.DateTime).Value = start;
            cmd.Parameters.Add("@End", SqlDbType.DateTime).Value = end;
            cmd.Parameters.Add("@Operation", SqlDbType.VarChar).Value = op;

            var reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    DataTable myTable = new DataTable();
                    myTable.Load(reader);
                    foreach (DataRow row in myTable.Rows)
                    {
                        string operation;
                        if (!string.IsNullOrEmpty(row["operation"].ToString()))
                            operation = (row["operation"].ToString());
                        else
                            operation = string.Empty;

                        string description;
                        if (!string.IsNullOrEmpty(row["description"].ToString()))
                        {
                            description = (row["description"]).ToString();
                        }
                        else
                        {
                            description = "None";
                        }

                        string date_created;
                        if (!string.IsNullOrEmpty(row["date_created"].ToString()))
                        {
                            date_created = (row["date_created"]).ToString();
                        }
                        else
                        {
                            date_created = "";
                        }

                        string Username;
                        if (!string.IsNullOrEmpty(row["Username"].ToString()))
                        {
                            Username = (row["Username"]).ToString();
                        }
                        else
                        {
                            Username = "";
                        }


                        AuditClass audit = new AuditClass
                        {
                            AuditType = operation,
                            Description = description,
                            DateCreated = date_created,
                            ProcessedBy = Username,
                            DateRange = start.ToString("ddd, MMM d, yyyy") + " - " + end.ToString("ddd, MMM d, yyyy")
                        };

                        ListAuditClass.Add(audit);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured while generating the report: " + ex.InnerException);
            }
            finally
            {
                con.Close();
            }

            return ListAuditClass;
        }


        private List<TransactionData> GetTransactionRange(DateTime start, DateTime end, string type)
        {

            con.Open();

            List<TransactionData> ListTransac = new List<TransactionData>();

            if (type.Equals("Buy"))
            {
                cmd = new SqlCommand("GetTransactionBuyRange", con);
            }
            else if (type.Equals("Sell"))
            {
                cmd = new SqlCommand("GetTransactionSellRange", con);
            }
            else
            {
                cmd = new SqlCommand("GetActualTransactionRange", con);
                
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Start", SqlDbType.DateTime).Value = start;
            cmd.Parameters.Add("@End", SqlDbType.DateTime).Value = end;

            var reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    DataTable myTable = new DataTable();
                    myTable.Load(reader);
                    foreach (DataRow row in myTable.Rows)
                    {
                        string currency;
                        if (!string.IsNullOrEmpty(row["currency"].ToString()))
                            currency = (row["currency"].ToString());
                        else
                            currency = string.Empty;

                        string amount;
                        if (!string.IsNullOrEmpty(row["amount"].ToString()))
                            amount = (row["amount"].ToString());
                        else
                            amount = "0.00";

                        string rates;
                        if (!string.IsNullOrEmpty(row["rates"].ToString()))
                            rates = (row["rates"].ToString());
                        else
                            rates = "0.00";

                        string total;
                        if (!string.IsNullOrEmpty(row["total"].ToString()))
                            total = (row["total"].ToString());
                        else
                            total = "0.00";

                        string date_created;
                        if (!string.IsNullOrEmpty(row["date_created"].ToString()))
                            date_created = (row["date_created"].ToString());
                        else
                            date_created = string.Empty;

                        string TellerUsername;
                        if (!string.IsNullOrEmpty(row["TellerUsername"].ToString()))
                            TellerUsername = (row["TellerUsername"].ToString());
                        else
                            TellerUsername = string.Empty;

                        string receipt_id;
                        if (!string.IsNullOrEmpty(row["receipt_id"].ToString()))
                            receipt_id = (row["receipt_id"].ToString());
                        else
                            receipt_id = string.Empty;

                        string ClientName;
                        if (!string.IsNullOrEmpty(row["ClientName"].ToString()))
                            ClientName = (row["ClientName"].ToString());
                        else
                            ClientName = string.Empty;

                        string ClientType;
                        if (!string.IsNullOrEmpty(row["ClientType"].ToString()))
                            ClientType = (row["ClientType"].ToString());
                        else
                            ClientType = " - ";

                        string TransactionType;
                        if (!string.IsNullOrEmpty(row["TransactionType"].ToString()))
                            TransactionType = (row["TransactionType"].ToString());
                        else
                            TransactionType = " - ";
                        TransactionData data = new TransactionData
                        {
                            Currency = currency,
                            Amount = amount,
                            Rates = rates,
                            Total = total,
                            DateCreated = date_created,
                            TellerUsername = TellerUsername,
                            ReceiptId = receipt_id,
                            ClientName = ClientName,
                            ClientType = ClientType,
                            DateRange = start.ToString("ddd, MMM d, yyyy") + " - " + end.ToString("ddd, MMM d, yyyy"),
                            TransactionType = TransactionType
                        };

                        ListTransac.Add(data);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured while generating the report: " + ex.InnerException);
            }
            finally
            {
                con.Close();
            }

            return ListTransac;
        }


        private List<TransactionData> GetTransactionDaily(DateTime daily, string type)
        {

            con.Open();
            List<TransactionData> ListTransac = new List<TransactionData>();

            if (type.Equals("Buy"))
            {
                cmd = new SqlCommand("GetTransactionBuyDaily", con);
            }
            else if (type.Equals("Sell"))
            {
                cmd = new SqlCommand("GetTransactionSellDaily", con);
            }
            else
            {
                cmd = new SqlCommand("GetActualTransactionDaily", con);
                
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CurrenctDate", SqlDbType.DateTime).Value = daily;

            var reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    DataTable myTable = new DataTable();
                    myTable.Load(reader);
                    foreach (DataRow row in myTable.Rows)
                    {
                        string currency;
                        if (!string.IsNullOrEmpty(row["currency"].ToString()))
                            currency = (row["currency"].ToString());
                        else
                            currency = string.Empty;

                        string amount;
                        if (!string.IsNullOrEmpty(row["amount"].ToString()))
                            amount = (row["amount"].ToString());
                        else
                            amount = "0.00";

                        string rates;
                        if (!string.IsNullOrEmpty(row["rates"].ToString()))
                            rates = (row["rates"].ToString());
                        else
                            rates = "0.00";

                        string total;
                        if (!string.IsNullOrEmpty(row["total"].ToString()))
                            total = (row["total"].ToString());
                        else
                            total = "0.00";

                        string date_created;
                        if (!string.IsNullOrEmpty(row["date_created"].ToString()))
                            date_created = (row["date_created"].ToString());
                        else
                            date_created = string.Empty;

                        string TellerUsername;
                        if (!string.IsNullOrEmpty(row["TellerUsername"].ToString()))
                            TellerUsername = (row["TellerUsername"].ToString());
                        else
                            TellerUsername = string.Empty;

                        string receipt_id;
                        if (!string.IsNullOrEmpty(row["receipt_id"].ToString()))
                            receipt_id = (row["receipt_id"].ToString());
                        else
                            receipt_id = string.Empty;

                        string ClientName;
                        if (!string.IsNullOrEmpty(row["ClientName"].ToString()))
                            ClientName = (row["ClientName"].ToString());
                        else
                            ClientName = string.Empty;

                        string ClientType;
                        if (!string.IsNullOrEmpty(row["ClientType"].ToString()))
                            ClientType = (row["ClientType"].ToString());
                        else
                            ClientType = " - ";

                        string TransactionType;
                        if (!string.IsNullOrEmpty(row["TransactionType"].ToString()))
                            TransactionType = (row["TransactionType"].ToString());
                        else
                            TransactionType = " - ";

                        TransactionData data = new TransactionData
                        {
                            Currency = currency,
                            Amount = amount,
                            Rates = rates,
                            Total = total,
                            DateCreated = date_created,
                            TellerUsername = TellerUsername,
                            ReceiptId = receipt_id,
                            ClientName = ClientName,
                            ClientType = ClientType,
                            DateRange = daily.ToString("ddd, MMM d, yyyy"),
                            TransactionType = TransactionType

                        };

                        ListTransac.Add(data);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured while generating the report: " + ex.InnerException);
            }
            finally
            {
                con.Close();
            }

            return ListTransac;
        }

        private List<WACC> GetWaccDaily(DateTime daily, string symbol)
        {

            con.Open();
            List<WACC> ListWACC = new List<WACC>();


            cmd = new SqlCommand("GetWACCDaily", con);


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CurrenDate", SqlDbType.DateTime).Value = daily;
            cmd.Parameters.Add("@Symbol", SqlDbType.VarChar).Value = symbol;

            var reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    DataTable myTable = new DataTable();
                    myTable.Load(reader);
                    decimal balanceRemains = 0;
                    decimal WaccRate = 0;
                    decimal WaccTimesBalace = 0;

                    bool isFirstLoop = true;
                    foreach (DataRow row in myTable.Rows)
                    {
                        if (isFirstLoop)
                        {
                            decimal balance;
                            if (!string.IsNullOrEmpty(row["balance"].ToString()))
                                balance = Convert.ToDecimal((row["balance"].ToString()));
                            else
                                balance = 0;

                            balanceRemains = balance;

                            isFirstLoop = false;

                            decimal PurchaseMidrate;
                            if (!string.IsNullOrEmpty(row["PurchaseMidrate"].ToString()))
                                PurchaseMidrate = Convert.ToDecimal((row["PurchaseMidrate"].ToString()));
                            else
                                PurchaseMidrate = 0;

                            decimal SaleMidrate;
                            if (!string.IsNullOrEmpty(row["SaleMidrate"].ToString()))
                                SaleMidrate = Convert.ToDecimal((row["SaleMidrate"].ToString()));
                            else
                                SaleMidrate = 0;

                            WaccRate = (PurchaseMidrate + SaleMidrate) / 2;

                            WaccTimesBalace = WaccRate * balanceRemains;
                        }

                        string type;
                        if (!string.IsNullOrEmpty(row["type"].ToString()))
                            type = (row["type"].ToString());
                        else
                            type = string.Empty;

                        string rates;
                        if (!string.IsNullOrEmpty(row["rates"].ToString()))
                            rates = (row["rates"].ToString());
                        else
                            rates = string.Empty;

                        decimal amount;
                        if (!string.IsNullOrEmpty(row["amount"].ToString()))
                            amount = Convert.ToDecimal((row["amount"].ToString()));
                        else
                            amount = 0;

                        if (type == "Buy")
                        {
                            balanceRemains = balanceRemains + amount;
                        }
                        else
                        {
                            balanceRemains = balanceRemains - amount;
                        }

                        decimal total;
                        if (!string.IsNullOrEmpty(row["total"].ToString()))
                            total = Convert.ToDecimal((row["total"].ToString()));
                        else
                            total = 0;

                        string transacid;
                        if (!string.IsNullOrEmpty(row["transaction_id"].ToString()))
                            transacid = ((row["transaction_id"].ToString()));
                        else
                            transacid = "null";

                        if (type == "Buy")
                        {
                            WaccTimesBalace = WaccTimesBalace + total;
                        }
                        else
                        {
                            WaccTimesBalace = WaccTimesBalace - total;
                        }

                        var curWacc = WaccTimesBalace / balanceRemains;

                        string currency;
                        if (!string.IsNullOrEmpty(row["currency"].ToString()))
                            currency = (row["currency"].ToString());
                        else
                            currency = "0.00";


                        string date_created;
                        if (!string.IsNullOrEmpty(row["date_created"].ToString()))
                            date_created = (row["date_created"].ToString());
                        else
                            date_created = "null";

                        WACC wacc = new WACC
                        {
                            Voucher = transacid,
                            DateCreated = date_created,
                            Type = type,
                            Symbol = symbol,
                            Amount = amount.ToString(),
                            Rate = rates,
                            Total = total.ToString(),
                            Balance = balanceRemains.ToString(),
                            WaccRate = curWacc.ToString(),
                            DateRange = daily.ToString("ddd, MMM d, yyyy"),
                            WACCXBalance = WaccTimesBalace.ToString()

                        };

                        ListWACC.Add(wacc);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured while generating the report: " + ex.InnerException);
            }
            finally
            {
                con.Close();
            }

            return ListWACC;
        }

        private List<WACC> GetWaccPeriod(DateTime start,DateTime end, string symbol)
        {

            con.Open();
            List<WACC> ListWACC = new List<WACC>();


            cmd = new SqlCommand("GetWACCPeriod", con);


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = start;
            cmd.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = end;
            cmd.Parameters.Add("@Symbol", SqlDbType.VarChar).Value = symbol;

            var reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    DataTable myTable = new DataTable();
                    myTable.Load(reader);
                    decimal balanceRemains = 0;
                    decimal WaccRate = 0;
                    decimal WaccTimesBalace = 0;

                    bool isFirstLoop = true;
                    foreach (DataRow row in myTable.Rows)
                    {
                        if (isFirstLoop)
                        {
                            decimal balance;
                            if (!string.IsNullOrEmpty(row["balance"].ToString()))
                                balance = Convert.ToDecimal((row["balance"].ToString()));
                            else
                                balance = 0;

                            balanceRemains = balance;

                            isFirstLoop = false;

                            decimal PurchaseMidrate;
                            if (!string.IsNullOrEmpty(row["PurchaseMidrate"].ToString()))
                                PurchaseMidrate = Convert.ToDecimal((row["PurchaseMidrate"].ToString()));
                            else
                                PurchaseMidrate = 0;

                            decimal SaleMidrate;
                            if (!string.IsNullOrEmpty(row["SaleMidrate"].ToString()))
                                SaleMidrate = Convert.ToDecimal((row["SaleMidrate"].ToString()));
                            else
                                SaleMidrate = 0;

                            WaccRate = (PurchaseMidrate + SaleMidrate) / 2;

                            WaccTimesBalace = WaccRate * balanceRemains;
                        }

                        string type;
                        if (!string.IsNullOrEmpty(row["type"].ToString()))
                            type = (row["type"].ToString());
                        else
                            type = string.Empty;

                        string rates;
                        if (!string.IsNullOrEmpty(row["rates"].ToString()))
                            rates = (row["rates"].ToString());
                        else
                            rates = string.Empty;

                        decimal amount;
                        if (!string.IsNullOrEmpty(row["amount"].ToString()))
                            amount = Convert.ToDecimal((row["amount"].ToString()));
                        else
                            amount = 0;

                        if (type == "Buy")
                        {
                            balanceRemains = balanceRemains + amount;
                        }
                        else
                        {
                            balanceRemains = balanceRemains - amount;
                        }

                        decimal total;
                        if (!string.IsNullOrEmpty(row["total"].ToString()))
                            total = Convert.ToDecimal((row["total"].ToString()));
                        else
                            total = 0;

                        string transacid;
                        if (!string.IsNullOrEmpty(row["transaction_id"].ToString()))
                            transacid = ((row["transaction_id"].ToString()));
                        else
                            transacid = "null";

                        if (type == "Buy")
                        {
                            WaccTimesBalace = WaccTimesBalace + total;
                        }
                        else
                        {
                            WaccTimesBalace = WaccTimesBalace - total;
                        }

                        var curWacc = WaccTimesBalace / balanceRemains;

                        string currency;
                        if (!string.IsNullOrEmpty(row["currency"].ToString()))
                            currency = (row["currency"].ToString());
                        else
                            currency = "0.00";


                        string date_created;
                        if (!string.IsNullOrEmpty(row["date_created"].ToString()))
                            date_created = (row["date_created"].ToString());
                        else
                            date_created = "null";

                        WACC wacc = new WACC
                        {
                            Voucher = transacid,
                            DateCreated = date_created,
                            Type = type,
                            Symbol = symbol,
                            Amount = amount.ToString(),
                            Rate = rates,
                            Total = total.ToString(),
                            Balance = balanceRemains.ToString(),
                            WaccRate = curWacc.ToString(),
                            DateRange = start.ToString("ddd, MMM d, yyyy") + " - " + end.ToString("ddd, MMM d, yyyy"),
                            WACCXBalance = WaccTimesBalace.ToString()

                        };

                        ListWACC.Add(wacc);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured while generating the report: " + ex.InnerException);
            }
            finally
            {
                con.Close();
            }

            return ListWACC;
        }



        private List<AuditClass> GetAuditDaily(DateTime daily, string op)
        {

            con.Open();

            List<AuditClass> ListAuditClass = new List<AuditClass>();

            cmd = new SqlCommand("GetAuditDaily", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CurrenctDate", SqlDbType.DateTime).Value = daily;
            cmd.Parameters.Add("@Operation", SqlDbType.VarChar).Value = op;

            var reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    DataTable myTable = new DataTable();
                    myTable.Load(reader);
                    foreach (DataRow row in myTable.Rows)
                    {
                        string operation;
                        if (!string.IsNullOrEmpty(row["operation"].ToString()))
                            operation = (row["operation"].ToString());
                        else
                            operation = string.Empty;

                        string description;
                        if (!string.IsNullOrEmpty(row["description"].ToString()))
                        {
                            description = (row["description"]).ToString();
                        }
                        else
                        {
                            description = "None";
                        }

                        string date_created;
                        if (!string.IsNullOrEmpty(row["date_created"].ToString()))
                        {
                            date_created = (row["date_created"]).ToString();
                        }
                        else
                        {
                            date_created = "";
                        }

                        string Username;
                        if (!string.IsNullOrEmpty(row["Username"].ToString()))
                        {
                            Username = (row["Username"]).ToString();
                        }
                        else
                        {
                            Username = "";
                        }


                        AuditClass audit = new AuditClass
                        {
                            AuditType = operation,
                            Description = description,
                            DateCreated = date_created,
                            ProcessedBy = Username,
                            DateRange = daily.ToString("ddd, MMM d, yyyy") 
                        };

                        ListAuditClass.Add(audit);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured while generating the report: " + ex.InnerException);
            }
            finally
            {
                con.Close();
            }

            return ListAuditClass;
        }


        private List<AnnexOne> GetAnnexOneDaily(DateTime daily)
        {

            con.Open();

            List<AnnexOne> ListAnnexOne = new List<AnnexOne>();

            cmd = new SqlCommand("GetTransactionDaily", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CurrenctDate", SqlDbType.DateTime).Value = daily;

            var reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    DataTable myTable = new DataTable();
                    myTable.Load(reader);
                    foreach (DataRow row in myTable.Rows)
                    {
                        string symbol;
                        if (!string.IsNullOrEmpty(row["symbol"].ToString()))
                            symbol = (row["symbol"].ToString());
                        else
                            symbol = string.Empty;

                        string FirstCashIn;
                        if (!string.IsNullOrEmpty(row["FirstCashIn"].ToString()))
                        {
                            FirstCashIn = (row["FirstCashIn"]).ToString();
                        }
                        else
                        {
                            FirstCashIn = "0";
                        }

                        string ClientPurchaseTotal;
                        if (!string.IsNullOrEmpty(row["ClientPurchaseTotal"].ToString()))
                        {
                            ClientPurchaseTotal = (row["ClientPurchaseTotal"]).ToString();
                        }
                        else
                        {
                            ClientPurchaseTotal = "0";
                        }

                        string ClientSellTotal;
                        if (!string.IsNullOrEmpty(row["ClientSellTotal"].ToString()))
                        {
                            ClientSellTotal = (row["ClientSellTotal"]).ToString();
                        }
                        else
                        {
                            ClientSellTotal = "0";
                        }

                        string LastCashout;
                        if (!string.IsNullOrEmpty(row["LastCashout"].ToString()))
                        {
                            LastCashout = (row["LastCashout"]).ToString();
                        }
                        else
                        {
                            LastCashout = "0";
                        }

                        AnnexOne annex = new AnnexOne
                        {
                            Symbol = symbol,
                            OpeningBalanceAtBank = "0",
                            OpeningBalanceOnHand = FirstCashIn,
                            ClosingBalanceAtBank = "0",
                            ClosingBalanceOnHand = LastCashout,
                            TransactionBuyBank = "0",
                            TransactionSellBank = "0",
                            TransactionBuyCustomer = ClientPurchaseTotal,
                            TransactionSellCustomer = ClientSellTotal,
                            DateRange = daily.ToString("ddd, MMM d, yyyy")
                        };

                        ListAnnexOne.Add(annex);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured while generating the report: " + ex.InnerException);
            }
            finally
            {
                con.Close();
            }

            return ListAnnexOne;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

    }
}
