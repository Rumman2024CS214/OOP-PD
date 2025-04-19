using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem___3.BL;

namespace Problem___3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interest i = new Interest();
            Console.WriteLine("Normal Interest for a Holder: "+i.TrueBank(5000, 10));
            Console.WriteLine("Prime Interest for a Holder: "+i.TrueBank(5000, 10, "Rumman"));

        }
    }
}
