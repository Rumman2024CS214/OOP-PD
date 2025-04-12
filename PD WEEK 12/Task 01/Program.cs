using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_01.DL;
using Task_01.UI;

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                Console.Clear();
                UI.InterfaceUI.Header();
                option = UI.InterfaceUI.Menu();
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        UI.InterfaceUI.Header();
                        Student s = UI.StudentUI.TakeInput();
                        DL.StudentCRUD.AddStudent(s);
                        Console.WriteLine("Student Added Successfully...");
                        Console.WriteLine("Press Enter To Continue...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        UI.InterfaceUI.Header();
                        Staff st = UI.StaffUI.TakeInput();
                        DL.StaffCRUD.AddStaff(st);
                        Console.WriteLine("Staff Added Successfully...");
                        Console.WriteLine("Press Enter To Continue...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        UI.InterfaceUI.Header();
                        UI.StudentUI.ShowStudents();
                        Console.Write("Which One You Want To Update: ");
                        int choice = int.Parse(Console.ReadLine());
                        Student std = StudentCRUD.GetStudent(choice);
                        Console.Write("What You Want To Update: ");
                        string updation = Console.ReadLine();
                        if(updation.ToLower() == "fee")
                        {
                            Console.Write("Enter New Fee: ");
                            double fee = double.Parse(Console.ReadLine());
                            std.setFee(fee);
                        }
                        else if(updation.ToLower() == "year")
                        {
                            Console.Write("Enter New Year: ");
                            int year = int.Parse(Console.ReadLine());
                            std.setYear(year);
                        }
                        else if (updation.ToLower() == "program")
                        {
                            Console.Write("Enter New Program: ");
                            string program = Console.ReadLine();
                            std.setProgram(program);
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        UI.InterfaceUI.Header();
                        UI.StaffUI.ShowStaff();
                        Console.Write("Which One You Want To Update: ");
                        int choice1 = int.Parse(Console.ReadLine());
                        Staff stf = StaffCRUD.GetStaff(choice1);
                        Console.Write("What You Want To Update: ");
                        string updation1 = Console.ReadLine();
                        if (updation1.ToLower() == "pay")
                        {
                            Console.Write("Enter New Pay: ");
                            double pay = double.Parse(Console.ReadLine());
                            stf.setPay(pay);
                        }
                        else if (updation1.ToLower() == "school")
                        {
                            Console.Write("Enter New School: ");
                            string school = Console.ReadLine();
                            stf.setSchool(school);
                        }
                        Console.ReadKey();
                        break;
                }
            }
            while (option != 5);
        }
    }
}
