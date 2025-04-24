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
        decimal numberSelected;
        int operationSelected = 0; // 0 = none, 1 = plus, 2 = minus, 3 = times, 4 = divide
        bool shouldReset = false;

        public Form1()
        {
            InitializeComponent();
            this.Shown += new EventHandler(Form1_Shown);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            panel1.Focus();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            buttonPressed(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            buttonPressed(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            buttonPressed(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            buttonPressed(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            buttonPressed(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            buttonPressed(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            buttonPressed(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            buttonPressed(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            buttonPressed(9);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            buttonPressed(0);
        }
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            buttonPressed(99);
        }
        private void btnPosNeg_Click(object sender, EventArgs e)
        {
            buttonPressed(77);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operationToBePerformed(1);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operationToBePerformed(2);
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            operationToBePerformed(3);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operationToBePerformed(4);
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (lblOperation.Text != "" && (operationSelected!=4 && int.Parse(displayedNumber)!=0))
            {
                shouldReset = true;
                decimal calculatedNumber = 0;
                lblOperation.Text = "=";
                lblOperatingNr.Text = "";

                switch (operationSelected)
                {
                    case 0:
                        shouldReset = false;
                        break;

                    case 1:
                        calculatedNumber = (decimal)numberSelected + decimal.Parse(displayedNumber);
                        displayedNumber = calculatedNumber.ToString("0.########");
                        updateDisplay();
                        break;

                    case 2:
                        calculatedNumber = (decimal)numberSelected - decimal.Parse(displayedNumber);
                        displayedNumber = calculatedNumber.ToString("0.########");
                        updateDisplay();
                        break;

                    case 3:
                        calculatedNumber = numberSelected * decimal.Parse(displayedNumber);
                        displayedNumber = calculatedNumber.ToString("0.########");
                        updateDisplay();
                        break;

                    case 4:
                        calculatedNumber = numberSelected / decimal.Parse(displayedNumber);
                        displayedNumber = calculatedNumber.ToString("0.########");
                        updateDisplay();
                        break;
                }
                operationSelected = 0;
            }
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
                    lblOperation.Text = "";
                }
                updateDisplay();
            }

            catch
            {

            }

        }
    
        private void operationToBePerformed(int  number)
        {
            shouldReset = false;
            decimal.TryParse(displayedNumber, out numberSelected);
            operationSelected = number;
            lblOperatingNr.Text = displayedNumber;
            displayedNumber = "";
            updateDisplay();


            switch(number)
            {
                case 1:
                    lblOperation.Text = "+";
                    break;
                case 2:
                    lblOperation.Text = "-";
                    break;
                case 3:
                    lblOperation.Text = "x";
                    break;
                case 4:
                    lblOperation.Text = "÷";
                    break;
            }
        }

        private void buttonPressed(int number)
        {
            if (shouldReset)
            {
                displayedNumber = "";
                lblOperation.Text = "";
                updateDisplay();
            }

            shouldReset = false;

            if (displayedNumber.Length < 8)
            {
                if (number < 10)
                {
                    displayedNumber += number;
                }

                else if (number == 99 && displayedNumber != "" && !displayedNumber.Contains("."))
                {
                    displayedNumber += ".";
                }

                else if (displayedNumber == "" && number == 99)
                {
                    displayedNumber += "0.";
                }
            }

            if (displayedNumber != "" && number == 77)
            {
                if (!displayedNumber.Contains("-"))
                {
                    displayedNumber = "-" + displayedNumber;
                }
                else
                {
                    displayedNumber = displayedNumber.Remove(0, 1);
                }
            }

            updateDisplay();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Note:\r\nThis calculator saves all calculations in decimal format for high precision. However, it only supports up to 8 digits for user input.");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            displayedNumber = "";
            lblOperation.Text = "";
            updateDisplay();
        }
    }
}
