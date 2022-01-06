using System;

namespace XIVCurrencyClasses
{
    // Sample game data for testing purposes
    public static class TestData
    {
        /*public static Location[] Locations { get; set; } = new Location[]
        {
            new Location
            (
                "L1",
                new Vendor[]
                {
                    new Vendor
                    (
                        "L1 V1",
                        new ItemCategory[]
                        {
                            new ItemCategory
                            (
                                "L1 V1 C1",
                                new Item[]
                                {
                                    new Item
                                    (
                                        "L1 V1 C1 I1",
                                        Currencies[0],
                                        350,
                                        null,
                                        null
                                    ),
                                    new Item
                                    (
                                        "L1 V1 C1 I2",
                                        Currencies[1],
                                        42,
                                        null,
                                        null
                                    )
                                }
                            ),
                            new ItemCategory
                            (
                                "L1 V1 C2",
                                new Item[]
                                {
                                    new Item
                                    (
                                        "L1 V1 C2 I1",
                                        Currencies[0],
                                        350,
                                        null,
                                        null
                                    ),
                                    new Item
                                    (
                                        "L1 V1 C2 I2",
                                        Currencies[1],
                                        42,
                                        null,
                                        null
                                    )
                                }
                            )
                        }
                    ),
                    new Vendor
                    (
                        "L1 V2",
                        new ItemCategory[]
                        {
                            new ItemCategory
                            (
                                "L1 V2 C1",
                                new Item[]
                                {
                                    new Item
                                    (
                                        "L1 V2 C1 I1",
                                        Currencies[0],
                                        350,
                                        null,
                                        null
                                    ),
                                    new Item
                                    (
                                        "L1 V2 C1 I2",
                                        Currencies[1],
                                        42,
                                        null,
                                        null
                                    )
                                }
                            ),
                            new ItemCategory
                            (
                                "L1 V2 C2",
                                new Item[]
                                {
                                    new Item
                                    (
                                        "L1 V2 C2 I1",
                                        Currencies[0],
                                        350,
                                        null,
                                        null
                                    ),
                                    new Item
                                    (
                                        "L1 V2 C2 I2",
                                        Currencies[1],
                                        42,
                                        null,
                                        null
                                    )
                                }
                            )
                        }
                    )
                }
            ),
            new Location
            (
                "L2",
                new Vendor[]
                {
                    new Vendor
                    (
                        "L2 V1",
                        new ItemCategory[]
                        {
                            new ItemCategory
                            (
                                "L2 V1 C1",
                                new Item[]
                                {
                                    new Item
                                    (
                                        "L2 V1 C1 I1",
                                        Currencies[0],
                                        350,
                                        null,
                                        null
                                    ),
                                    new Item
                                    (
                                        "L2 V1 C1 I2",
                                        Currencies[1],
                                        42,
                                        null,
                                        null
                                    )
                                }
                            ),
                            new ItemCategory
                            (
                                "L2 V1 C2",
                                new Item[]
                                {
                                    new Item
                                    (
                                        "L2 V1 C2 I1",
                                        Currencies[0],
                                        350,
                                        null,
                                        null
                                    ),
                                    new Item
                                    (
                                        "L2 V1 C2 I2",
                                        Currencies[1],
                                        42,
                                        null,
                                        null
                                    )
                                }
                            )
                        }
                    ),
                    new Vendor
                    (
                        "L2 V2",
                        new ItemCategory[]
                        {
                            new ItemCategory
                            (
                                "L2 V2 C1",
                                new Item[]
                                {
                                    new Item
                                    (
                                        "L2 V2 C1 I1",
                                        Currencies[0],
                                        350,
                                        null,
                                        null
                                    ),
                                    new Item
                                    (
                                        "L2 V2 C1 I2",
                                        Currencies[1],
                                        42,
                                        null,
                                        null
                                    )
                                }
                            ),
                            new ItemCategory
                            (
                                "L2 V2 C2",
                                new Item[]
                                {
                                    new Item
                                    (
                                        "L2 V2 C2 I1",
                                        Currencies[0],
                                        350,
                                        null,
                                        null
                                    ),
                                    new Item
                                    (
                                        "L2 V2 C2 I2",
                                        Currencies[1],
                                        42,
                                        null,
                                        null
                                    )
                                }
                            )
                        }
                    )
                }
            )
        };*/

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
                null,
                null,
                BarterItems[0],
                6
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
