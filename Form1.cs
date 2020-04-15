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
        string temp=string.Empty;

        string[] operation = new string[10];
        float[] numbers = new float[20];
        int indexNum = 0, indexOp = 0;

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
            numSave();
            float result = numbers[0];

            if ((indexNum - indexOp) <1)
            {
                MessageBox.Show("Error!","Error",MessageBoxButtons.OK);
            }

            else {
                for(int i = 0; i < indexOp; i++) {
                    switch (operation[i]){
                        case "+":
                            result = result + numbers[i + 1];
                            break;
                        case "-":
                            result = result - numbers[i + 1];
                            break;
                        case "*":
                            result = result * numbers[i + 1];
                            break;
                        case "/":
                            if (numbers[i + 1]!=0){
                                result = result / numbers[i + 1];
                            }
                            else
                            {
                                MessageBox.Show("Error", "Division by Zero isn't defined", MessageBoxButtons.OK);
                            }
                            break;
                    }

                }
            }
            textBox1.Text = string.Empty;
            textBox1.Text = result.ToString();
            result = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
            temp += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
            temp += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
            temp += 3;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
            temp += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
            temp += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
            temp += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
            temp += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
            temp += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
            temp += 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
            temp += 0;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            Array.Clear(numbers,0,20);
            Array.Clear(operation, 0, 10);
            
        }

        private void buttonPlu_Click(object sender, EventArgs e)
        {
            numSave();
            textBox1.Text += "+";
            operation[indexOp] = "+";
            indexOp++;

        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            numSave();
            textBox1.Text += "*";
            operation[indexOp] = "*";
            indexOp++;

        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            numSave();
            textBox1.Text += "/";
            operation[indexOp] = "/";
            indexOp++;
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            numSave();
            textBox1.Text += "-";
            operation[indexOp] = "-";
            indexOp++;
        }
        private void numSave()
        {
            numbers[indexNum] = Convert.ToSingle(temp);
            indexNum++;
            temp = string.Empty;
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
        private void buttonSign_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(-";
            bracket++;
            
        }
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            calculate();
        }


    }
}
