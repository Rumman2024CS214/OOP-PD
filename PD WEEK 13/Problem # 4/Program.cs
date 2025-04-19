using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem___4.BL;

namespace Problem___4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Interest> interests = new List<Interest>();
            Interest i = new Interest();
            Console.WriteLine("Normal Interest For Holder: " + i.TrueBank(5000,10));
            SimpleInterest si = new SimpleInterest();
            FixedInterest fi = new FixedInterest();
            interests.Add(si);
            interests.Add(fi);
            foreach (Interest interest in interests)
            {
                Console.WriteLine("Interest For Holder: " + interest.TrueBank(5000, 10));
            }
            
        }
    }
}
