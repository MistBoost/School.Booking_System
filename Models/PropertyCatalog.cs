using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private readonly string Bordersprefix = "../Images/SkiResorts/BordersLodge/";
        private readonly string Ritzprefix = "../Images/SkiResorts/RitzCarltonBeaverCreek/";
        private readonly string Stprefix = "../Images/SkiResorts/stjamesplace/";

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
                    }, "France", "Alpe d\'Huez",
                    new Dictionary<string, TypeOfApartment>()
                    {
                       
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
                    "Beaver Creek’s only all-suite hotel, Beaver Creek Lodge is surrounded by Beaver Creek’s world-class slopes, and just steps away from the Strawberry Park Express Lift and Centennial Express Lift. Guests will enjoy staying in one of the spacious 71 ski in ski out, 1 bedroom suites .",
                    new List<string>()
                    {
                        BeaverPrefix + "beavercreek_beavercreeklodge1.jpg",
                        BeaverPrefix + "beavercreek_beavercreeklodge6.jpg",
                        BeaverPrefix + "beavercreek_beavercreeklodge7.jpg",
                        BeaverPrefix + "beavercreek_beavercreeklodge10.jpg",
                        BeaverPrefix + "beavercreek_beavercreeklodge2.jpg",
                        BeaverPrefix + "beavercreek_beavercreeklodge3.jpg",
                        BeaverPrefix + "beavercreek_beavercreeklodge4.jpg"
                    }, "", "chamonix",
                    new Dictionary<string, TypeOfApartment>()
                    {
                       
                        
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
                        harischprefix + "kit_hotelweisses9.jpg",
                        harischprefix + "kit_hotelweisses2.jpg",
                        harischprefix + "kit_hotelweisses5.jpg"

                    }, " ", "FLAINE",
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
                        hayattprefix + "jacksonhole_hotelterra8.jpg",
                    },"", "LES ARCS",
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
                    "The Pines Lodge A RockResort provides a unique blend of European Alpine charm and modern luxury Guests and their pooches are greeted by relaxation and rejuvenation from the moment they enter A diners delight the AAA Four Diamond Grouse Mountain Grill attracts guests and non-guests alike.",
                    new List<string>()
                    {
                        Pinesprefix + "beavercreek_pineslodge1.jpg",
                        Pinesprefix + "beavercreek_pineslodge2.jpg",
                        Pinesprefix + "beavercreek_pineslodge3.jpg",
                        Pinesprefix + "beavercreek_pineslodge4.jpg",
                        Pinesprefix + "beavercreek_pineslodge5.jpg",
                        Pinesprefix + "beavercreek_pineslodge8.jpg",
                        Pinesprefix + "beavercreek_pineslodge9.jpg",
                    },"", "MORZINE",
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
                ),

                new Property("CHARET AT BEAVER CREEK", "Providing exceptional convenience, the Charter offers ski in ski out access, and is within walking distance of the Bavarian-style Beaver Creek Village. Recognized by Condé Nast as one of the \"Top 50 Ski Hotels in the US and Canada\" in 2010, this European-inspired property provides lodge rooms, which sleep up to four guests" ,
                new List<string>()
                    {
                        charterPrefix + "ch.jpg",
                        charterPrefix + "ch1.jpg",
                        charterPrefix + "ch2.jpg",
                        charterPrefix + "ch3.jpg",
                        charterPrefix + "ch4.jpg",
                        charterPrefix + "ch5.jpg",
                        charterPrefix + "ch6.jpg",
                    }, "" , "" ,
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
                
                ) ,

                new Property("BORDERS LODGE" , "The elegant accommodations at The Borders Lodge provide ski in ski out access to the Elkhorn Lift at Beaver Creek Ski Resort. In addition to enjoying convenience to the slopes, guests of Borders Lodge can take in gorgeous views of the resort to the south and the rolling, snowy fairways of the Beaver Creek Golf Course to the north.\r\n" , new List<string>()
                {
                    Bordersprefix + "bc_borderslodge1_wynbcvl.jpg",
                    Bordersprefix + "bc_borderslodge10_wynbcvl.jpg",
                    Bordersprefix + "bc_borderslodge2_wynbcvl.jpg",
                    Bordersprefix + "bc_borderslodge3_wynbcvl.jpg",
                    Bordersprefix + "bc_borderslodge4_wynbcvl.jpg",
                    Bordersprefix + "bc_borderslodge5_wynbcvl.jpg",
                    Bordersprefix + "bc_borderslodge6_wynbcvl.jpg",
                } , "" , "" , new Dictionary<string, TypeOfApartment>()
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
                  )  ,
            new Property("RITZ CARLTON BEAVER CREEK", "Inspired by the beautiful lodges of the National Park System, The Ritz Carlton Beaver Creek exudes authentic Rocky Mountain luxury. Nestled in the exclusive mountain village of Bachelor Gulch on Beaver Creek ski resort, the Ritz-Carlton, Bachelor Gulch is an AAA Five Diamond property, which offers a highly lauded ski in ski out experience. \r\n" , new List<string>()
            {
                Ritzprefix + "bc_ritzcarltonbachelorgulch1_ritzbach.jpg",
                Ritzprefix + "bc_ritzcarltonbachelorgulch10_ritzbach.jpg",
                Ritzprefix + "bc_ritzcarltonbachelorgulch2_ritzbach.jpg",
                Ritzprefix + "bc_ritzcarltonbachelorgulch3_ritzbach.jpg",
                Ritzprefix + "bc_ritzcarltonbachelorgulch6_ritzbach.jpg",
                Ritzprefix + "bc_ritzcarltonbachelorgulch7_ritzbach.jpg",
                Ritzprefix + "bc_ritzcarltonbachelorgulch9_ritzbach.jpg",
            } ,"","", new Dictionary<string, TypeOfApartment>()
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
                
            }),
            new Property("St James Place", "Located in the heart of Beaver Creek Village, St. James Place provides easy access to the slopes and Beaver Creek Village’s shopping plaza, restaurants and the year-round ice skating rink. Accommodations range from 1 to 4 bedroom condominiums. \r\n" , 
            new List<string>()
            {
                Stprefix + "beavercreek_stjamesplace1_vrbc.jpg",
                Stprefix + "beavercreek_stjamesplace2_vrbc.jpg",
                Stprefix + "beavercreek_stjamesplace3_vrbc.jpg",
                Stprefix + "beavercreek_stjamesplace4_vrbc.jpg",
                Stprefix + "beavercreek_stjamesplace5_vrbc.jpg",
                Stprefix + "beavercreek_stjamesplace6_vrbc.jpg",
                Stprefix + "beavercreek_stjamesplace7_vrbc.jpg",

            }, "", "" , new Dictionary<string, TypeOfApartment>()
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
                
            }  )

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

