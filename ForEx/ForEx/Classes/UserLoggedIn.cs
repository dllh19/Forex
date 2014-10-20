using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEx.Classes
{
    public class UserLoggedIn
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Username { get; set; }

        public string Role { get; set; }

        public UserLoggedIn()
        {
        }

        public UserLoggedIn(int UserId, String Name, String Surname, String Role, String Username)
        {
            this.UserId = UserId;
            this.Name = Name;
            this.Surname = Surname;
            this.Role = Role;
            this.Username = Username;
        }
    }
}
