using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem___2.BL;

namespace Problem___2.UI
{
    internal class ProjectUI
    {
        public static AbsoluteGradedCourse TakeInput1()
        {
            Console.WriteLine("----ABSOLUTE GRADED COURSE----");
            AbsoluteGradedCourse course = new AbsoluteGradedCourse();
            Console.WriteLine("Enter Course Name: ");
            string courseName = Console.ReadLine();
            course.SetCourse(courseName);
            Console.WriteLine("Enter Marks Out Of 100: ");
            int marks = int.Parse(Console.ReadLine());
            bool check = course.SetMarks(marks);
            if (check)
            {
                Console.WriteLine("Invalid Marks");
                while (check != false)
                {
                    Console.WriteLine("Enter Marks Out Of 100: ");
                    marks = int.Parse(Console.ReadLine());
                    check = course.SetMarks(marks);
                    if (check)
                    {
                        Console.WriteLine("Invalid Marks");
                    }
                }
            }
            course.SetGrade(marks);
            return course;
        }

        public static GradedCourse TakeInput2()
        {
            Console.WriteLine("----GRADED COURSE----");
            GradedCourse course = new GradedCourse();
            Console.WriteLine("Enter Course Name: ");
            string courseName = Console.ReadLine();
            course.SetCourse(courseName);
            Console.WriteLine("Enter Marks Out Of 100: ");
            int marks = int.Parse(Console.ReadLine());
            bool check = course.SetMarks(marks);
            if (check)
            {
                Console.WriteLine("Invalid Marks");
                while (check != false)
                {
                    Console.WriteLine("Enter Marks Out Of 100: ");
                    marks = int.Parse(Console.ReadLine());
                    check = course.SetMarks(marks);
                    if (check)
                    {
                        Console.WriteLine("Invalid Marks");
                    }
                }
            }
            course.SetMarks(marks);
            course.Setgrade(marks);
            return course;
        }

        public static void ShowProjects(List<Project> projects)
        {
            int x = 1;
            foreach(Project p in projects)
            {
                Console.WriteLine("Project Number " + x + " : ");
                p.IsPassed();
                x++;
            }
        }
    }
}
