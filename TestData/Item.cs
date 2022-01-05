using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIVCurrencyClasses
{
    public class Item
    {
        public string Name { get; set; }
        public Currency? Currency { get; set; }
        public int? CurrencyCost { get; set; }
        public BarterItem? BarterItem { get; set; }
        public int? BarterCost { get; set; }

        public Item(string name, Currency? currency, int? currencyCost,
            BarterItem? barterItem, int? barterCost)
        {
            Name = name;
            Currency = currency;
            CurrencyCost = currencyCost;
            BarterItem = barterItem;
            BarterCost = barterCost;
        }
    }
}
