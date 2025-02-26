using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Problem_02.BL;

namespace Problem_02.UI
{
    internal class AdminUI
    {
        static public Admin Input1()
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            if (username != null && password != null)
            {
                Admin a = new Admin(username, password);
                return a;
            }
            return null;
        }

        static public Admin Input2()
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
                Admin a = new Admin(username, password, email, address, phone, role);
                return a;
            }
            return null;
        }

        static public int AdminMenu()
        {

            Console.WriteLine("1.Add Product.");
            Console.WriteLine("2.View All Products.");
            Console.WriteLine("3.Find Product with Highest Unit Price.");
            Console.WriteLine("4.View Sales Tax of All Products.");
            Console.WriteLine("5.Products to be Ordered.");
            Console.WriteLine("6.View Profile.");
            Console.WriteLine("7.Exit.");
            Console.Write("Enter Your Choice: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        public static void SeeProfile(Admin a)
        {
            Console.WriteLine("Username: " + a.username);
            Console.WriteLine("Password: " + a.password);
            Console.WriteLine("Email: " + a.email);
            Console.WriteLine("Address: " + a.address);
            Console.WriteLine("Phone: " + a.phone);
        }
    }
}
