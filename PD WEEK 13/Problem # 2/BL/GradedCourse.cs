using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem___2.BL
{
    internal class GradedCourse : Course
    {

        public override bool IsPassed()
        {
            if (grade >= 2)
            {
                Console.WriteLine("Graded Course Passed!");
                return true;
            }
            else
            {

                Console.WriteLine("Graded Course Failed!");
                return false;
            }
        }
    }
}
