using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XIVCurrencyClasses;

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

        // Search sample game data for item information, and display
        // information in resultListBox
        private void searchButton_Click(object sender, EventArgs e)
        {
            resultListBox.Items.Clear();
            
            var itemFound = false;
            var searchQuery = searchTextBox.Text;

            foreach(var location in TestData.Locations)
            {
                foreach(var vendor in location.Vendors)
                {
                    foreach(var itemCategory in vendor.ItemCategories)
                    {
                        foreach(var item in itemCategory.Items)
                        {
                            if (item.Name == searchQuery)
                            {
                                itemFound = true;
                                resultListBox.Items.Add(item.Name);
                                resultListBox.Items.Add(location.Name);
                                resultListBox.Items.Add(vendor.Name);
                                resultListBox.Items.Add(itemCategory.Name);
                                if (item.Currency != null)
                                {
                                    resultListBox.Items.Add(
                                        $"{item.CurrencyCost} " +
                                        $"{item.Currency.Name}");
                                }
                                if (item.BarterItem != null)
                                {
                                    resultListBox.Items.Add(
                                        $"{item.BarterCost} " +
                                        $"{item.BarterItem.Name}");

                                }
                                resultListBox.Items.Add(string.Empty);
                            }
                        }
                    }
                }
            }

            if(!itemFound)
            {
                resultListBox.Items.Add("Item was not found.");
            }
        }
    }
}
