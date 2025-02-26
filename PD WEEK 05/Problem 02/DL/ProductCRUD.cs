using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_02.BL;

namespace Problem_02.DL
{
    internal class ProductCRUD
    {
        public static List<Product> products = new List<Product>();


        public static void StoreinList(Product p, List<Product> products)
        {
            products.Add(p);
        }


        public static float TaxCalculation(Product p)
        {
            float tax = 0;
            if(p.category == "fruit" || p.category == "Fruit")
            {
                tax = p.price * 5 / 100;
            }
            else if(p.category == "grocery" || p.category == "Grocery")
            {
                tax = p.price * 10 / 100;
            }    
            else
            {
                tax = p.price * 15 / 100;
            }
            return tax;
        }


        public static void StoreinFile(string path2,Product p,List<Product> products)
        {
            StreamWriter newfile = new StreamWriter(path2, true);
            newfile.WriteLine(p.name + "," + p.category + "," + p.price + "," + p.quantity + "," + p.threshold);
            newfile.Flush();
            newfile.Close();
        }

        static public bool Reading(string path2, List<Product> products)
        {
            if (File.Exists(path2))
            {
                StreamReader sr = new StreamReader(path2);
                string cred;
                while ((cred = sr.ReadLine()) != null)
                {
                    string name = Commacheck(cred, 1);
                    string category = Commacheck(cred, 2);
                    float price = float.Parse(Commacheck(cred, 3));
                    int quantity = int.Parse(Commacheck(cred, 4));
                    int threshold = int.Parse(Commacheck(cred, 5));
                    Product p = new Product(name,category,price,quantity,threshold);
                    StoreinList(p, DL.ProductCRUD.products);
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
    }
}
