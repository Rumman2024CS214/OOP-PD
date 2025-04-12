using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01.UI
{
    internal class StaffUI
    {
        public static Staff TakeInput()
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter School: ");
            string school = Console.ReadLine();
            Console.WriteLine("Enter Pay: ");
            double pay = double.Parse(Console.ReadLine());
            Staff s = new Staff(name, address, school,pay);
            return s;
        }

        public static void ShowStaff()
        {
            foreach (Staff s in DL.StaffCRUD.staff)
            {
                string output = s.toString();
                Console.WriteLine(output);
                Console.WriteLine("\n");
            }
        }
    }
}
