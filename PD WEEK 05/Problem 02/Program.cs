using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EZInput;
using Problem_02.BL;

namespace Problem_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2, y = 13;
            string type;
            string path = "F:\\STUDY\\2nd Semester\\Programming Days\\PD WEEK 05\\Problem 02\\admincredits.txt";
            string path1 = "F:\\STUDY\\2nd Semester\\Programming Days\\PD WEEK 05\\Problem 02\\customercredits.txt";
            string path2 = "F:\\STUDY\\2nd Semester\\Programming Days\\PD WEEK 05\\Problem 02\\products.txt";
            int option,aoption,coption;
            bool checkProducts = DL.ProductCRUD.Reading(path2, DL.ProductCRUD.products);
            do
            {
                Console.Clear();
                UI.ConsoleUtility.Header();
                Console.WriteLine("Are You a Customer or Admin: ");
                type = Console.ReadLine();
                if (type == "admin")
                {
                    bool check = DL.AdminCRUD.Reading(path, DL.AdminCRUD.admins);
                    if (check)
                    {
                        Console.WriteLine("Data Loaded Successfully...");
                        Thread.Sleep(50);
                    }
                    do
                    {
                        Console.Clear();
                        UI.ConsoleUtility.Header();
                        option = UI.ConsoleUtility.Menu();
                        Console.Clear();
                        if (option == 1)
                        {
                            Console.Clear();
                            UI.ConsoleUtility.Header();
                            UI.ConsoleUtility.Signupheader();
                            Admin a = UI.AdminUI.Input2();
                            if (a != null)
                            {
                                DL.AdminCRUD.StoreinList(a, DL.AdminCRUD.admins);
                                DL.AdminCRUD.Storeinfile(path, a);
                            }
                        }
                        else if (option == 2)
                        {
                            Console.Clear();
                            UI.ConsoleUtility.Header();
                            UI.ConsoleUtility.Signinheader();
                            Admin a = UI.AdminUI.Input1();
                            if (a != null)
                            {
                                a = DL.AdminCRUD.Signin(a, DL.AdminCRUD.admins);
                                if (a == null)
                                {
                                    Console.WriteLine("Invalid User...");
                                }
                                else if (a.IsAdmin())
                                {
                                    do
                                    {
                                        Console.Clear();
                                        UI.ConsoleUtility.Header();
                                        aoption = UI.AdminUI.AdminMenu();
                                        switch (aoption)
                                        {
                                            case 1:
                                                Console.Clear();
                                                UI.ConsoleUtility.Header();
                                                Product p = UI.ProductUI.AddProduct();
                                                DL.ProductCRUD.StoreinList(p, DL.ProductCRUD.products);
                                                DL.ProductCRUD.StoreinFile(path2, p, DL.ProductCRUD.products);
                                                Console.ReadKey();
                                                break;
                                            case 2:
                                                Console.Clear();
                                                UI.ConsoleUtility.Header();
                                                UI.ProductUI.Seeallproducts(DL.ProductCRUD.products, x, y);
                                                Console.ReadKey();
                                                break;
                                            case 3:
                                                Console.Clear();
                                                UI.ConsoleUtility.Header();
                                                UI.ProductUI.SeeMaxPriceProduct(DL.ProductCRUD.products, x, y);
                                                Console.ReadKey();
                                                break;
                                            case 4:
                                                Console.Clear();
                                                UI.ConsoleUtility.Header();
                                                UI.ProductUI.SeeTaxes(DL.ProductCRUD.products, x, y);
                                                Console.ReadKey();
                                                break;
                                            case 5:
                                                Console.Clear();
                                                UI.ConsoleUtility.Header();
                                                UI.ProductUI.SeeProductsToOrder(DL.ProductCRUD.products, x, y);
                                                Console.ReadKey();
                                                break;
                                            case 6:
                                                Console.Clear();
                                                UI.ConsoleUtility.Header();
                                                UI.AdminUI.SeeProfile(a);
                                                Console.ReadKey();
                                                break;
                                        }
                                    }
                                    while (aoption != 7);
                                }
                            }
                        }
                    }
                    while (option != 3);
                }
                else if (type == "customer")
                {
                    bool check1 = DL.CustomerCRUD.Reading(path1, DL.CustomerCRUD.customers);
                    if (check1)
                    {
                        Console.WriteLine("Data Loaded Successfully...");
                        Thread.Sleep(50);
                    }
                    do
                    {
                        Console.Clear();
                        UI.ConsoleUtility.Header();
                        option = UI.ConsoleUtility.Menu();
                        Console.Clear();
                        if (option == 1)
                        {
                            UI.ConsoleUtility.Header();
                            UI.ConsoleUtility.Signupheader();
                            Customer c = UI.CustomerUI.Input2();
                            if (c != null)
                            {
                                DL.CustomerCRUD.StoreinList(c, DL.CustomerCRUD.customers);
                                DL.CustomerCRUD.Storeinfile(path1, c);
                            }
                        }
                        else if (option == 2)
                        {
                            UI.ConsoleUtility.Header();
                            UI.ConsoleUtility.Signinheader();
                            Customer c = UI.CustomerUI.Input1();
                            if (c != null)
                            {
                                c = DL.CustomerCRUD.Signin(c, DL.CustomerCRUD.customers);
                                if (c == null)
                                {
                                    Console.WriteLine("Invalid User...");
                                }
                                else if (c.IsCustomer())
                                {
                                    do
                                    {
                                        Console.Clear();
                                        UI.ConsoleUtility.Header();
                                        coption = UI.CustomerUI.CustomerMenu();
                                        switch (coption)
                                        {
                                            case 1:
                                                Console.Clear();
                                                UI.ConsoleUtility.Header();
                                                UI.ProductUI.Seeallproducts(DL.ProductCRUD.products, x, y);
                                                Console.ReadKey();
                                                break;
                                            case 2:
                                                Console.Clear();
                                                UI.ConsoleUtility.Header();
                                                UI.ProductUI.Seeallproducts(DL.ProductCRUD.products, x, y);
                                                Console.Write("Which Product You Want To Buy: ");
                                                int index = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Enter Quantity: ");
                                                int q = int.Parse(Console.ReadLine());
                                                Product p1 = DL.CustomerCRUD.BuyProduct(index,q, DL.ProductCRUD.products);
                                                DL.CustomerCRUD.AddtoCart(p1,c);
                                                
                                                Console.ReadKey();
                                                break;
                                            case 3:
                                                Console.Clear();
                                                UI.ConsoleUtility.Header();
                                                UI.ProductUI.SeeCartBill(c, x, y);
                                                Console.ReadKey();
                                                break;
                                            case 4:
                                                Console.Clear();
                                                UI.ConsoleUtility.Header();
                                                UI.CustomerUI.SeeProfile(c);
                                                Console.ReadKey();
                                                break;
                                        }
                                    }
                                    while (coption != 5);
                                }
                            }
                        }
                    }
                    while (option != 3);
                }
                else if(type == "exit" || type == "Exit")
                {
                    break;
                }
            }
            while (type != "exit" || type != "Exit");
        }
    }
}
