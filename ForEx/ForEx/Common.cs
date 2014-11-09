using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Configuration;
using ForEx.Classes;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;


namespace ForEx
{
    public class Common
    {
        private static bool invalid;
        public static UserLoggedIn user = null;

        public enum Operation
        {
            LoggedIn,
            LoggedOut,
            CashIn,
            CashOut,
            Transaction,
            RateUpdate,
            All
        }

        public enum ReportType
        {
            BlacklistedIndividuals,
            BlacklistedBank,
            BlacklistedCorporate,
            TransactionPerClient,
            PurchaseReportDaily,
            PurchaseReportPeriod,
            SaleReportDaily,
            SaleReportPeriod,
            ActualTransactionDaily,
            ActualTransactionPeriod,
            TransactionReportDaily,
            TransactionReportPeriod,
            AuditDaily,
            AuditRange,
            AnnexOneRange,
            AnnexOneDaily,
            WaccDaily,
            WaccPeiod,
            ClientIndividuals,
            ClientBank,
            ClientCorporate
        }

        public static string OperationToList(Operation report)
        {
            switch (report)
            {
                case (Operation.LoggedIn):
                    return "Logged In";
                    break;

                case (Operation.LoggedOut):
                    return "Logged Out";

                    break;

                case (Operation.CashIn):
                    return "Cash In";

                    break;

                case (Operation.CashOut):
                    return "Cash Out";

                    break;


                case (Operation.Transaction):
                    return "Transaction";

                    break;

                case (Operation.RateUpdate):
                    return "Rate Update";

                    break;

                default:
                    return "All";

                    break;
            }
        }

