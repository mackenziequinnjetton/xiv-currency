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

    // This also inherits from Item because some BarterItems are themselves
    // bought from Vendors with Currencies or other BarterItems
    public class BarterItem : Item
    {
        public BarterItem(string name, Currency currency, int? currencyCost,
            BarterItem barterItem, int? barterCost) 
            : base(name, currency, currencyCost, barterItem, barterCost)
        {

        }
    }
}
