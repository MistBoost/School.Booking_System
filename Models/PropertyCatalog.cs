using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using School.OnlineBookingSystem.Common;

namespace School.OnlineBookingSystem.Models
{
    public class PropertyCatalog : Catalog<Property>
    {
        private readonly string TownPointePrefix = "../Images/SkiResorts/TownPointe/";
        private readonly string BeaverPrefix = "../Images/SkiResorts/BeaverCreekLodge/";
        private readonly string charterPrefix = "../Images/SkiResorts/CharetatBeaverCreek/";
        private readonly string harischprefix = "../Images/SkiResorts/HarischHotelWeissesRossl/";
        private readonly string hayattprefix = "../Images/SkiResorts/ElkhornLodge/";
        private readonly string Pinesprefix = "../Images/SkiResorts/PinesLodgeARockResort/";

        public PropertyCatalog()
        {
            FilePath = "properties_data.json";
            //            LoadCollection();

            Collection = new ObservableCollection<Property>()
            {
                new Property("TOWN POINTE",
                    "Town Pointe Condominiums offer the utmost in location nestled at the base of historic Main Street in Park City Town Pointe also offers style and amenities Conveniently located it is just a short walk from the Town Lift where the guests can catch a chairlift and be on the slopes of Park City Mountain Resort in a matter of minutes. \r\n\r\nDirect access to Main Street and Old Town by way of the pedestrian path",
                    new List<string>()
                    {
                        TownPointePrefix + "parkcity_townpointe1.jpg",
                        TownPointePrefix + "parkcity_townpointe2.jpg",
                        TownPointePrefix + "parkcity_townpointe3.jpg",
                        TownPointePrefix + "parkcity_townpointe4.jpg ",
                        TownPointePrefix + "parkcity_townpointe5.jpg",
                        TownPointePrefix + "parkcity_townpointe6.jpg",
                        TownPointePrefix + "parkcity_townpointe7.jpg"
                    }, "Alpe d\'Huez",
                    new Dictionary<string, TypeOfApartment>()
                    {
                        {
                            "Luxury Room",
                            new TypeOfApartment("LX", 12, 50.7f, 7,
                                "This property is 11 minutes walk from the beach. These spacious modern villas each have a private outdoor pool and garden with a barbecue area. Located 100 m from Lanzarote’s Rubicon Marina, Villas Puerto Rubicon offer free on-site parking. Featuring tiled floors and a fan, each villa has a living room with satellite TV, sofa, CD and DVD player. The bathroom comes with a hairdryer, and the well-equipped kitchen includes a washing machine and dishwasher. Guests will receive a free welcome pack on arrival including tea, coffee, juice, milk, water, and biscuits. Luggage storage is available at Villas Puerto Rubicon and there is a tour desk. Playa Blanca Beach and Hesperia Playa Dorada Golf Club are a 10-minute walk away. This property is also rated for the best value in Playa Blanca! Guests are getting more for their money when compared to other properties in this city. We speak your language!")
                        },
                        {
                            "Single Room",
                            new TypeOfApartment("SR", 52, 25.45f, 2,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },
                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 37.99f, 2,
                                "You will live in a amazing double room. It is perfect for family!")
                        }
                    },
                    new Dictionary<string, string>()
                    {
                    }
                ),
                new Property("BEAVER CREEK LODGE",
                    "Beaver Creek’s only all-suite hotel, Beaver Creek Lodge is surrounded by Beaver Creek’s world-class slopes, and just steps away from the Strawberry Park Express Lift and Centennial Express Lift. Guests will enjoy staying in one of the spacious 71 ski in ski out, 1 bedroom suites, which offer upscale touches like pillow-top bedding",
                    new List<string>()
                    {
                        BeaverPrefix + "beavercreek_beavercreeklodge1.jpg",
                        BeaverPrefix + "beavercreek_beavercreeklodge6.jpg",
                        BeaverPrefix + "beavercreek_beavercreeklodge7.jpg",
                        BeaverPrefix + "beavercreek_beavercreeklodge10.jpg",
                        BeaverPrefix + "beavercreek_beavercreeklodge2.jpg",
                        BeaverPrefix + "beavercreek_beavercreeklodge3.jpg",
                        BeaverPrefix + "beavercreek_beavercreeklodge4.jpg"
                    }, "chamonix",
                    new Dictionary<string, TypeOfApartment>()
                    {
                        {
                            "Luxury Room",
                            new TypeOfApartment("LX", 12, 50.7f, 7,
                                "This property is 11 minutes walk from the beach. These spacious modern villas each have a private outdoor pool and garden with a barbecue area. Located 100 m from Lanzarote’s Rubicon Marina, Villas Puerto Rubicon offer free on-site parking. Featuring tiled floors and a fan, each villa has a living room with satellite TV, sofa, CD and DVD player. The bathroom comes with a hairdryer, and the well-equipped kitchen includes a washing machine and dishwasher. Guests will receive a free welcome pack on arrival including tea, coffee, juice, milk, water, and biscuits. Luggage storage is available at Villas Puerto Rubicon and there is a tour desk. Playa Blanca Beach and Hesperia Playa Dorada Golf Club are a 10-minute walk away. This property is also rated for the best value in Playa Blanca! Guests are getting more for their money when compared to other properties in this city. We speak your language!")
                        },
                        {
                            "Single Room",
                            new TypeOfApartment("SR", 52, 25.45f, 2,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },
                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 37.99f, 2,
                                "You will live in a amazing double room. It is perfect for family!")
                        }
                    },
                    new Dictionary<string, string>()
                    {
                    }
                ),

