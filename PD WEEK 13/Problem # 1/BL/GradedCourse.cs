using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem___1.BL
{
    internal class GradedCourse
    {
        private string CourseName;
        private int Grade;

        public GradedCourse()
        {

        }

        public string GetCourse()
        {
            return CourseName;
        }

        public int GetGrade()
        {
            return Grade;
        }

        public void SetCourse(string course)
        {
            this.CourseName = course;
        }

        public void SetGrade(int grade)
        {
            this.Grade = grade;
        }

        public bool IsPassed()
        {
            if (Grade != -3)
            {
                UI.Interface.PrintPassed1();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
