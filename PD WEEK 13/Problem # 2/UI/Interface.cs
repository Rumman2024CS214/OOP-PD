using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem___2.UI
{
    internal class Interface
    {
        public static void PrintPassed3()
        {
            Console.WriteLine("Project Passed");
        }

        public static int Menu()
        {
            int option = 0;
            Console.WriteLine("1.Create Project");
            Console.WriteLine("2.Show Projects");
            Console.WriteLine("3.Exit");
            Console.Write("Enter Option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        public static void Header()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("**                             **");
            Console.WriteLine("**  PROJECT MANAGEMENT SYSTEM  **");
            Console.WriteLine("**                             **");
            Console.WriteLine("*********************************");
        }
    }
}
