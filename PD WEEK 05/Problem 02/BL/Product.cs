using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Problem_02.BL
{
    internal class Product
    {
        public string name;
        public string category;
        public float price;
        public int quantity;
        public int threshold;

        public Product(string name,string category,float price,int quantity,int threshold)
        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.quantity = quantity;
            this.threshold = threshold;
        }
        public Product(string name, string category, float price, int quantity)
        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.quantity = quantity;
        }
    }
}