        public static Operation OperationToEnum(String report)
        {
            switch (report)
            {
                case ("Logged In"):
                    return Operation.LoggedIn;
                    break;

                case ("Logged Out"):
                    return Operation.LoggedOut;

                    break;

                case ("Cash In"):
                    return Operation.CashIn;

                    break;

                case ("Cash Out"):
                    return Operation.CashOut;

                    break;


                case ("Transaction"):
                    return Operation.Transaction;

                    break;

                case ("Rate Update"):
                    return Operation.RateUpdate;

                    break;

                default:
                    return Operation.All;

                    break;
            }
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        public static void SetUser(int UserId, String Name, String Surname, String Role, String Username)
        {
            user = new UserLoggedIn(UserId, Name, Surname, Role, Username);
        }

        public static UserLoggedIn GetUser()
        {
            return user;
        }

        public static void UnsetUser()
        {
            user = null;
        }

        public static string GetConnectionString()
        {
            var connection = System.Configuration.ConfigurationManager.ConnectionStrings["ForEx"];
            return connection.ConnectionString;
        }

        public static countries GetCountries()
        {
            countries Countries = null;
            var xml = Resource.CountriesRes.Countries;

            XmlSerializer serializer = new XmlSerializer(typeof(countries));

            StringReader reader = new StringReader(xml);
            Countries = (countries)serializer.Deserialize(reader);
            reader.Close();

            return Countries;
        }

        public static bool IsValidEmail(string strIn)
        {
            invalid = false;
            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names. 
            try
            {
                strIn = Regex.Replace(strIn, @"(@)(.+)$", Common.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format. 
            try
            {
                return Regex.IsMatch(strIn,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private static string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }

        public static bool IsPhone(String strPhone)
        {
            int num;
            return int.TryParse(strPhone, out num);
        }

        public static void Audit(Enum operation, string description)
        {
            SqlConnection con = new SqlConnection(Common.GetConnectionString());
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd = new SqlCommand("INSERT INTO tbl_audit (operation, description, date_created,user_id) VALUES (@operation, @description, @date_created,@user_id)");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            try
            {

            
            cmd.Parameters.Add("@operation", SqlDbType.VarChar).Value = operation.ToString();
            cmd.Parameters.Add("@description", SqlDbType.NChar).Value = description;
            cmd.Parameters.Add("@date_created", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = GetUser().UserId;

            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();

            if (!(row > 0))
            {
                throw new Exception("An error has occured while trying to audit");
            }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception while auditing: " + ex.InnerException);
            }
        }

        public static List<Currency> getAllCurrency()
        {
            string connection = Common.GetConnectionString();

            List<Currency> currencyList = new List<Currency>();

            SqlConnection conn = new SqlConnection(connection);

            try
            {
                const string sql = "SELECT * FROM [dbo].[tbl_currency]";

                conn.Open();
                var cmd = new SqlCommand(sql, conn);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var bo = new Currency
                        {
                            symbol = Convert.ToString(dr["symbol"]),
                            name = Convert.ToString(dr["name"]),
                            id = Convert.ToInt32(dr["currency_id"])

                        };
                        currencyList.Add(bo);
                    }

                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.Message);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return currencyList;
        }

        public static List<Rate> getRateforToday()
        {
            string connection = Common.GetConnectionString();

            List<Rate> rateList = new List<Rate>();

            SqlConnection conn = new SqlConnection(connection);

            try
            {

                const string sql = "SELECT *  FROM tbl_currency LEFT JOIN [ForExDB].[dbo].[tbl_rate] " +
                                   "INNER JOIN ( select max([date_updated])  " +
                                   "as MaxDate from [ForExDB].[dbo].[tbl_rate]) tm" +
                                   " on [ForExDB].[dbo].[tbl_rate].[date_updated] = tm.MaxDate ON " +
                                   "CurrencyId =  tbl_currency.currency_id ";

                conn.Open();
                var cmd = new SqlCommand(sql, conn);
    
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var CurrencyId = Convert.ToInt32(dr["CurrencyId"]);
                        var Symbol = Convert.ToString(dr["Symbol"]);
                        var PurchaseMin = Convert.ToDecimal(dr["PurchaseMin"]);
                        var PurchaseMax = Convert.ToDecimal(dr["PurchaseMax"]);
                        var PurchaseRate = Convert.ToDecimal(dr["PurchaseRate"]);
                        var PurchaseMidrate = Convert.ToDecimal(dr["PurchaseMidrate"]);
                        var SaleMin = Convert.ToDecimal(dr["SaleMin"]);
                        var SaleMax = Convert.ToDecimal(dr["SaleMax"]);
                        var SaleRate = Convert.ToDecimal(dr["SaleRate"]);
                        var SaleMidrate = Convert.ToDecimal(dr["SaleMidrate"]);
                        var BankPurchase = Convert.ToDecimal(dr["BankPurchase"]);
                        var BankSale = Convert.ToDecimal(dr["BankSale"]);

                        rateList.Add(new Rate(CurrencyId, Symbol, PurchaseMin, PurchaseMax,
                        PurchaseRate, PurchaseMidrate, SaleMin,
                        SaleMax, SaleRate, SaleMidrate, BankPurchase, BankSale));
                    }

                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.Message);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return rateList;
        }

        public static List<Rate> getDashBoardRates()
        {
            string connection = Common.GetConnectionString();

            List<Rate> rateList = new List<Rate>();

            SqlConnection conn = new SqlConnection(connection);

            try
            {



                conn.Open();
                var cmd = new SqlCommand("GetDashboardRate", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    
                    while (dr.Read())
                    {
                        string symbol = Convert.ToString(dr["symbol"]);

                        if (!symbol.Contains("MUR"))
                        {
                            decimal PurchaseRate;
                            if (string.IsNullOrEmpty(dr["PurchaseRate"].ToString()))
                            {
                                PurchaseRate = 0;
                            }
                            else
                            {
                                PurchaseRate = Convert.ToDecimal(dr["PurchaseRate"]);
                            }

                            decimal SaleRate;
                            if (string.IsNullOrEmpty(dr["SaleRate"].ToString()))
                            {
                                SaleRate = 0;
                            }
                            else
                            {
                                SaleRate = Convert.ToDecimal(dr["SaleRate"]);
                            }

                            decimal Stock;
                            if (string.IsNullOrEmpty(dr["balance"].ToString()))
                            {
                                Stock = 0;
                            }
                            else
                            {
                                Stock = Convert.ToDecimal(dr["balance"]);
                            }

                            DateTime RateDate = Convert.ToDateTime(dr["RateDate"]);
                            


                            var CurrencyId = Convert.ToInt32(dr["currencyid"]);
                            var Symbol = symbol;
                            var PurchaseMin = 0;
                            var PurchaseMax = 0;
                            var PurchaseMidrate = 0;
                            var SaleMin = 0;
                            var SaleMax = 0;
                            var SaleMidrate = 0;
                            var BankPurchase = 0;
                            var BankSale = 0;

                            rateList.Add(new Rate(RateDate,Stock, CurrencyId, Symbol, PurchaseMin, PurchaseMax,
                                PurchaseRate, PurchaseMidrate, SaleMin,
                                SaleMax, SaleRate, SaleMidrate, BankPurchase, BankSale));
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.Message);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return rateList;
        }

        public static int getCurrencyId(string name)
        {
            string connection = Common.GetConnectionString();
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            string query = " SELECT [currency_id] FROM [ForExDB].[dbo].[tbl_currency] where [symbol] = @symbol";
            var cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@symbol", SqlDbType.VarChar).Value = name;
            int currencyid = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            return currencyid;
        }

        public static Balance getLatestBalanceForToday(string symbol)
        {
            string connection = Common.GetConnectionString();

            Balance balance = new Balance();

            SqlConnection conn = new SqlConnection(connection);

            try
            {
                const string sql = "select X.[currencyid], [tbl_transacid], [name], [symbol]," +
                                   " [date_inserted], [balance] from    (select [tbl_transacid]    " +
                                   "  ,[currencyid]     ,[date_inserted]      ,[balance],   " +
                                   "   dense_rank() over (partition by [currencyid] order by [date_inserted] desc) rank " +
                                   " from [tbl_transactemp]) X INNER JOIN " +
                                   " [tbl_currency] ON [tbl_currency].[currency_id] = X.[currencyid] " +
                                   "  where rank = 1 AND [dbo].[tbl_currency].[symbol] = @symbol";

                conn.Open();
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@symbol", SqlDbType.VarChar).Value = symbol;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var bo = new Balance
                        {
                            symbol = Convert.ToString(dr["symbol"]),
                            balance = Convert.ToDecimal(dr["balance"]),
                            id = Convert.ToInt32(dr["tbl_transacid"]),
                            currencyName = Convert.ToString(dr["name"]),
                            currencyId = Convert.ToInt32(dr["currencyid"]),
                            //date = Convert.ToDateTime("date_inserted") // todo - error with this
                        };
                        balance = bo;
                    }                    
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.Message);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return balance;
        }

    }


}
