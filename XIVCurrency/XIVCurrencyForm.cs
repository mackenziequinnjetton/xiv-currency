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
using System.Net.Http;

namespace XIVCurrency
{
    public partial class XivCurrencyForm : Form
    {
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
            // Base API URL
            var apiUrl = @"https://xivapi.com";

            // HttpResponseMessage
        }
    }
}
