using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recusions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void factorialButton_Click(object sender, EventArgs e)
        {
            int number;

            try
            {
                number = Convert.ToInt32(factorialInput.Text);
            }
            catch
            {
                return;
            }

            int result = Factorial(number);
            factorialOutput.Text = $"The factorial of {number} is {result}";
        }

        private void gcdButton_Click(object sender, EventArgs e)
        {
            int num1, num2;

            try
            {
                num1 = Convert.ToInt32(gcd1Input.Text);
                num2 = Convert.ToInt32(gcd2Input.Text);
            }
            catch
            {
                return;
            }

            int result = GCD(num1, num2);

            gcdOutput.Text = $"The GCD of {num1} and {num2} is {result}";
        }

        private void hanoiButton_Click(object sender, EventArgs e)
        {
            int discs = 4;

            hanoiOutput.Text = $"There are {discs} discs on peg A initially \n\n";

            Hanoi("A", "C", "B", discs);
        }

        private void scrambleButton_Click(object sender, EventArgs e)
        {
            string letters = scrambleInput.Text;

            scrambleOutput.Text = $"Starting letters are {letters} \n\n";

            Scramble("", letters);
        }

        public int Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return (n * Factorial(n - 1));
            }
        }

        public int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return GCD(b, a % b);
            }
        }


        public void Hanoi(string from, string to, string temp, int n)
        {
            if (n == 1)
            {
                hanoiOutput.Text += $"Move disc 1 from {from} to {to} \n";
            }
            else
            {
                Hanoi(from, temp, to, n - 1);
                hanoiOutput.Text += $"Move disc {n} from {from} to {to} \n";
                Hanoi(temp, to, from, n - 1);
            }
        }

        public void Scramble(string startString, string endString)
        {
            string newString;

            if (endString.Length == 1)
            {
                scrambleOutput.Text += startString + endString + "  ";
            }
            else
            {
                for (int i = 0; i < endString.Length; i++)
                {
                    newString = endString.Substring(0, i) + endString.Substring(i + 1);
                    Scramble(startString + endString.ElementAt(i), newString);
                }
            }
        }
    }
}
