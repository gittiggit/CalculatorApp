using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }
        Calculator aCalculator = new Calculator();
        private double firstNumber;
        private double secondNumber;
        private void addButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = aCalculator.Add(firstNumber, secondNumber).ToString();

        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = aCalculator.Subtract(firstNumber, secondNumber).ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = aCalculator.Multiply(firstNumber, secondNumber).ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = aCalculator.Divide(firstNumber, secondNumber).ToString();
        }
    }
}
