using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task_03.BL
{
    internal class Hand
    {
        protected List<Card> hand;
        public Hand()
        { 
            hand = new List<Card>();
        }

        public void clear()
        {
            hand.Clear();
        }

        public void AddCard(Card card)
        {
            hand.Add(card);
        }

        public void removeCard(Card card)
        {
            hand.Remove(card);
        }

        public void removeAtSpecificPosition(int position)
        {
            hand[position] = null;
        }

        public int getCardCount()
        {
            return hand.Count;
        }

        public Card GetCard(int position)
        {
            return hand[position];
        }

        public void sortBySuit()
        {
            hand.Sort();
        }

        public void sortByValue()
        {

        }
    }
}
