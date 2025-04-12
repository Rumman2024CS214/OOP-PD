using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_03.BL;

namespace Task_03.UI
{
    internal class Interface
    {
        public static int GameMenu()
        {
            int option;
            Console.WriteLine("1.Play Game");
            Console.WriteLine("2.Exit");
            Console.Write("Enter Option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        public static void Header()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("|                      |");
            Console.WriteLine("|      BLACK JACK      |");
            Console.WriteLine("|                      |");
            Console.WriteLine("------------------------");
        }

        public static void PrintHand(BlackjackHand hand)
        {
            for (int i = 0; i < hand.getCardCount(); i++)
            {
                Card c = hand.GetCard(i);
                Console.WriteLine($"{c.getValueAsString()} of {c.getSuitAsString()}");
            }

        }
        public static void PrintDealerHand(BlackjackHand hand)
        {
            for (int i = 0; i < 1; i++)
            {
                Card c = hand.GetCard(i);
                Console.WriteLine($"{c.getValueAsString()} of {c.getSuitAsString()}");
            }
            Console.WriteLine("The Other Card is Face Down");

        }

        public static void Tie()
        {
            Console.WriteLine("It's A Tie...");
        }

        public static void PrintScore(int score)
        {
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Press Enter To Continue...");
        }
    }

}
