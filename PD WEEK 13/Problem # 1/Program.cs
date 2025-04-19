using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem___1.BL;

namespace Problem___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbsoluteGradedCourse c1 = new AbsoluteGradedCourse();
            c1.SetCourse("Software Engineering");
            c1.SetMarks(85);
            c1.SetGrade("A");
            AbsoluteGradedCourse c2 = new AbsoluteGradedCourse();
            c2.SetCourse("Database Management");
            c2.SetMarks(75);
            c2.SetGrade("B");
            GradedCourse c3 = new GradedCourse();
            c3.SetCourse("Programming Fundamentals");
            c3.SetGrade(10);
            GradedCourse c4 =  new GradedCourse();
            c4.SetCourse("Algorithms and Data Structures");
            c4.SetGrade(7);
            Project p1 = new Project();
            p1.AddtoList(c1, c3);
            p1.AddtoList(c2, c4);
            p1.IsPassed();


            AbsoluteGradedCourse c5 = new AbsoluteGradedCourse();
            c5.SetCourse("Research Methods");
            c5.SetMarks(70);
            c5.SetGrade("B");
            AbsoluteGradedCourse c6 = new AbsoluteGradedCourse();
            c6.SetCourse("Literature Review");
            c6.SetMarks(80);
            c6.SetGrade("A");
            GradedCourse c7 = new GradedCourse();
            c7.SetCourse("Statistical Analysis");
            c7.SetGrade(12);
            GradedCourse c8 = new GradedCourse();
            c8.SetCourse("Research Findings Presentation");
            c8.SetGrade(10);
            Project p2 = new Project();
            p2.AddtoList(c5, c7);
            p2.AddtoList(c6, c8);
            p2.IsPassed();
        }
    }
}
