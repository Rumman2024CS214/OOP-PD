using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_01.BL;

namespace Problem_01.DL
{
    internal class DegreeProgramCRUD
    {
        public static List<DegreeProgram> AvailableDegrees = new List<DegreeProgram>();

        public static void AddDegreeProgram(DegreeProgram dp,List<DegreeProgram> AvailableDegrees)
        {
            AvailableDegrees.Add(dp);
        }
        public static void AddSubjectToList(Subject s,DegreeProgram dp)
        { 
            dp.subjects.Add(s);
        }

        public static bool IsDegreeExist(DegreeProgram dp,List<DegreeProgram> AvailableDegrees)
        {
            bool flag = false;
            foreach(DegreeProgram degreeProgram in AvailableDegrees)
            {
                if(dp.degreeName == degreeProgram.degreeName && degreeProgram.seats > 0)
                {
                    flag = true;
                }
            }
            return flag;
        }

    }
}
