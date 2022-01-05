using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIVCurrencyClasses
{
    // Represents an in-game item
    public class Item
    {
        public string Name { get; set; }
        public Currency Currency { get; set; }
        // Represents the amount of the above Currency that an item costs

        // See note on BarterCost
        public int? CurrencyCost { get; set; }
        public BarterItem BarterItem { get; set; }
        // Represents the amount of BarterItems that need to be traded
        // for the item

        // CurrencyCost and BarterCost are nullable because some items
        // cost Currency only, some BarterItems only, and some both
        public int? BarterCost { get; set; }

        public Item(string name, Currency currency, int? currencyCost,
            BarterItem barterItem, int? barterCost)
        {
            Name = name;
            Currency = currency;
            CurrencyCost = currencyCost;
            BarterItem = barterItem;
            BarterCost = barterCost;
        }
    }
}
