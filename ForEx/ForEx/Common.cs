using System;
using System.Collections.Generic;
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
            Regex objPhonePattern = new Regex(@"^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$");
            return objPhonePattern.IsMatch(strPhone);
        }


    }


}
