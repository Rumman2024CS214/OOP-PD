using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem___1.BL
{
    internal class AbsoluteGradedCourse
    {
        private string CourseName;
        private decimal Marks;
        private string Grade;

        public AbsoluteGradedCourse()
        {

        }
        
        public string GetCourse()
        {
            return CourseName;
        }

        public decimal GetMarks() 
        {
            return Marks; 
        }

        public string GetGrade()
        {
            return Grade;
        }

        public void SetCourse(string course)
        {
            this.CourseName = course;
        }

        public void SetMarks(decimal marks)
        {
            this.Marks = marks;
        }

        public void SetGrade(string grade)
        {
            this.Grade = grade;
        }
        public bool IsPassed()
        {
            if(Marks > 49)
            {
                UI.Interface.PrintPassed2();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
