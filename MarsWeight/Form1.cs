using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarsWeight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!ValidatePositiveDouble(txtEarth.Text, out double earthWeight, out string weightErrorMsg))
            {
                MessageBox.Show(weightErrorMsg, "Earth Weight Error");
                txtEarth.Focus();
                return;
            }
                
                double conversionFactor = 0.377;
                double marsWeight = earthWeight * conversionFactor;
                txtMars.Text = marsWeight.ToString();
        }

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
