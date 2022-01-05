using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIVCurrencyClasses
{
    // Represents an in-game item that can be bartered/traded for goods

    // This is a separate class from Currency because currencies and barter
    // goods are handled differently by the game
    public class BarterItem
    {
        public string Name { get; set; }

        public BarterItem(string name)
        {
            Name = name;
        }
    }
}
