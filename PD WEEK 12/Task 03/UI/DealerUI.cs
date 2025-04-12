using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_03.BL;

namespace Task_03.UI
{
    internal class DealerUI
    {
        public static void DealerHand()
        {
            Console.WriteLine("Dealer's Hand: ");
        }

        public static void DealerHandValue(BlackjackHand hand)
        {
            Console.WriteLine("Dealer's Hand Value: " + hand.getBlackjackValue());
        }

        public static void DealerBlackjackWin()
        {
            Console.WriteLine("Dealer has BlackJack!");
            Console.WriteLine("Dealer Wins");
        }

        public static void DealerBustWin()
        {
            Console.WriteLine("Player busts!");
            Console.WriteLine("Dealer Wins");
        }

        public static void DealersTurn(BlackjackHand dealerHand)
        {
            Console.WriteLine("Dealer's Turn");
            Console.WriteLine("Dealer Draws A Card: ");
            //Console.WriteLine($"{dealerHand.GetCard(dealerHand.getCardCount() - 1).getValueAsString()} of {dealerHand.GetCard(dealerHand.getCardCount() - 1).getSuitAsString()}");
        }

        public static void DealerWins()
        {
            Console.WriteLine("Dealer Wins");
        }
    }
}
