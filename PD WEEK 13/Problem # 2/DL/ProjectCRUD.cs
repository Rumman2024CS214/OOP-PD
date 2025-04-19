using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem___2.BL;

namespace Problem___2.DL
{
    internal class ProjectCRUD
    {
        public static List<Project> projects = new List<Project>();

        public static void AddProject(Project project)
        {
            projects.Add(project);
        }
        
        
    }
}