                new Property("HARISCH HOTEL WEISSES ROSSL",
                    " Meeting the high demands of fine dining you will delight in the culinary creations of one of two restaurants For wine enthusiasts the Hotel Weisses Rssl offers a historic wine cellar built in the 15th century",
                    new List<string>()
                    {
                        harischprefix + "kit_hotelweisses1.jpg",
                        harischprefix + "kit_hotelweisses6.jpg",
                        harischprefix + "kit_hotelweisses7.jpg",
                        harischprefix + "kit_hotelweisses8.jpg",
                        harischprefix + "kit_hotelweisse9.jpg",
                        harischprefix + "kit_hotelweisses2.jpg",
                        harischprefix + "kit_hotelweisses5.jpg"

                    }, "FLAINE",
                    new Dictionary<string, TypeOfApartment>()
                    {
                        {
                            "Luxury Room",
                            new TypeOfApartment("LX", 15, 50.7f, 7,
                                "This property is 11 minutes walk from the beach. These spacious modern villas each have a private outdoor pool and garden with a barbecue area. Located 100 m from Lanzarote’s Rubicon Marina, Villas Puerto Rubicon offer free on-site parking. Featuring tiled floors and a fan, each villa has a living room with satellite TV, sofa, CD and DVD player. The bathroom comes with a hairdryer, and the well-equipped kitchen includes a washing machine and dishwasher. Guests will receive a free welcome pack on arrival including tea, coffee, juice, milk, water, and biscuits. Luggage storage is available at Villas Puerto Rubicon and there is a tour desk. Playa Blanca Beach and Hesperia Playa Dorada Golf Club are a 10-minute walk away. This property is also rated for the best value in Playa Blanca! Guests are getting more for their money when compared to other properties in this city. We speak your language!")
                        },
                        {
                            "Single Room",
                            new TypeOfApartment("SR", 52, 25.45f, 2,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },
                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 37.99f, 2,
                                "You will live in a amazing double room. It is perfect for family!")
                        }
                    },
                    new Dictionary<string, string>()
                    {
                    }
                ),

