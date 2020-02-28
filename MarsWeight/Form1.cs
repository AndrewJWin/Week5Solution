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

            if (!ValidateString(txtObjName.Text, out string name, out string textError))
            {
                MessageBox.Show(textError, "Object Name Error");
                txtObjName.Focus();
                return;
            }

            if (!ValidatePositiveDouble(txtEarth.Text, out double earthWeight, out string weightErrorMsg))
            {
                MessageBox.Show(weightErrorMsg, "Earth Weight Error");
                txtEarth.Focus();
                return;
            }
                
                double conversionFactor = 0.377;
                double marsWeight = earthWeight * conversionFactor;
                txtMars.Text = String.Format("{0} weights {1} on Mars", name, marsWeight);
        }

        private bool ValidateString(string text, out string name, out string textErrorMsg)
        {
            textErrorMsg = null;
            name = text;
            if (String.IsNullOrEmpty(text))
            {
                textErrorMsg = "Object name cannot be empty";
                return false;
            }
            return true;
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
