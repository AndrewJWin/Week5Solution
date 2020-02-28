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

namespace SchoolCancellation
{
    public partial class Form1 : Form
    {
        // Setting a readonly string for whether or not the school will or will not be cancelled.
        readonly string school = "School will ";

        public Form1()
        {
            InitializeComponent();
        }

        // Verify button Method, takes the input of the three values responsible for the school possibly closing.
        private void btnVerify_Click(object sender, EventArgs e)
        {
            // Pre-initializing the values blank and false beforehand as a default value.
            string errorMsg = "";
            bool airTooCold = false;
            bool windTooCold = false;
            bool snowTooDeep = false;
            
            // Checking each input through the same if Statement and responding accordingly if there is an error message.
            if (!ValidatePositiveInt(txtAirTemp.Text, out Int32 airTemp, ref errorMsg) ||
                !ValidatePositiveInt(txtWindTemp.Text, out Int32 windTemp, ref errorMsg) ||
                !ValidatePositiveInt(txtSnowfall.Text, out Int32 snowDepth, ref errorMsg))
            {
                MessageBox.Show(errorMsg, "Value Error");
                return;
            }

            // If statements for each possible reason for the school to be closed.
            if (airTemp < -25) { airTooCold = true; txtReasonTemp.Text = "Temperature is too Cold"; }
            if (windTemp < -35) { windTooCold = true; txtReasonWind.Text = "Wind is too Bitter"; }
            if (snowDepth > 6) { snowTooDeep = true; txtReasonSnow.Text = "Snow is too Deep"; }


            // If any of the possible reasons for the school to close are valid, then the school will be cancelled. Otherwise the school will remain open.
            if (airTooCold | windTooCold | snowTooDeep)
            {
                lblClosing.Text = school + "be Cancelled.";
            } else
            {
                lblClosing.Text = school + "not be Cancelled.";
                txtReasonTemp.Text = "Temperature is fine.";
                txtReasonWind.Text = "Wind is fine.";
                txtReasonSnow.Text = "Snow is fine.";
            }
        }

        // Exit button method, straightforward closing method.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // ValidatePositiveInt Method, takes in standard text and converts it to an Int32 number.
        // If successful, it returns true and outs a valid Int32 number.
        // Elsewise, if it's not successful - It instead returns false and references back an errorMessage.
        private bool ValidatePositiveInt(string text, out Int32 number, ref string errorMessage)
        {
            errorMessage = null;
            number = 0;
            try
            {
                number = Int32.Parse(text);
                return true;
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
