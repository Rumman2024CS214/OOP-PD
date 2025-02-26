using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_01.BL;

namespace Problem_01.UI
{
    internal class DegreeProgramUI
    {

        public static DegreeProgram AddProgram()
        {
            Console.Write("Enter Degree Name: ");
            string degreeName = Console.ReadLine();
            Console.Write("Enter Degree Duration: ");
            float degreeDuration = float.Parse(Console.ReadLine());
            Console.Write("Enter Seats For Degree: ");
            int seats = int.Parse(Console.ReadLine());
            DegreeProgram dp = new DegreeProgram(degreeName, degreeDuration, seats);
            Console.Write("Enter How Many Subjects To Enter: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++) 
            {
                Subject s = SubjectUI.AddSubject();
                DL.DegreeProgramCRUD.AddSubjectToList(s, dp);
            }
            return dp;
        }
    }
}
