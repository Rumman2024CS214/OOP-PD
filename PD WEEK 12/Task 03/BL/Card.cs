using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03.BL
{
    internal class Card
    {
        private int value;
        private int suit;

        public Card(int value, int suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public int getValue()
        {
            if (value == 12 || value == 13)
            {
                return 10;
            }
            else
            {
                return value;
            }
        }

        public int getSuit()
        {
            return suit;
        }

        public string getValueAsString()
        {
            if (value == 1 || value == 11)
            {
                return "Ace";
            }
            else if (value == 10)
            {

                return "Jack";
            }
            else if (value == 12)
            {
                return "Queen";
            }
            else if (value == 13)
            {
                return "King";
            }
            else
            {
                return value.ToString();
            }
        }

        public string getSuitAsString()
        {
            if (value == 1)
            {
                return "Clubs";
            }
            else if (value == 2)
            {
                return "Diamonds";
            }
            else if (value == 3)
            {
                return "Spades";
            }
            else
            {
                return "Hearts";
            }
        }

        public string toString()
        {
            return getValueAsString() + " of " + getSuitAsString();
        }

    }
}
