using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem___2.BL
{
    internal class AbsoluteGradedCourse : Course
    {
        public override bool IsPassed()
        {
            if (Grade != "F")
            {
                Console.WriteLine("Absolute Graded Course Passed!");
                return true;
            }
            else
            {

                Console.WriteLine("Absolute Graded Course Failed!");
                return false;
            }
        }
    }
}
