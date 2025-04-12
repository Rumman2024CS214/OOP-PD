using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03.BL
{
    internal class BlackjackHand : Hand
    {
        public int getBlackjackValue()
        {
            int val = 0;
            bool ace = false;
            foreach(Card c in hand)
            {
                if (c.getValue() == 1 || c.getValue() == 11)
                {
                    ace = true;
                    if (ace)
                    {
                        if (val + 11 > 21)
                        {
                            val += 1;
                        }
                        else
                        {
                            val += 11;
                        }
                    }
                }
                else
                {
                    val += c.getValue();
                }
                ace = false;
            }
            
            return val;
        }
    }
}
