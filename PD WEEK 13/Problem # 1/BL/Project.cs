using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem___1.BL
{
    internal class Project
    {
        List<AbsoluteGradedCourse> category1 = new List<AbsoluteGradedCourse>();
        List<GradedCourse> category2 = new List<GradedCourse>();

        public void AddtoList(AbsoluteGradedCourse agc,GradedCourse gc)
        {
            category1.Add(agc);
            category2.Add(gc);
        }

        public void IsPassed()
        {
            int count1=0;
            int count2=0;
            int total=0;
            foreach(AbsoluteGradedCourse c in category1)
            {
                if(c.IsPassed())
                {
                    count1++;
                }
            }
            foreach(GradedCourse gc in category2)
            {
                if(gc.IsPassed())
                {
                    count2++;
                }
            }
            total = count1 + count2;
            if(total >= 3)
            {
                UI.Interface.PrintPassed3();
            }
        }
    }
}
