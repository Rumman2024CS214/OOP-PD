using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem___2.BL;

namespace Problem___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                Console.Clear();
                UI.Interface.Header();
                option = UI.Interface.Menu();
                switch(option)
                {
                    case 1:
                        Console.Clear();
                        UI.Interface.Header();
                        AbsoluteGradedCourse course1 = UI.ProjectUI.TakeInput1();
                        AbsoluteGradedCourse course2 = UI.ProjectUI.TakeInput1();
                        GradedCourse course3 = UI.ProjectUI.TakeInput2();
                        GradedCourse course4 = UI.ProjectUI.TakeInput2();
                        Project p1 = new Project();
                        p1.courses.Add(course1);
                        p1.courses.Add(course2);
                        p1.courses.Add(course3);
                        p1.courses.Add(course4);
                        DL.ProjectCRUD.AddProject(p1);
                        Console.WriteLine("Project Created Successfully..");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        UI.Interface.Header();
                        UI.ProjectUI.ShowProjects(DL.ProjectCRUD.projects);
                        Console.ReadKey();
                        break;
                }
            }
            while (option != 3);
            
        }
    }
}
