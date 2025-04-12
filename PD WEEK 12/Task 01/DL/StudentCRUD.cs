using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01.DL
{
    internal class StudentCRUD
    {
        public static List<Student> students = new List<Student>();

        public static void AddStudent(Student student)
        {
            students.Add(student);
        }

        public static Student GetStudent(int choice)
        {
            return students[choice-1];
        }
    }
}
