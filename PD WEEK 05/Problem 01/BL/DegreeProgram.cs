using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01.BL
{
    internal class DegreeProgram
    {
        public string degreeName;
        public float degreeDuration;
        public List<Subject> subjects;
        public int seats;

        public DegreeProgram(string degreeName)
        {
            this.degreeName = degreeName;
        }
        public DegreeProgram(string degreeName, float degreeDuration, int seats)
        {
            this.degreeName = degreeName;
            this.degreeDuration = degreeDuration;
            this.seats = seats;
            subjects = new List<Subject>();
        }

        public int CalculateHours()
        {
            int count = 0;
            for (int x = 0; x < subjects.Count; x++)
            {
                count = count + subjects[x].credithours;
            }
            return count;
        }

        public bool isSubjectExist(Subject sub)
        {
            foreach(Subject s in subjects)
            {
                if(s.code == sub.code)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
