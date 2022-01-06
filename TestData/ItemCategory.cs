using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using XIVCurrencyClasses;

namespace XIVCurrencyClasses
{
    // Represents a category of items sold by the in-game Vendor,
    // as accessible in the Vendor's GUI
    public class ItemCategory
    {
        public string Name { get; set; }
        public Item[] Items { get; set; }

        public ItemCategory(string name)
        {
            Name = name;
        }
    }
}
