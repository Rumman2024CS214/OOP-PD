using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_02.BL;

namespace Task_02.UI
{
    internal class Interface
    {
        public static int GameMenu()
        {
            int option;
            Console.WriteLine("1.Play Game");
            Console.WriteLine("2.Exit");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        public static void Header()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("|                      |");
            Console.WriteLine("|       CARD GAME      |");
            Console.WriteLine("|                      |");
            Console.WriteLine("------------------------");
        }


        public static int GamePredict(Card card1)
        {
            int option=0;
            Console.WriteLine("***********************************");
            Console.WriteLine(card1.toString());
            Console.WriteLine(" ");
            Console.WriteLine("********* Remaining Cards ***********");
            Console.WriteLine("Press 1 if next card is  higher");
            Console.WriteLine("Press 2 if next card is lower");
            option = int.Parse(Console.ReadLine());
            return option; 
        }

        public static void GameOver(Card card,int score)
        {
            Console.WriteLine("Sorry You Lose! Press Key To Continue");
            Console.WriteLine("The Card was: " + card.toString());
            Console.WriteLine("Your Score is: " + score);
        }

        public static void GameWinner()
        {
            Console.WriteLine("Congrats you have scored maximum");
        }
    }
}
