using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_02.BL;

namespace Problem_02.UI
{
    internal class ProductUI
    {
        public static Product AddProduct()
        {
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Product Category: ");
            string category = Console.ReadLine();
            Console.Write("Enter Product Price: ");
            float price = float.Parse(Console.ReadLine());
            Console.Write("Enter Product Quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter Product's Threshold: ");
            int threshold = int.Parse(Console.ReadLine());
            if(name != null && category != null && price != 0F && quantity != 0 && threshold != 0)
            {
                Product p = new Product(name, category, price,quantity,threshold);
                return p;
            }
            return null;
        }

        static public void Seeallproducts(List<Product> products, int x, int y)
        {
            int n = 1;
            Console.WriteLine("    Product Name\t\tProduct's Category\t\tProduct's Price\t\tRemaining Stock");
            foreach (Product p in products)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(n + "." + p.name);
                Console.SetCursorPosition(x + 30, y);
                Console.WriteLine(p.category);
                Console.SetCursorPosition(x + 62, y);
                Console.WriteLine(p.price);
                Console.SetCursorPosition(x + 88, y);
                Console.WriteLine(p.quantity);
                y = y + 3;
                n++;
            }
        }

        static public void SeeMaxPriceProduct(List<Product> products, int x, int y)
        {
            int n = 1;
            float max = 0.0F;
            Product p1 = null;
            Console.WriteLine("    Product Name\t\tProduct's Category\t\tProduct's Price\t\tRemaining Stock");
            foreach (Product p in products)
            {

                if(p.price > max)
                {
                    max = p.price;
                    p1 = p;
                }
            }
            Console.SetCursorPosition(x, y);
            Console.WriteLine(n + "." + p1.name);
            Console.SetCursorPosition(x + 30, y);
            Console.WriteLine(p1.category);
            Console.SetCursorPosition(x + 62, y);
            Console.WriteLine(p1.price);
            Console.SetCursorPosition(x + 88, y);
            Console.WriteLine(p1.quantity);
            y = y + 3;
            n++;
        }


        static public void SeeTaxes(List<Product> products, int x, int y)
        {
            float tax;
            int n = 1;
            Console.WriteLine("    Product Name\t\tProduct's Category\t\tProduct's Price\t\tSales Tax");
            foreach (Product p in products)
            {
                tax = DL.ProductCRUD.TaxCalculation(p);
                Console.SetCursorPosition(x, y);
                Console.WriteLine(n + "." + p.name);
                Console.SetCursorPosition(x + 30, y);
                Console.WriteLine(p.category);
                Console.SetCursorPosition(x + 62, y);
                Console.WriteLine(p.price);
                Console.SetCursorPosition(x + 88, y);
                Console.WriteLine(tax);
                y = y + 3;
                n++;
            }
        }

        public static void SeeProductsToOrder(List<Product> products, int x, int y)
        {
            int n = 1;
            Console.WriteLine("    Product Name\t\tProduct's Category\t\tProduct's Price\t\tRemaining Stock");
            foreach (Product p in products)
            {
                if(p.quantity < p.threshold)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine(n + "." + p.name);
                    Console.SetCursorPosition(x + 30, y);
                    Console.WriteLine(p.category);
                    Console.SetCursorPosition(x + 62, y);
                    Console.WriteLine(p.price);
                    Console.SetCursorPosition(x + 88, y);
                    Console.WriteLine(p.quantity);
                    y = y + 3;
                    n++;
                }   
            }
        }

        public static void SeeCartBill(Customer c, int x, int y)
        {
            float sum=0;
            float tax;
            int n = 1;
            Console.WriteLine("    Product Name\t\tProduct's Category\t\tProduct's Price\t\tSales Tax\t\tQuantity Bought       Total Price");
            foreach (Product p in c.cart)
            {
                tax = DL.ProductCRUD.TaxCalculation(p);
                Console.SetCursorPosition(x, y);
                Console.WriteLine(n + "." + p.name);
                Console.SetCursorPosition(x + 30, y);
                Console.WriteLine(p.category);
                Console.SetCursorPosition(x + 62, y);
                Console.WriteLine(p.price);
                Console.SetCursorPosition(x + 88, y);
                Console.WriteLine(tax);
                Console.SetCursorPosition(x + 115, y);
                Console.WriteLine(p.quantity);
                Console.SetCursorPosition(x + 136, y);
                Console.WriteLine((p.price*p.quantity)+tax);
                sum += (p.price * p.quantity) + tax;
                y = y + 3;
                n++;
            }
            Console.SetCursorPosition(x + 130, y + 2);
            Console.WriteLine("Total Invoice: "+sum);
        }

    }
}
