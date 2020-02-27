using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner_fuer_git
{
    public partial class Form1 : Form
    {
        int bracket = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Textbox align
            textBox1.Width=250;
            textBox1.Height = 20;
            textBox1.Left = 20;
            textBox1.Top = 25;



        }

        void calculate()
        {
            //float ergebnis = Convert.ToInt32(textBox1.Text);
           // textBox1.Text = ergebnis.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;

        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void buttonPlu_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";

        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";

        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";

        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";

        }

        private void buttonBracket_Click(object sender, EventArgs e)
        {
            if (bracket % 2 == 0)
            {
                textBox1.Text += "(";
                bracket++;
            }
            else
            {
                textBox1.Text += ")";
                bracket++;
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            calculate();
        }
    }
}
