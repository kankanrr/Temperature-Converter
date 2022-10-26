using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_5_Temperature_Converter
{
    /* 
     * Use try catch to handle exceptions for data input
     * 
     * The conversion formulas are given as:
     * C = 5/9(F - 32) - use this in the button Convert to Celsius
     * F = 9/5C + 32 - use this in the button Convert to Fahrenheit
     * NOTE: do take care of division of 2 integers.  Remember that in C# when you divide two integers, the result is an integer
     * Display converted temperature to 1 decimal place
     * 
     * Reset button - clear all inputs and outputs and place the cursor at textbox1
     * Exit button - exit the application
    */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxCelsius.Clear();
            textBoxFahrenheit.Clear();
            outputCelsius.ResetText();
            outputFahrenheit.ResetText();
            textBoxCelsius.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConvertCelsius_Click(object sender, EventArgs e)
        {
            decimal tempF;
            double OutputTempF;

            string caption = "Celsius and Fahrenheit Temperature Converter";

            try
            {
                tempF = decimal.Parse(textBoxCelsius.Text);
            }
            catch
            {
                MessageBox.Show("Data error in Fahrenheit box. Please input a valid number into the textbox.", caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCelsius.Clear();
                textBoxCelsius.Focus();
                return;
            }

            OutputTempF = (double)5/9 * ((double)tempF - 32);

            outputCelsius.Text = OutputTempF.ToString("n1");
        }

        private void buttonConvertFahrenheit_Click(object sender, EventArgs e)
        {
            decimal tempC;
            double OutputTempC;

            string caption = "Celsius and Fahrenheit Temperature Converter";

            try
            {
                tempC = decimal.Parse(textBoxFahrenheit.Text);
            }
            catch
            {
                MessageBox.Show("Data error in Celsius box. Please input a valid number into the textbox.", caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFahrenheit.Clear();
                textBoxFahrenheit.Focus();
                return;
            }

            OutputTempC = (double)9/5 * (double)tempC + 32;

            outputFahrenheit.Text = OutputTempC.ToString("n1");
        }
    }
}
