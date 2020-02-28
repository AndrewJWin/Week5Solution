using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**********************************\
*                                  *
* Andrew Terwilliger 2/28/2020     *
* Minneapolis College              *
* ITEC 2505-60 C# Programming      *
*                                  *
\**********************************/

namespace MarsWeight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Calculate Button Method, takes the provided values and validates them - if valid it continues, otherwise it throws an error and returns.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Validating String.
            if (!ValidateString(txtObjName.Text, out string name, out string textError))
            {
                MessageBox.Show(textError, "Object Name Error");
                txtObjName.Focus();
                return;
            }
            // Validating Double value.
            if (!ValidatePositiveDouble(txtEarth.Text, out double earthWeight, out string weightErrorMsg))
            {
                MessageBox.Show(weightErrorMsg, "Earth Weight Error");
                txtEarth.Focus();
                return;
            }
                
                // Mars weight conversion factor.
                double conversionFactor = 0.377;
                double marsWeight = earthWeight * conversionFactor;
                txtMars.Text = String.Format("{0} weights {1} on Mars", name, marsWeight);
        }

        // ValidateString Method, takes in string text and outputs a string again - Mainly checking if the value is empty or not.
        private bool ValidateString(string text, out string name, out string textErrorMsg)
        {
            textErrorMsg = null;
            name = text;

            // If it's empty, return false and set the textErrorMsg string.
            if (String.IsNullOrEmpty(text))
            {
                textErrorMsg = "Object name cannot be empty";
                return false;
            }
            return true;
        }

        // ValidatePositiveDouble Method, takes in text and converts it to a double value number and returns true. 
        // Otherwise returns false and responds with an error message.
        // Also catches two exceptions: Format and Overflow - if either of those occurs the method returns false and responds with an error message.
        private bool ValidatePositiveDouble(string text, out double number, out string errorMessage)
        {
            errorMessage = null;
            number = 0;
            try
            {
                number = Double.Parse(text);
               if (number >= 0)
                {
                    return true;
                }
                else
                {
                    errorMessage = "Enter a positive Number";
                    return false;
                }
            }
            catch (FormatException)
            {
                errorMessage = "Enter numbers only.";
                return false;
            }
            catch (OverflowException)
            {
                errorMessage = "Enter a smaller number.";
                return false;
            }
        }
    }
}
