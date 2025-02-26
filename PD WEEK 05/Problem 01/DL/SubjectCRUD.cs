using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_01.BL;
using Problem_01.UI;

namespace Problem_01.DL
{
    internal class SubjectCRUD
    {
        public static void RegisterSubjects(Student s)
        {
            Console.Write("How Many Subjects You Want To Register For: ");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                Console.Write("Enter Subject Code: ");
                string code = Console.ReadLine();
                bool flag = false;
                foreach (Subject sub in s.regdegree.subjects)
                {
                    if (code == sub.code && !(s.regsubjects.Contains(sub)))
                    {
                        s.regStudentSubject(sub);
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Subject Not Found...");
                    x--;
                }
            }
        }
    }
}
