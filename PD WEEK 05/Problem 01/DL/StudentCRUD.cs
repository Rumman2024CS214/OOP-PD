using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_01.BL;

namespace Problem_01.DL
{
    internal class StudentCRUD
    {
        public static List<Student> students = new List<Student>();

        public static void AddStudentToList(Student s,List<Student> students)
        {
            students.Add(s);
        }

        public static List<Student> sortStudents(List<Student> students)
        {
            List<Student> sorted = new List<Student>();
            foreach (Student s in students)
            {
                BL.Student.CalculateMerit(s);
            }
            sorted = students.OrderByDescending(o => o.merit).ToList();
            return sorted;
        }

        public static void giveAdmission(List<Student> sortedStudents)
        {
            foreach (Student s in sortedStudents)
            {
                foreach(DegreeProgram dp in s.preferences)
                {
                    if (dp.seats > 0)
                    {
                        s.regdegree = dp;
                        dp.seats--;
                        break;
                    }
                }
            }
        }
    }
}
