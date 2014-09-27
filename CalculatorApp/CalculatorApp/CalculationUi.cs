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
    public partial class CalculationUi : Form
    {
        Calculator aCalculator= new Calculator();
        private double firstNumber;
        private double secondNumber;

        public CalculationUi()
        {
            InitializeComponent();
        }

        private void InitializeVariable()
        {
            firstNumber = Convert.ToDouble(firstNumberTxtBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTxtBox.Text);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            InitializeVariable();
            string result=aCalculator.Add(firstNumber,secondNumber).ToString();
            resultTxtBox.Text = result;
        }

       


        private void substractButton_Click(object sender, EventArgs e)
        {
            InitializeVariable();
            string result = aCalculator.Substract(firstNumber, secondNumber).ToString();
            resultTxtBox.Text = result;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            InitializeVariable();
            string result = aCalculator.Multiply(firstNumber, secondNumber).ToString();
            resultTxtBox.Text = result;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            InitializeVariable();
            string result = aCalculator.Divide(firstNumber, secondNumber).ToString();
            resultTxtBox.Text = result;
        }
    }
}
