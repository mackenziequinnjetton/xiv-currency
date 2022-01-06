using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIVCurrencyClasses
{
    // Represents an item vendor in the game
    public class Vendor
    {
        public string Name { get; set; }
        public ItemCategory[] ItemCategories { get; set; }

        public Vendor(string name, ItemCategory[] itemCategories)
        {
            Name = name;
            ItemCategories = itemCategories;
        }
    }
}
