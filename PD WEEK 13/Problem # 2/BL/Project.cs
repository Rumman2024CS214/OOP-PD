using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem___2.BL
{
    internal class Project
    {
        public List<Course> courses = new List<Course>();
        public void IsPassed()
        {
            int total = 0;
            foreach (Course c in courses)
            {
                if(c.IsPassed())
                {
                    total++;
                }
            }
            if (total >= 3)
            {
                UI.Interface.PrintPassed3();
            }
            else
            {
                Console.WriteLine("Project Failed");
            }
        }
    }
}
