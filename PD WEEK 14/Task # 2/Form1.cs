using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task___2
{
    public partial class Calculator : Form
    {
        bool addition = false;
        bool multiply = false;
        bool divide = false;
        bool diff = false;
        bool floating = false;

        List<int> num = new List<int>();
        List<Decimal> decimals = new List<Decimal>();
        public Calculator()
        {
            InitializeComponent();
        }

        private void display_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            display.Text += "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            display.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            display.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            display.Text += "/";
            divide = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            display.Text += "*";
            multiply = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            display.Text += "-";
            diff = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            display.Text += "+";
            addition = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            display.Text += ".";
            floating = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display.Text = " ";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            display.Text = " ";
            addition = false;
            multiply = false;
            diff = false;
            divide = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            num.Clear();
            decimals.Clear();
            decimal result = 0;
            string[] numbers = display.Text.Split('+','-','*','/');
            if(floating)
            {

                foreach (string number in numbers)
                {
                    decimals.Add(Convert.ToDecimal(number));
                }
                if (addition == true && multiply == false && diff == false && divide == false)
                {
                    foreach (decimal d in decimals)
                    {
                        result += d;
                    }
                    display.Text = result.ToString();
                }
                if (addition == false && multiply == true && diff == false && divide == false)
                {
                    result = 1;
                    foreach (decimal d in decimals)
                    {
                        result = result * d;
                    }
                    display.Text = result.ToString();
                }
                if (addition == false && multiply == false && diff == true && divide == false)
                {
                    result = decimals[0];
                    for (int i = 1; i < decimals.Count; i++)
                    {
                        result = result - decimals[i];
                    }
                    display.Text = result.ToString();
                }
                if (addition == false && multiply == false && diff == false && divide == true)
                {
                    result = decimals[0];
                    for (int i = 1; i < decimals.Count; i++)
                    {
                        result = result / decimals[i];
                    }
                    display.Text = result.ToString();
                }

            }
            else
            {

                foreach (string number in numbers)
                {
                    try
                    {
                        num.Add(Convert.ToInt32(number));
                    }
                    catch(System.FormatException)
                    {
                        MessageBox.Show("Syntax Error");
                    }
                }
                if (addition == true && multiply == false && diff == false && divide == false)
                {
                    foreach (int number in num)
                    {
                        result += number;
                    }
                    display.Text = result.ToString();
                }
                if (addition == false && multiply == true && diff == false && divide == false)
                {
                    result = 1;
                    foreach (int number in num)
                    {
                        result = result * number;
                    }
                    display.Text = result.ToString();
                }
                if (addition == false && multiply == false && diff == true && divide == false)
                {
                    result = num[0];
                    for (int i = 1; i < num.Count; i++)
                    {
                        result = result - num[i];
                    }
                    display.Text = result.ToString();
                }
                if (addition == false && multiply == false && diff == false && divide == true)
                {
                    result = num[0];
                    for (int i = 1; i < num.Count; i++)
                    {
                        result = result / num[i];
                    }
                    display.Text = result.ToString();
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (display.Text.Length > 0)
            {
                display.Text = display.Text.Substring(0, display.Text.Length - 1);
            }
        }   
    }
}
