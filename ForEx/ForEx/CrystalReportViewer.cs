using System;
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
                    Reports.BlackListedClients cr = new Reports.BlackListedClients();
                    crystalReportViewer1.ReportSource = cr;

                    cr.SetDataSource(BlackListedClient(query));
                    break;
                case (Common.ReportType.BlacklistedBank):
                    break;
                case (Common.ReportType.BlacklistedCorporate):
                    break;
                case (Common.ReportType.ListCorporateClients):
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
                case (Common.ReportType.TransactionReportDaily):
                    break;
                case (Common.ReportType.TransactionReportPeriod):
                    Reports.Annex1 an = new Reports.Annex1();
                    crystalReportViewer1.ReportSource = an;
                    an.SetDataSource(GetTransactionWeekly(start, end));

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

        private List<AnnexOne> GetTransactionWeekly(DateTime start, DateTime end)
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

                        decimal FirstCashIn;
                        if (!string.IsNullOrEmpty(row["FirstCashIn"].ToString()))
                        {
                            FirstCashIn = Convert.ToDecimal(row["FirstCashIn"]);
                        }
                        else
                        {
                            FirstCashIn = 0;
                        }

                        decimal ClientPurchaseTotal;
                        if (!string.IsNullOrEmpty(row["ClientPurchaseTotal"].ToString()))
                        {
                            ClientPurchaseTotal = Convert.ToDecimal(row["ClientPurchaseTotal"]);
                        }
                        else
                        {
                            ClientPurchaseTotal = 0;
                        }

                        decimal LastCashout;
                        if (!string.IsNullOrEmpty(row["LastCashout"].ToString()))
                        {
                            LastCashout = Convert.ToDecimal(row["LastCashout"]);
                        }
                        else
                        {
                            LastCashout = 0;
                        }

                        AnnexOne annex = new AnnexOne
                        {
    
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

    }
}
