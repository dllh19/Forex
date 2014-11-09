using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ForEx.Classes
{
    public class Clients
    {
        public int Code { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PassportNo { get; set; }

        public string Address { get; set; }

        public string Surname { get; set; }

        public string Phone { get; set; }

        public string ContactPerson { get; set; }

        public string CompanyName { get; set; }

        public DateTime DateIncorporated { get; set; }

        public string Country { get; set; }

        public string Nationality { get; set; }

        public string Email { get; set; }

        public string VAT { get; set; }

        public string BRN { get; set; }

        public string IdType { get; set; }

        public string Occupation { get; set; }

        public string Username { get; set; }

        public bool IsBlackListed { get; set; }

        public string Type { get; set; }

        public DateTime DateCreated { get; set; }
        public string NoOfTransaction { get; set; }

        public Clients()
        {
            
        }
    }
}
