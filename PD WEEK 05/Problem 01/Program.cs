using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_01.BL;

namespace Problem_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                Console.Clear();
                UI.ConsoleUtility.Header();
                option = UI.ConsoleUtility.Menu();
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        UI.ConsoleUtility.Header();
                        Student s = UI.StudentUI.AddStudent(DL.DegreeProgramCRUD.AvailableDegrees);
                        DL.StudentCRUD.AddStudentToList(s, DL.StudentCRUD.students);
                        Console.WriteLine("Press Any Key To Continue....");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        UI.ConsoleUtility.Header();
                        DegreeProgram dp = UI.DegreeProgramUI.AddProgram();
                        DL.DegreeProgramCRUD.AddDegreeProgram(dp, DL.DegreeProgramCRUD.AvailableDegrees);
                        Console.WriteLine("Press Any Key To Continue....");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        UI.ConsoleUtility.Header();
                        List<Student> sortedStudents = new List<Student>();
                        sortedStudents = DL.StudentCRUD.sortStudents(DL.StudentCRUD.students);
                        DL.StudentCRUD.giveAdmission(sortedStudents);
                        UI.StudentUI.GenerateMerit(DL.StudentCRUD.students);
                        Console.WriteLine("Press Any Key To Continue....");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        UI.ConsoleUtility.Header();
                        UI.StudentUI.viewRegisteredStudents(DL.StudentCRUD.students);
                        Console.WriteLine("Press Any Key To Continue....");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        UI.ConsoleUtility.Header();
                        Console.Write("Enter Degree Name: ");
                        string degreeName = Console.ReadLine();
                        UI.StudentUI.viewStudent(degreeName, DL.StudentCRUD.students);
                        Console.WriteLine("Press Any Key To Continue....");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        UI.ConsoleUtility.Header();
                        Console.Write("Enter Student Name: ");
                        string name = Console.ReadLine();
                        Student s1 = Student.StudentPresent(name, DL.StudentCRUD.students);
                        if(s1!=null)
                        {
                            UI.SubjectUI.viewSubjects(s1);
                            DL.SubjectCRUD.RegisterSubjects(s1);
                        }
                        Console.WriteLine("Press Any Key To Continue....");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        UI.ConsoleUtility.Header();
                        Student.CalculateFeeForAll(DL.StudentCRUD.students);
                        Console.WriteLine("Press Any Key To Continue....");
                        Console.ReadKey();
                        break;
                }
            }
            while(option != 8);
        }
    }
}