                new Property("Elkhorn Lodge",
                    "At the Elkhorn Lodge simply walk out your door and catch the Elkhorn Lift Chair 14 for a true ski-in and ski-out experience from mid-December through March",
                    new List<string>()
                    {
                        hayattprefix + "beavercreek_elkhornlodge1.jpg",
                        hayattprefix + "beavercreek_elkhornlodge2.jpg",
                        hayattprefix + "beavercreek_elkhornlodge3.jpg",
                        hayattprefix + "beavercreek_elkhornlodge4.jpg",
                        hayattprefix + "beavercreek_elkhornlodge5.jpg",
                        hayattprefix + "beavercreek_elkhornlodge6.jpg",
                    }, "LES ARCS",
                    new Dictionary<string, TypeOfApartment>()
                    {
                        {
                            "Luxury Room",
                            new TypeOfApartment("LX", 12, 50.7f, 7,
                                "This property is 11 minutes walk from the beach. These spacious modern villas each have a private outdoor pool and garden with a barbecue area. Located 100 m from Lanzarote’s Rubicon Marina, Villas Puerto Rubicon offer free on-site parking. Featuring tiled floors and a fan, each villa has a living room with satellite TV, sofa, CD and DVD player. The bathroom comes with a hairdryer, and the well-equipped kitchen includes a washing machine and dishwasher. Guests will receive a free welcome pack on arrival including tea, coffee, juice, milk, water, and biscuits. Luggage storage is available at Villas Puerto Rubicon and there is a tour desk. Playa Blanca Beach and Hesperia Playa Dorada Golf Club are a 10-minute walk away. This property is also rated for the best value in Playa Blanca! Guests are getting more for their money when compared to other properties in this city. We speak your language!")
                        },
                        {
                            "Single Room",
                            new TypeOfApartment("SR", 52, 25.45f, 2,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },
                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 37.99f, 2,
                                "You will live in a amazing double room. It is perfect for family!")
                        }
                    },
                    new Dictionary<string, string>()
                    {
                    }
                ),

                new Property("PINES LODGE A ROCKRESORT",
                    "The Pines Lodge A RockResort provides a unique blend of European Alpine charm and modern luxury Guests and their pooches are greeted by relaxation and rejuvenation from the moment they enter A diners delight the AAA Four Diamond Grouse Mountain Grill attracts guests and non-guests alike, and four-legged guests will enjoy noshing on the Pines’ homemade dog treats",
                    new List<string>()
                    {
                        Pinesprefix + "beavercreek_pineslodge1.jpg",
                        Pinesprefix + "beavercreek_pineslodge2.jpg",
                        Pinesprefix + "beavercreek_pineslodge3.jpg",
                        Pinesprefix + "beavercreek_pineslodge4.jpg",
                        Pinesprefix + "beavercreek_pineslodge5.jpg",
                        Pinesprefix + "beavercreek_pineslodge8.jpg",
                        Pinesprefix + "beavercreek_pineslodge9.jpg",
                    }, "MORZINE",
                    new Dictionary<string, TypeOfApartment>()
                    {
                        {
                            "Luxury Room",
                            new TypeOfApartment("LX", 12, 50.7f, 7,
                                "This property is 11 minutes walk from the beach. These spacious modern villas each have a private outdoor pool and garden with a barbecue area. Located 100 m from Lanzarote’s Rubicon Marina, Villas Puerto Rubicon offer free on-site parking. Featuring tiled floors and a fan, each villa has a living room with satellite TV, sofa, CD and DVD player. The bathroom comes with a hairdryer, and the well-equipped kitchen includes a washing machine and dishwasher. Guests will receive a free welcome pack on arrival including tea, coffee, juice, milk, water, and biscuits. Luggage storage is available at Villas Puerto Rubicon and there is a tour desk. Playa Blanca Beach and Hesperia Playa Dorada Golf Club are a 10-minute walk away. This property is also rated for the best value in Playa Blanca! Guests are getting more for their money when compared to other properties in this city. We speak your language!")
                        },
                        {
                            "Single Room",
                            new TypeOfApartment("SR", 52, 25.45f, 2,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },
                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 27.99f, 2,
                                "You will live in a amazing double room. It is perfect for family!")
                        }
                    },
                    new Dictionary<string, string>()
                    {
                    }
                )
            };

            foreach (var prop in Collection)
            {
                Dictionary<string, string> apartDic = new Dictionary<string, string>();

                float minPrice = 0;
                foreach (KeyValuePair<string, TypeOfApartment> typeOfApartment in prop.TypesOfApartments)
                {
                    if (minPrice == 0)
                    {
                        minPrice = typeOfApartment.Value.Price;
                    }
                    for (int i = 0; i < typeOfApartment.Value.NumberOfApartments; i++)
                    {
                        string Id = CreateID(typeOfApartment.Value.Initial, i);
                        apartDic.Add(Id, typeOfApartment.Key);
                        if (minPrice > typeOfApartment.Value.Price)
                        {
                            minPrice = typeOfApartment.Value.Price;
                        }
                    }
                    prop.MinPrice = minPrice;

                    prop.ApartmentDic = apartDic;
                }
            }
            SaveCollection();
        }

        private string CreateID (string _apartmentTypeInitial, int _nr)
            {
                string _nrString;
                if (_nr < 10)
                {
                    _nrString = "00" + _nr;
                }
                else if (_nr < 100 && _nr >= 10)
                {
                    _nrString = "0" + _nr;
                }
                else _nrString = _nr.ToString();

                string _Id = $"{_apartmentTypeInitial}{_nrString}";
                return _Id;
            }

        }
    }

