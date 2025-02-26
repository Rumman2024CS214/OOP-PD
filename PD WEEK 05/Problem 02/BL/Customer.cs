using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02.BL
{
    internal class Customer
    {
        public string username;
        public string password;
        public string email;
        public string address;
        public string phone;
        public string role;
        public List<Product> cart = new List<Product>();

        public Customer(string username, string password,string email,string address,string phone,string role)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.address = address;
            this.phone = phone;
            this.role = role;
        }

        public Customer(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public bool IsCustomer()
        {
            if (role == "Customer" || role.ToLower() == "customer")
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
