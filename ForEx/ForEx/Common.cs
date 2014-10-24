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
            Transaction
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


    }


}
