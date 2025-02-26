using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Problem_01.BL;

namespace Problem_01.UI
{
    internal class StudentUI
    {
        public static Student AddStudent(List<DegreeProgram> AvailableDegrees)
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Fsc Marks: ");
            double fscmarks = double.Parse(Console.ReadLine());
            Console.Write("Enter Ecat Marks: ");
            double ecatmarks = double.Parse(Console.ReadLine());
            Console.WriteLine("Available Degree Programs: ");
            foreach (DegreeProgram degreeProgram in AvailableDegrees)
            {
                if(degreeProgram.seats != 0)
                {
                    Console.WriteLine(degreeProgram.degreeName);
                }
            }
            List<DegreeProgram> preferences = new List<DegreeProgram>();
            Console.Write("Enter How Many Preferences To Enter: ");
            int pf = int.Parse(Console.ReadLine());
            for (int i = 0; i < pf; i++)
            {
                string degreeName = Console.ReadLine();
                bool flag = false;
                foreach(DegreeProgram dp in AvailableDegrees)
                {
                    if(degreeName == dp.degreeName && !(preferences.Contains(dp)))
                    {
                        preferences.Add(dp);
                        flag = true;
                    }
                }
                if(flag == false)
                {
                    Console.WriteLine("Degree Not Found");
                    i--;
                }
                
            }
            Student s = new Student(name, age, fscmarks, ecatmarks,preferences);
            return s;
        }

        public static void AddToPreferences(DegreeProgram dp,List<DegreeProgram> preferences)
        {
            preferences.Add(dp);
        }

        public static void GenerateMerit(List<Student> students)
        {
            foreach (Student student in students)
            {
                if (student.regdegree != null)
                {
                    Console.WriteLine(student.name + " got Admission in " + student.regdegree.degreeName);
                }
                else if(student.regdegree == null)
                {
                    Console.WriteLine(student.name + " did not get Admission");
                }
            }
        }


        public static void viewStudent(string degreeName,List<Student> students)
        {
            Console.WriteLine("Name\tFSC\tECAT\tAge");
            foreach(Student s in students)
            {
                if(s.regdegree != null)
                {
                    if(degreeName == s.regdegree.degreeName)
                    {
                        Console.WriteLine(s.name + "\t" + s.fscmarks + "\t" + s.ecatmarks + "\t" + s.age);
                    }
                }
            }
        }

        public static void viewRegisteredStudents(List<Student> students)
        {
            Console.WriteLine("Name\tFSC\tECAT\tAge");
            foreach(Student s in students)
            {
                if(s.regdegree != null)
                {
                    Console.WriteLine(s.name + "\t" + s.fscmarks + "\t" + s.ecatmarks + "\t" + s.age);
                }
            }
        }


        
    }
}
