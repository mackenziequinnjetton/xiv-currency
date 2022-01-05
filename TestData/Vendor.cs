using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestData
{
    public class Vendor
    {
        public string Name { get; set; }
        public Location Location { get; set; }
        public Category[] Categories { get; set; }

        public Vendor(string name, Location location, Category[] categories)
        {
            Name = name;
            Location = location;
            Categories = categories;
        }
    }
}
