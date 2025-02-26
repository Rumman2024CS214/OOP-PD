using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_01.BL;

namespace Problem_01.UI
{
    internal class SubjectUI
    {
        public static Subject AddSubject()
        {
            Console.Write("Enter Subject Code: ");
            string code = Console.ReadLine();
            Console.Write("Enter Subject Type: ");
            string type = Console.ReadLine();
            Console.Write("Enter Subject Credit Hours: ");
            int credithours = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject Fees: ");
            int subjectfee = int.Parse(Console.ReadLine());
            Subject s = new Subject(code,credithours,type,subjectfee);
            return s;
        }

        public static void viewSubjects(Student s)
        {
            if(s.regdegree != null)
            {
                Console.WriteLine("Subject Code\tSubject Type");
                foreach(Subject sub in s.regdegree.subjects)
                {
                    Console.WriteLine(sub.code + "\t\t" + sub.type);
                }
            }

        }
    }
}
