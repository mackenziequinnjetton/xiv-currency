using System;

namespace XIVCurrencyClasses
{
    // Sample game data for testing purposes
    public static class TestData
    {
        public static Currency[] Currencies { get; set; } = new Currency[]
        {
            new Currency
            (
                "C1"
            ),
            new Currency
            (
                "C2"
            )
        };
        public static BarterItem[] BarterItems { get; set; } = new BarterItem[]
        {
            new BarterItem
            (
                "B1",
                Currencies[0],
                42,
                null,
                null
            ),
            new BarterItem
            (
                "B2",
                Currencies[1],
                6,
                null,
                null
            )
        };
        public static Location[] Locations { get; set; } = 
            MakeLocations(new string[]{ "L1", "L2" });

        public static Location[] MakeLocations(string[] locationNames)
        {
            return new Location[]
            {
                new Location(locationNames[0],
                    MakeVendors(locationNames[0])),
                new Location(locationNames[1],
                    MakeVendors(locationNames[1]))
            };
        }

        public static Vendor[] MakeVendors(string locationName)
        {
            var vendorName1 = locationName + " V1";
            var vendorName2 = locationName + " V2";

            return new Vendor[]
            {
                new Vendor(vendorName1, 
                    MakeItemCategories(vendorName1)),
                new Vendor(vendorName2,
                    MakeItemCategories(vendorName2))
            };
        }

        public static ItemCategory[] MakeItemCategories(string vendorName)
        {
            var itemCategoryName1 = vendorName + " C1";
            var itemCategoryName2 = vendorName + " C2";

            return new ItemCategory[]
            {
                new ItemCategory(itemCategoryName1,
                    MakeItems(itemCategoryName1, Currencies[0], 42,
                    null, null)),
                new ItemCategory(itemCategoryName2,
                    MakeItems(itemCategoryName2, null, null,
                    BarterItems[1], 6))
            };
        }

        public static Item[] MakeItems(string itemCategoryName,
            Currency currency, int? currencyAmount,
            BarterItem barterItem, int? barterAmount)
        {
            var itemName = itemCategoryName + " I1";
            
            return new Item[]
            {
                new Item(itemName, currency, currencyAmount,
                    barterItem, barterAmount)
            };
        }
    }
}
