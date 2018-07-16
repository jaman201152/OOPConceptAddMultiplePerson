using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPWalkThrough1.Models;

namespace OOPWalkThrough1
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }

        private void CalculatorUI_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int thirdNumber = 50;
            double result = calculator.Add(firstNumber,secondNumber,thirdNumber,50,60);

            resultLabel.Text = result.ToString();
        }
    }
}
