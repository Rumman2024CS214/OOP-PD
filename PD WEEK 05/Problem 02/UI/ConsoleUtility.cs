using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02.UI
{
    internal class ConsoleUtility
    {

        static public void Signupheader()
        {
            Console.WriteLine("                                                             ---------------------------------------------------");
            Console.WriteLine("                                                             |                     Sign Up                     |");
            Console.WriteLine("                                                             ---------------------------------------------------");
        }

        static public void Signinheader()
        {
            Console.WriteLine("                                                             ---------------------------------------------------");
            Console.WriteLine("                                                             |                     Sign IN                     |");
            Console.WriteLine("                                                             ---------------------------------------------------");
        }

        static public int Menu()
        {
            int option;
            Console.WriteLine("1.SignUp");
            Console.WriteLine("2.SignIn");
            Console.WriteLine("3.Exit");
            Console.Write("Enter Option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }


        static public void Header()
        {
            Console.WriteLine("##############################################################################################################");
            Console.WriteLine("###                                                                                                        ###");
            Console.WriteLine("###        #########    ##      ##    #######   #######   #######   ########   #######   ##      ##        ###");
            Console.WriteLine("###       ###           ##      ##   ##     ##  ##    ##  ##    ##     ##      ##         ##    ##         ###");
            Console.WriteLine("###       ###           ##      ##   ##     ##  ##    ##  ##    ##     ##      ##          ##  ##          ###");
            Console.WriteLine("###        ########     ##########   ##     ##  #######   #######      ##      #####        ####           ###");
            Console.WriteLine("###              ###    ##      ##   ##     ##  ##        ##           ##      ##            ##            ###");
            Console.WriteLine("###              ###    ##      ##   ##     ##  ##        ##           ##      ##            ##            ###");
            Console.WriteLine("###        ########     ##      ##    ######    ##        ##        ########   ##            ##            ###");
            Console.WriteLine("###                                                                                                        ###");
            Console.WriteLine("##############################################################################################################");
        }
    }
}
