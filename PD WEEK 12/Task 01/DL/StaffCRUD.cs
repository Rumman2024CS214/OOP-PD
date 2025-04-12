using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01.DL
{
    internal class StaffCRUD
    {
        public static List<Staff> staff = new List<Staff>();

        public static void AddStaff(Staff st)
        {
            staff.Add(st);
        }

        public static Staff GetStaff(int choice)
        {
            return staff[choice - 1];
        }
    }
}
