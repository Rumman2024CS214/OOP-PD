using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01.UI
{
    internal class InterfaceUI
    {
        public static int Menu()
        {
            try
            {
                int option;
                Console.WriteLine("---School Management System---");
                Console.WriteLine("1.Add Student");
                Console.WriteLine("2.Add Staff");
                Console.WriteLine("3.Update Students");
                Console.WriteLine("4.Update Staff");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Enter Option: ");
                option = int.Parse(Console.ReadLine());
                return option;
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Invalid Entry...");
                return 0;
            }
        }

        public static void Header()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("|                                       |");
            Console.WriteLine("|       School Management System        |");
            Console.WriteLine("|                                       |");
            Console.WriteLine("-----------------------------------------");
        }
    }
}
