using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem___4.BL
{
    internal class FixedInterest : Interest
    {
        public override double TrueBank(double amount, double rate)
        {
            return amount + (amount * rate/100) + 1500;
        }
    }
}
