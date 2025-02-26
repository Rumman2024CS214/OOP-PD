using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_02.BL;

namespace Problem_02.DL
{
    internal class CustomerCRUD
    {
        public static List<Customer> customers = new List<Customer>();


        public static void StoreinList(Customer c, List<Customer> customers)
        {
            customers.Add(c);
        }

        static public Customer Signin(Customer c, List<Customer> customers)
        {
            foreach (Customer storedUser in customers)
            {
                if (c.username == storedUser.username && c.password == storedUser.password)
                {
                    return storedUser;
                }
            }
            return null;
        }

        static public bool Reading(string path1, List<Customer> customers)
        {
            if (File.Exists(path1))
            {
                StreamReader sr = new StreamReader(path1);
                string cred;
                while ((cred = sr.ReadLine()) != null)
                {
                    string username = Commacheck(cred, 1);
                    string password = Commacheck(cred, 2);
                    string email = Commacheck(cred, 3);
                    string address = Commacheck(cred, 4);
                    string phone = Commacheck(cred, 5);
                    string role = Commacheck(cred, 6);
                    Customer c = new Customer(username, password, email, address, phone, role);
                    StoreinList(c, DL.CustomerCRUD.customers);
                }
                sr.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        static public string Commacheck(string line, int field)
        {
            int comma = 1;
            string rec = "";
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    rec = rec + line[i];
                }
            }
            return rec;
        }


        static public void Storeinfile(string path1, Customer c)
        {
            StreamWriter newfile = new StreamWriter(path1, true);
            newfile.WriteLine(c.username + "," + c.password + "," + c.email + "," + c.address + "," + c.phone + "," + c.role);
            newfile.Flush();
            newfile.Close();
        }


        public static Product BuyProduct(int index,int q,List<Product> products)
        {
            if(q <= products[index-1].quantity)
            {
                string name = products[index - 1].name;
                string category = products[index - 1].category;
                float price = products[index - 1].price;
                products[index - 1].quantity = products[index-1].quantity - q;
                Product p = new Product(name, category,price,q);
                Console.WriteLine("Product Bought Successfully...");
                return p;
            }
            else
            {
                Console.WriteLine("Not Enough Quantity in Store....");
                return null;
            }
        }

        public static void AddtoCart(Product p,Customer c)
        {
            c.cart.Add(p);
        }
    }
}
