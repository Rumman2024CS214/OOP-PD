using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_02.BL;

namespace Problem_02.DL
{
    internal class AdminCRUD
    {
        public static List<Admin> admins = new List<Admin> ();


        public static void StoreinList(Admin a, List<Admin> admins)
        {
            admins.Add (a);
        }

        static public Admin Signin(Admin a, List<Admin> admins)
        {
            foreach (Admin admin in admins)
            {
                if (admin.username == a.username && admin.password == a.password)
                {
                    return admin;
                }
            }
            return null;
        }

        static public void Storeinfile(string path, Admin a)
        {
            StreamWriter newfile = new StreamWriter(path, true);
            newfile.WriteLine(a.username + "," + a.password + "," + a.email + "," + a.address + "," + a.phone + "," + a.role);
            newfile.Flush();
            newfile.Close();
        }


        static public bool Reading(string path, List<Admin> admins)
        {
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                string cred;
                while ((cred = sr.ReadLine()) != null)
                {
                    string username = Commacheck(cred, 1);
                    string password = Commacheck(cred, 2);
                    string email = Commacheck(cred, 3);
                    string address = Commacheck(cred, 4);
                    string phone = Commacheck (cred, 5);
                    string role = Commacheck(cred, 6);
                    Admin a = new Admin(username, password,email,address,phone,role);
                    StoreinList(a, DL.AdminCRUD.admins);
                }
                sr.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        static public string Commacheck(string line, int field)
        {
            int comma = 1;
            string rec = "";
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    rec = rec + line[i];
                }
            }
            return rec;
        }
    }
}
