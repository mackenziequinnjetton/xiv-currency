using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIVCurrencyClasses
{
    // Represents an in-game currency
    public class Currency
    {
        public string Name { get; set; }

        public Currency(string name)
        {
            Name = name;
        }
    }
}
