using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private bool clear = false;
        private void clearme() {
            if (clear) richTextBox1.Text = "";
            clear = false;
        }
        public Form1()
        {
            InitializeComponent();
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
            button10.Text = "0";
            button11.Text = "+";
            button12.Text = "-";
            button13.Text = "*";
            button14.Text = "/";
            button15.Text = "sqrt";
            button16.Text = "=";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearme();
            richTextBox1.Text += "1";
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            clearme();
            richTextBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearme();
            richTextBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearme();
            richTextBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearme();
            richTextBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clearme();
            richTextBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clearme();
            richTextBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clearme();
            richTextBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clearme();
            richTextBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            clearme();
            richTextBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            clearme();
            richTextBox1.Text += "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            clearme();
            richTextBox1.Text += "-";
        }

       
        private void button13_Click(object sender, EventArgs e)
        {
            clearme();
            richTextBox1.Text += "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            clearme();
            richTextBox1.Text += "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            clearme();
            richTextBox1.Text += "|";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            clearme();
            richTextBox1.Text = "";
        }

        private void calculate(int[] operands, char op) {
            double result = 0.0;
            Console.WriteLine(operands[0]);
            Console.WriteLine(operands[1]);
            Console.WriteLine(op);
            if (op == '+') {
                result = (operands[0] + operands[1]);
            }
            if (op == '-')
            {
                result = (operands[0] - operands[1]);
            }
            if (op == '*') { 
                result = (operands[0] * operands[1]);
            }
            if (op == '/') { 
                result = (operands[0] / operands[1]);
            }
            if (op == '|') { 
                result = Math.Sqrt(operands[0]);
            }
            Console.WriteLine(result);
           
            richTextBox1.Text = "";
            richTextBox1.Text = result.ToString();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            clear = true;
            //richTextBox1.Text += "=";
            String data = richTextBox1.Text;
            int[] operands = new int[2];
            String temp = "";
            int count = 0;
            char op = '0';
            foreach(Char c in data)
            {
                if (count > 1)
                {
                    richTextBox1.Text = "I am not so powerfull.";
                    return;
                }
                if (char.IsDigit(c))
                {
                    temp += c;
                }
                else {
                    op = c;
                    if (op == '|') continue;
                    operands[count] = int.Parse(temp);
                    temp = "";
                    count++;
                }
            }
            operands[count] = int.Parse(temp);
            calculate(operands, op);


        }

    }
}
