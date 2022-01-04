using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Flurl;
using Flurl.Http;
using System.Net.Http;
using Newtonsoft.Json;

namespace XIVCurrency
{
    public partial class XivCurrencyForm : Form
    {
        private static HttpClient HttpClient;
        
        public XivCurrencyForm()
        {
            InitializeComponent();
        }

        // Clear placeholder text upon textbox gaining focus
        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
        }

        // If user has not entered search query, reset text
        // to initial placeholder text upon textbox losing focus
        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                searchTextBox.Text = "Search for an item by name";
            }
        }

        // Query game API for item information, and display
        // information in resultListBox
        private async void searchButton_Click(object sender, EventArgs e)
        {
            // API search URL
            var apiUrl = 
                @"https://xivapi.com/search?indexes=Itemlimit=10&string=";

            /*HttpResponseMessage apiRequest =
                (HttpResponseMessage)
                await $"{apiUrl}{searchTextBox.Text}".GetAsync();*/

            HttpClient = new HttpClient();

            HttpResponseMessage apiRequest = await HttpClient.GetAsync(
                $"{apiUrl}{searchTextBox.Text}");

            /*JObject apiResponse = (JObject)JsonConvert.DeserializeObject(
                apiRequest.Content.ReadAsStringAsync().Result);*/

            JObject apiResponse = JObject.Parse(apiRequest.ToString());

            MessageBox.Show($"{apiResponse}");

            apiRequest.Dispose();
            apiResponse.Dispose();
        }
    }
}
