using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem___3.BL
{
    internal class Interest
    {
        public double TrueBank(double amount,double rate)
        {
            return amount + (amount * rate/100);
        }

        public double TrueBank(double amount, double rate,string holderType)
        {
            return amount + (amount * rate/100) + 2000;
        }
    }
}
