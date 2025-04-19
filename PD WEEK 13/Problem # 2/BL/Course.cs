using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem___2.BL
{
    internal class Course
    {
        protected string CourseName;
        protected decimal Marks;
        protected string Grade;
        protected int grade;

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

        public int Getgrade()
        {
            return grade;
        }


        public void SetCourse(string course)
        {
            this.CourseName = course;
        }

        public bool SetMarks(decimal marks)
        {
            if(marks >= 0 && marks <= 100)
            {
                this.Marks = marks;
                return false;
            }
            else
            {
                return true;
            }
        }

        public void SetGrade(decimal marks)
        {
            if (marks >= 90)
            {
                this.Grade = "A+";
            }
            else if (marks >= 80 && marks < 90)
            {
                this.Grade = "A";
            }
            else if (marks >= 70 && marks < 80)
            {
                this.Grade = "B";
            }
            else if (marks >= 60 && marks < 70)
            {
                this.Grade = "C";
            }
            else if (marks >= 50 && marks < 60)
            {
                this.Grade = "D";
            }
            else if (marks < 50)
            {
                this.Grade = "F";
            }
        }

        public void Setgrade(decimal marks)
        {
            if (marks >= 90)
            {
                this.grade = 12;
            }
            else if (marks >= 80 && marks < 90)
            {
                this.grade = 10;
            }
            else if (marks >= 70 && marks < 80)
            {
                this.grade = 7;
            }
            else if (marks >= 60 && marks < 70)
            {
                this.grade = 4;
            }
            else if (marks >= 50 && marks < 60)
            {
                this.grade = 2;
            }
            else if (marks >= 40 && marks < 50)
            {
                this.grade = 0;
            }
            else if(marks<40)
            {
                this.grade = -3;
            }
        }

        public virtual bool IsPassed()
        {
            if (grade >= 2 || Grade != "F")
            {
                Console.WriteLine("Course Passed!");
                return true;
            }
            else
            {
                Console.WriteLine("Course Failed!");
                return false;
            }
        }
    }
}
