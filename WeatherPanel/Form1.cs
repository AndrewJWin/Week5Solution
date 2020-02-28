using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.IO;

/**********************************\
*                                  *
* Andrew Terwilliger 2/28/2020     *
* Minneapolis College              *
* ITEC 2505-60 C# Programming      *
*                                  *
\**********************************/

namespace WeatherPanel
{
    public partial class Form1 : Form
    {
        // Setting a readonly string for the base URL of the weather application.
        readonly string BaseURL = "https://weather-csharp.herokuapp.com/";

        public Form1()
        {
            InitializeComponent();
        }

        // GetWeather button Method, takes the provided City and State - fetches the Weather data and returns the value.
        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            btnGetWeather.Enabled = false;

            string city = txtCity.Text;
            string state = txtState.Text;

            // Checking if the location is valid, if not - Return the error provided by the website.
            // Also getting the image from the weather location - Also returning errors provided by the website.
            if (LocationDataValid(city, state))
            {
                if (GetWeatherData(city, state, out string weather, out string dataError))
                {
                    lblWeather.Text = weather;
                }
                else
                {
                    MessageBox.Show(dataError, "Error");
                    return;
                }
                if (picWeather.Image != null)
                {
                    picWeather.Image.Dispose();
                }
                if (GetWeatherImage(city, state, out Image image, out string imageError))
                {
                    picWeather.Image = image;
                }
                else
                {
                    MessageBox.Show(imageError, "Error");
                    return;
                }
            } else
            {
                MessageBox.Show("Please verify both City and State.", "Error");
            }
            btnGetWeather.Enabled = true;
        }


        // Location validation Method, takes both the string value of City and State - Makes sure they're not null or empty and returns true or falses.
        private bool LocationDataValid(string city, string state)
        {
            if (String.IsNullOrEmpty(city) || String.IsNullOrEmpty(state))
            {
                return false;
            }
            return true;
        }

        // Weather data fetching, takes in the City and State provided and fetches weather data from the website provided.
        // If data was successful, the method returns true - and outs the string weatherText.
        // Otherwise, the method returns false - and outs the string errorMessage.
        private bool GetWeatherData(string city, string state, out string weatherText, out string errorMessage)
        {
            string weatherTextURL = String.Format("{0}text?city={1}&state={2}", BaseURL, city, state);
            errorMessage = null;
            weatherText = null;

            try
            {
                using (WebClient client = new WebClient())
                {
                    weatherText = client.DownloadString(weatherTextURL);
                }
                return true;
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
                return false;
            }
        }

        // Similar concept to the GetWeatherData Method, takes City and State - But instead outs an image weatherImage.
        private bool GetWeatherImage(string city, string state, out Image weatherImage, out string errorMessage)
        {
            weatherImage = null;
            errorMessage = null;
            
            try
            {
                using (WebClient client = new WebClient())
                {
                    string weatherPhotoURL = String.Format("{0}photo?city={1}&state={2}", BaseURL, city, state);
                    string tempFileDir = Path.GetTempPath().ToString();
                    String weatherFilePath = Path.Combine(tempFileDir, "weather_image.jpeg");
                    client.DownloadFile(weatherPhotoURL, weatherFilePath);
                    weatherImage = Image.FromFile(weatherFilePath);
                }
                return true;
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
                return false;
            }
        }
    }
}
