using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormCalculatorProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            double result = num1 + num2;
            //MessageBox.Show("The result is: " + result.ToString());

            resultWindow.Text = "The addition result is : " + result.ToString();
            resultWindow.Visible = true;
        }

        private void substractButton_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            double result = num1 - num2;
            //MessageBox.Show("The result is: " + result.ToString());

            resultWindow.Text = "The substraction result is : " + result.ToString();
            resultWindow.Visible = true;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            double result = num1 * num2;
            //MessageBox.Show("The result is: " + result.ToString());

            resultWindow.Text = "The multiplication result is : " + result.ToString();
            resultWindow.Visible = true;
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            double result = num1 / num2;
            //MessageBox.Show("The result is: " + result.ToString());

            resultWindow.Text = "The division result is : " + result.ToString();
            resultWindow.Visible = true;
        }
    }
}
