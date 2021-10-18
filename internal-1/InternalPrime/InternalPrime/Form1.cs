using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternalPrime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private bool isPrime(int num){
            for (int i = 2; i <= Math.Sqrt(num); i++){
                if (num % i == 0) {
                    return false;
                }
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);

            if (isPrime(num)) {
                textBox2.Text = "Prime";
            }
            else {
                textBox2.Text = "Not Prime";
            }

        }
    }
}
