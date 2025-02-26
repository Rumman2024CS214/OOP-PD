using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02.BL
{
    internal class Admin
    {
        public string username;
        public string password;
        public string email;
        public string address;
        public string phone;
        public string role;

        public Admin(string username, string password, string email, string address, string phone, string role)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.address = address;
            this.phone = phone;
            this.role = role;
        }

        public Admin(string username, string password)
        {
            this.username = username;
            this.password = password;
        }


        public bool IsAdmin()
        {
            if (role == "Admin" || role.ToLower() == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
