using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01.BL
{
    internal class Student
    {
        public string name;
        public int age;
        public double fscmarks;
        public double ecatmarks;
        public double merit;
        public List<DegreeProgram> preferences;
        public List<Subject> regsubjects;
        public DegreeProgram regdegree;


        public Student(string name, int age, double fscmarks, double ecatmarks,List<DegreeProgram> preferences)
        {
            this.name = name;
            this.age = age;
            this.fscmarks = fscmarks;
            this.ecatmarks = ecatmarks;
            this.preferences = preferences;
            regsubjects = new List<Subject> ();
        }

        public static void CalculateMerit(Student s)
        {
            s.merit = (((s.fscmarks / 1100) * 0.45F) + ((s.ecatmarks / 400) * 0.55F)) * 100;
        }

        public static Student StudentPresent(string name,List<Student> students)
        {
            foreach(Student student in students)
            {
                if(name == student.name && student.regdegree != null)
                {
                    return student;
                }
            }
            return null;
        }

        public bool regStudentSubject(Subject s)
        {
            int stch = getCreditHours();
            if (regdegree != null && regdegree.isSubjectExist(s) && stch + s.credithours <= 9)
            {
                regsubjects.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getCreditHours()
        {
            int count = 0;
            foreach(Subject s in regsubjects)
            {
                count = count + s.credithours;
            }
            return count;
        }


        public float CalculateFee()
        {
            float fee = 0;
            if(regdegree != null)
            {
                foreach(Subject s in regsubjects)
                {
                    fee = fee + s.subjectfee;
                }
            }
            return fee;
        }

        public static void CalculateFeeForAll(List<Student> students)
        {
            foreach(Student s in students)
            {
                if(s.regdegree != null)
                {
                    Console.WriteLine(s.name + " has " + s.CalculateFee() + " fees");
                }
            }
        }
    }
}
