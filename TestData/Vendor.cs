using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestData
{
    // Represents an item vendor in the game
    public class Vendor
    {
        public string Name { get; set; }
        public Location Location { get; set; }
        public ItemCategory[] ItemCategories { get; set; }

        public Vendor(string name, Location location, 
            ItemCategory[] itemCategories)
        {
            Name = name;
            Location = location;
            ItemCategories = itemCategories;
        }
    }
}
