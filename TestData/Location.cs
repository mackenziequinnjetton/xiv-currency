using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestData
{
    // Represents an in-game location containing Vendors
    public class Location
    {
        public string Name { get; set; }
        public Vendor[] Vendors { get; set; }

        public Location (string name, Vendor[] vendors)
        {
            Name = name;
            Vendors = vendors;
        }
    }
}
