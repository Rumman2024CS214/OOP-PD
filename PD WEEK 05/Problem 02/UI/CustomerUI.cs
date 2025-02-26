using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Problem_02.BL;

namespace Problem_02.UI
{
    internal class CustomerUI
    {
        static public Customer Input1()
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            if (username != null && password != null)
            {
                Customer c = new Customer(username, password);
                return c;
            }
            return null;
        }

        static public Customer Input2()
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            string phone = Console.ReadLine();
            Console.Write("Enter Your Role: ");
            string role = Console.ReadLine();
            if (username != null && password != null && email != null && address != null && phone != null && role != null)
            {
                Customer c = new Customer(username, password, email, address, phone, role);
                return c;
            }
            return null;
        }

        static public int CustomerMenu()
        {
            Console.WriteLine("1.View all the products");
            Console.WriteLine("2.Buy the products");
            Console.WriteLine("3.Generate invoice");
            Console.WriteLine("4.View Profile");
            Console.WriteLine("5.Exit");
            Console.Write("Enter Your Choice: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        public static void SeeProfile(Customer c)
        {
            Console.WriteLine("Username: " + c.username);
            Console.WriteLine("Password: " + c.password);
            Console.WriteLine("Email: " + c.email);
            Console.WriteLine("Address: " + c.address);
            Console.WriteLine("Phone: " + c.phone);
        }
    }
}
