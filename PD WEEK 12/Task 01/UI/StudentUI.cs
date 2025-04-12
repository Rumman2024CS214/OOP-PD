using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task_01.UI
{
    internal class StudentUI
    {
        public static Student TakeInput()
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Program: ");
            string program = Console.ReadLine();
            Console.WriteLine("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fee: ");
            double fee = double.Parse(Console.ReadLine());
            Student s = new Student(name, address, program, year, fee);
            return s;
        }

        public static void ShowStudents()
        {
            foreach(Student s in DL.StudentCRUD.students)
            {
                string output = s.toString();
                Console.WriteLine(output);
                Console.WriteLine("\n");
            }
        }
    }
}
