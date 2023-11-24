using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;
namespace BasicCalculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox2.Text);

            if (comboBox1.Text.ToString().Equals("+"))
            {
                txtAnswer.Text = BasicComputation.Addition(num1,num2).ToString();
            }
            else if (comboBox1.Text.ToString().Equals("-"))
            {
                txtAnswer.Text = BasicComputation.Subtraction(num1, num2).ToString();
            }
            else if (comboBox1.Text.ToString().Equals("*"))
            {
                txtAnswer.Text = BasicComputation.Multiplication(num1, num2).ToString();
            }
            else if (comboBox1.Text.ToString().Equals("/"))
            {
                txtAnswer.Text = BasicComputation.Division(num1, num2).ToString();
            }
            else
            {
                MessageBox.Show("Please select an output");
            }
        }
    }
}
