using System;

namespace XIVCurrencyClasses
{
    // Sample game data for testing purposes
    public static class TestData
    {
        public static Location[] Locations { get; set; } =
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
        };
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
        public static BarterItem[] BarterItems { get; set; } =
            new BarterItem[]
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
    }
}
