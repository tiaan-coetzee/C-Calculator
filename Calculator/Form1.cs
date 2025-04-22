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
        string displayedNumber ="";
        int numberSelected;
        int btsCalcuation = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            displayedNumber += "1";
            updateDisplay();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            displayedNumber += "2";
            updateDisplay();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            displayedNumber += "3";
            updateDisplay();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            displayedNumber += "4";
            updateDisplay();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            displayedNumber += "5";
            updateDisplay();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            displayedNumber += "6";
            updateDisplay();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            displayedNumber += "7";
            updateDisplay();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            displayedNumber += "8";
            updateDisplay();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            displayedNumber += "9";
            updateDisplay();

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            btsCalcuation = btsCalcuation + numberSelected;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {

        }

        private void updateDisplay()
        {
            tmpLabel.Text = displayedNumber;
        }
    }
}
