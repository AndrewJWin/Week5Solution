using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolCancellation
{
    public partial class Form1 : Form
    {

        readonly string school = "School will ";

        public Form1()
        {
            InitializeComponent();
        }


        private void btnVerify_Click(object sender, EventArgs e)
        {
            string errorMsg = "";

            bool airTooCold = false;
            bool windTooCold = false;
            bool snowTooDeep = false;
            if (!ValidatePositiveInt(txtAirTemp.Text, out Int32 airTemp, ref errorMsg) ||
                !ValidatePositiveInt(txtWindTemp.Text, out Int32 windTemp, ref errorMsg) ||
                !ValidatePositiveInt(txtSnowfall.Text, out Int32 snowDepth, ref errorMsg))
            {
                MessageBox.Show(errorMsg, "Value Error");
                return;
            }

            if (airTemp < -25) { airTooCold = true; txtReasonTemp.Text = "Temperature is too Cold"; }
            if (windTemp < -35) { windTooCold = true; txtReasonWind.Text = "Wind is too Bitter"; }
            if (snowDepth > 6) { snowTooDeep = true; txtReasonSnow.Text = "Snow is too Deep"; }

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
