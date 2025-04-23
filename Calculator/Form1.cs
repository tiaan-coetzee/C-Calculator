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
        //initialise variables
        string displayedNumber ="";
        int numberSelected;
        int btsCalcuation = 0;
        int operationSelected = 0; // 0 = none, 1 = plus, 2 = minus, 3 = times, 4 = divide
        bool shouldReset = false;

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
            int.TryParse(displayedNumber, out numberSelected);
            operationSelected = 1;
            displayedNumber = "";
            updateDisplay();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int.TryParse(displayedNumber, out numberSelected);
            operationSelected = 2;
            displayedNumber = "";
            updateDisplay();
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            int.TryParse(displayedNumber, out numberSelected);
            operationSelected = 3;
            displayedNumber = "";
            updateDisplay();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int.TryParse(displayedNumber, out numberSelected);
            operationSelected = 4;
            displayedNumber = "";
            updateDisplay();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            shouldReset = true;
            int calculatedNumber = 0;

            switch (operationSelected)
            {
                case 0:
                    MessageBox.Show("No operation selected");
                    shouldReset = false;
                        break;

                case 1:
                    calculatedNumber = int.Parse(displayedNumber) + numberSelected;
                    displayedNumber = calculatedNumber.ToString();
                    updateDisplay();
                        break;

                case 2:
                    calculatedNumber = numberSelected - int.Parse(displayedNumber);
                    displayedNumber = calculatedNumber.ToString();
                    updateDisplay();
                    break;

                case 3:
                    calculatedNumber = numberSelected * int.Parse(displayedNumber);
                    displayedNumber = calculatedNumber.ToString();
                    updateDisplay();
                    break;

                case 4:
                    calculatedNumber = numberSelected / int.Parse(displayedNumber);
                    displayedNumber = calculatedNumber.ToString();
                    updateDisplay();
                    break;
            }
            operationSelected = 0;
        }



        private void updateDisplay()
        {
            //updates the display on the calculator
            tmpLabel.Text = displayedNumber;
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            try
            {
                displayedNumber = displayedNumber.Remove(displayedNumber.Length - 1, 1);

                if (shouldReset)
                {
                    displayedNumber = "";
                    shouldReset = false;
                }
                updateDisplay();
            }

            catch
            {

            }
        }
    }
}
