using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01.BL
{
    internal class Subject
    {
        public string code;
        public int credithours;
        public string type;
        public int subjectfee;
        
        public Subject(string code,int credithours,string type,int subjectfee)
        {
            this.code = code;
            this.credithours = credithours;
            this.type = type;
            this.subjectfee = subjectfee;
        }
    }
}
