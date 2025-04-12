using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_03.BL;

namespace Task_03.UI
{
    internal class PlayerUI
    {
        public static void PlayerHand()
        {
            Console.WriteLine("Player's Hand: ");
        }

        public static void PlayerHandValue(BlackjackHand hand)
        {
            Console.WriteLine("PLayer's Hand Value: " + hand.getBlackjackValue());
        }

        public static void PlayerBlackjackWin()
        {
            Console.WriteLine("Player has BlackJack!");
            Console.WriteLine("Player Wins");
        }

        public static void PlayerBustWin()
        {
            Console.WriteLine("Dealer busts!");
            Console.WriteLine("Player Wins");
        }

        public static void PlayerTurn()
        {
            Console.WriteLine("Player's Turn: ");
            Console.WriteLine("Do You Want To Hit Or Stand?");
        }

        public static void PlayerWins()
        {
            Console.WriteLine("Player Wins");
        }
    }
}
