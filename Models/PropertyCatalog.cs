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
        private readonly string Ritzprefix = "../Images/SkiResorts/RittzCarltonBeaverCreek/";
        private readonly string Stprefix = "../Images/SkiResorts/stjames/";
        private readonly string Kohprefix = "../Images/SkiResorts/KohNorHotel/";
        private readonly string akiprefix = "../Images/Grit/akhil'svilla/";
        private readonly string emiprefix = "../Images/Grit/Emil'svilla/";
        private readonly string harprefix = "../Images/Grit/Harman'svilla/";
        private readonly string jakprefix = "../Images/Grit/Jakub'svilla/";
        private readonly string julprefix = "../Images/Grit/Julius'svilla/";
        private readonly string Marprefix = "../Images/Grit/Marcin'svilla/";
        private readonly string petprefix = "../Images/Grit/Peter'sVilla/";
        private readonly string rusprefix = "../Images/Grit/Rushika'sVilla/";
        private readonly string rumprefix = "../Images/Grit/rusmus'sVilla/";
        private readonly string tanprefix = "../Images/Grit/tansu'svilla/";







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
                            "Luxury Room",
                            new TypeOfApartment("LX", 12, 500.7M, 7,
                                "This property is 11 minutes walk from the beach. These spacious modern villas each have a private outdoor pool and garden with a barbecue area.")
                        },
                        {
                            "Single Room",
                            new TypeOfApartment("SR", 52, 25.45M, 2,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },
                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 37.99M, 2,
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
                    }, "France", "Chamonix",
                    new Dictionary<string, TypeOfApartment>()
                    {
                         {
                            "Luxury Room",
                            new TypeOfApartment("Lk", 20, 400.7M, 7,
                                "This property is 11 minutes walk from the Chamonix Airport. These spacious modern villas each have a private outdoor pool and garden with a barbecue area. Located 100 m from Lanzarote’s Rubicon Marina, Villas Puerto Rubicon offer free on-site parking. Featuring tiled floors and a fan, each villa has a living room with satellite TV, sofa, CD and DVD player. The bathroom comes with a hairdryer, and the well-equipped kitchen includes a washing machine and dishwasher. Guests will receive a free welcome pack on arrival including tea, coffee, juice, milk, water, and biscuits. Luggage storage is available at Villas Puerto Rubicon and there is a tour desk. Playa Blanca Beach and Hesperia Playa Dorada Golf Club are a 10-minute walk away. This property is also rated for the best value in Playa Blanca! Guests are getting more for their money when compared to other properties in this city. We speak your language!")
                        },
                          {
                            "Single Room",
                            new TypeOfApartment("kR", 32, 170.45M, 3,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },

                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 37.99M, 2,
                                "You will live in a amazing double room. It is perfect for family!")
                        }
                    },
                    new Dictionary<string, string>()
                    {
                    }
                ),

                new Property("HARISCH HOTEL WEISSES",
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

                    }, "Denmark", "Bornholm",
                    new Dictionary<string, TypeOfApartment>()
                    {
                        {
                            "Luxury Room",
                            new TypeOfApartment("LX", 12, 50.7M, 7,
                                "This property is 11 minutes walk from the beach. These spacious modern villas each have a private outdoor pool and garden with a barbecue area. Located 100 m from Lanzarote’s Rubicon Marina, Villas Puerto Rubicon offer free on-site parking. Featuring tiled floors and a fan, each villa has a living room with satellite TV, sofa, CD and DVD player. The bathroom comes with a hairdryer, and the well-equipped kitchen includes a washing machine and dishwasher. Guests will receive a free welcome pack on arrival including tea, coffee, juice, milk, water, and biscuits. Luggage storage is available at Villas Puerto Rubicon and there is a tour desk. Playa Blanca Beach and Hesperia Playa Dorada Golf Club are a 10-minute walk away. This property is also rated for the best value in Playa Blanca! Guests are getting more for their money when compared to other properties in this city. We speak your language!")
                        },
                        {
                            "Single Room",
                            new TypeOfApartment("SR", 52, 25.45M, 2,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },
                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 37.99M, 2,
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
                    },"Denmark", "Kolding",
                    new Dictionary<string, TypeOfApartment>()
                    {
                        {
                            "Luxury Room",
                            new TypeOfApartment("LX", 12, 50.7M, 7,
                                "This property is 11 minutes walk from the beach. These spacious modern villas each have a private outdoor pool and garden with a barbecue area. Located 100 m from Lanzarote’s Rubicon Marina, Villas Puerto Rubicon offer free on-site parking. Featuring tiled floors and a fan, each villa has a living room with satellite TV, sofa, CD and DVD player. The bathroom comes with a hairdryer, and the well-equipped kitchen includes a washing machine and dishwasher. Guests will receive a free welcome pack on arrival including tea, coffee, juice, milk, water, and biscuits. Luggage storage is available at Villas Puerto Rubicon and there is a tour desk. Playa Blanca Beach and Hesperia Playa Dorada Golf Club are a 10-minute walk away. This property is also rated for the best value in Playa Blanca! Guests are getting more for their money when compared to other properties in this city. We speak your language!")
                        },
                        {
                            "Single Room",
                            new TypeOfApartment("SR", 52, 25.45M, 2,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },
                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 37.99M, 2,
                                "You will live in a amazing double room. It is perfect for family!")
                        }
                    },
                    new Dictionary<string, string>()
                    {
                    }
                ),

                new Property("PINES LODGE ",
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
                    },"Slovakia", "Chopok",
                    new Dictionary<string, TypeOfApartment>()
                    {
                        {
                            "Luxury Room",
                            new TypeOfApartment("LX", 12, 50.7M, 7,
                                "This property is 11 minutes walk from the beach. These spacious modern villas each have a private outdoor pool and garden with a barbecue area. Located 100 m from Lanzarote’s Rubicon Marina, Villas Puerto Rubicon offer free on-site parking. Featuring tiled floors and a fan, each villa has a living room with satellite TV, sofa, CD and DVD player. The bathroom comes with a hairdryer, and the well-equipped kitchen includes a washing machine and dishwasher. Guests will receive a free welcome pack on arrival including tea, coffee, juice, milk, water, and biscuits. Luggage storage is available at Villas Puerto Rubicon and there is a tour desk. Playa Blanca Beach and Hesperia Playa Dorada Golf Club are a 10-minute walk away. This property is also rated for the best value in Playa Blanca! Guests are getting more for their money when compared to other properties in this city. We speak your language!")
                        },
                        {
                            "Single Room",
                            new TypeOfApartment("SR", 52, 25.45M, 2,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },
                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 27.99M, 2,
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
                    }, "Slovakia" , "Tatranská Lomnica " ,
                new Dictionary<string, TypeOfApartment>()
                {
                     {
                            "Luxury Room",
                            new TypeOfApartment("LX", 12, 50.7M, 7,
                                "This property is 11 minutes walk from the beach. These spacious modern villas each have a private outdoor pool and garden with a barbecue area. Located 100 m from Lanzarote’s Rubicon Marina, Villas Puerto Rubicon offer free on-site parking. Featuring tiled floors and a fan, each villa has a living room with satellite TV, sofa, CD and DVD player. The bathroom comes with a hairdryer, and the well-equipped kitchen includes a washing machine and dishwasher. Guests will receive a free welcome pack on arrival including tea, coffee, juice, milk, water, and biscuits. Luggage storage is available at Villas Puerto Rubicon and there is a tour desk. Playa Blanca Beach and Hesperia Playa Dorada Golf Club are a 10-minute walk away. This property is also rated for the best value in Playa Blanca! Guests are getting more for their money when compared to other properties in this city. We speak your language!")
                        },
                        {
                            "Single Room",
                            new TypeOfApartment("SR", 52, 25.45M, 2,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },
                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 27.99M, 2,
                                "You will live in a amazing double room. It is perfect for family!")
                        }
                }, 
                new Dictionary<string, string>()
                {
                    
                }
                
                ) ,

                new Property("BORDERS LODGE" , "The elegant accommodations at The Borders Lodge provide ski in ski out access to the Elkhorn Lift at Beaver Creek Ski Resort. In addition to enjoying convenience to the slopes, guests of Borders Lodge can take in gorgeous views of the resort to the south and the rolling, snowy fairways of the Beaver Creek .\r\n" , new List<string>()
                {
                    Bordersprefix + "bc_borderslodge1_wynbcvl.jpg",
                    Bordersprefix + "bc_borderslodge10_wynbcvl.jpg",
                    Bordersprefix + "bc_borderslodge2_wynbcvl.jpg",
                    Bordersprefix + "bc_borderslodge3_wynbcvl.jpg",
                    Bordersprefix + "bc_borderslodge4_wynbcvl.jpg",
                    Bordersprefix + "bc_borderslodge5_wynbcvl.jpg",
                    Bordersprefix + "bc_borderslodge6_wynbcvl.jpg",
                } , "Lithuania" , "Vilnius" , new Dictionary<string, TypeOfApartment>()
                {
                   {
                            "Luxury Room",
                            new TypeOfApartment("LX", 12, 50.7M, 7,
                                             "This property is 11 minutes walk from the beach. These spacious modern villas each have a private outdoor pool and garden with a barbecue area. Located 100 m from Lanzarote’s Rubicon Marina, Villas Puerto Rubicon offer free on-site parking. Featuring tiled floors and a fan.")
                        },
                        {
                            "Single Room",
                            new TypeOfApartment("SR", 52, 25.45M, 2,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },
                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 27.99M, 2,
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
            } ,"Lithuania","Utena", new Dictionary<string, TypeOfApartment>()
            {
                 {
                            "Luxury Room",
                            new TypeOfApartment("LX", 12, 50.7M, 7,
                                "This property is 11 minutes walk from the beach. These spacious modern villas each have a private outdoor pool and garden with a barbecue area. Located 100 m from Lanzarote’s Rubicon Marina, Villas Puerto Rubicon offer free on-site parking. Featuring tiled floors and a fan, each villa has a living room with satellite TV, sofa, CD and DVD player. The bathroom comes with a hairdryer, and the well-equipped kitchen includes a washing machine and dishwasher. Guests will receive a free welcome pack on arrival including tea, coffee, juice, milk, water, and biscuits. Luggage storage is available at Villas Puerto Rubicon and there is a tour desk. Playa Blanca Beach and Hesperia Playa Dorada Golf Club are a 10-minute walk away. This property is also rated for the best value in Playa Blanca! Guests are getting more for their money when compared to other properties in this city. We speak your language!")
                        },
                        {
                            "Single Room",
                            new TypeOfApartment("SR", 52, 25.45M, 2,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },
                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 27.99M, 2,
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

            }, "India", "Himachal Pradesh" , new Dictionary<string, TypeOfApartment>()
            {
                 {
                            "Luxury Room",
                            new TypeOfApartment("LX", 12, 50.7M, 7,
                                "This property is 11 minutes walk from the beach. These spacious modern villas each have a private outdoor pool and garden with a barbecue area. Located 100 m from Lanzarote’s Rubicon Marina, Villas Puerto Rubicon offer free on-site parking. Featuring tiled floors and a fan, each villa has a living room with satellite TV, sofa, CD and DVD player. The bathroom comes with a hairdryer, and the well-equipped kitchen includes a washing machine and dishwasher. Guests will receive a free welcome pack on arrival including tea, coffee, juice, milk, water, and biscuits. Luggage storage is available at Villas Puerto Rubicon and there is a tour desk. Playa Blanca Beach and Hesperia Playa Dorada Golf Club are a 10-minute walk away. This property is also rated for the best value in Playa Blanca! Guests are getting more for their money when compared to other properties in this city. We speak your language!")
                        },
                        {
                            "Single Room",
                            new TypeOfApartment("SR", 52, 25.45M, 2,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },
                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 27.99M, 2,
                                "You will live in a amazing double room. It is perfect for family!")
                        }


            },
            new Dictionary<string, string>()
            {
                
            }  ),
            new Property("KOH I NOR HOTEL", "Nestled in the highest resort of the 3 Vallees ski area, the new Koh-i-Nor Hotel is located at the summit of Val Thorens. Inside you will find a unique experience with all the luxuries of a 5* hotel. The hotel boasts a panoramic terrace with views of the resort and local Alps, lounge bar with musical ambiance, and 3 restaurants" , new List<string>()
            {
                Kohprefix + "valthorens_kohlnorhotel1.jpg",
                Kohprefix + "valthorens_kohlnorhotel10.jpg",
                Kohprefix + "valthorens_kohlnorhotel4.jpg",
                Kohprefix + "valthorens_kohlnorhotel6.jpg",
                Kohprefix + "valthorens_kohlnorhotel7.jpg",
                Kohprefix + "valthorens_kohlnorhotel8.jpg",
                Kohprefix + "valthorens_kohlnorhotel9.jpg",
            } , "India" ,"Kausauli" , new Dictionary<string, TypeOfApartment>()
            {
                 {
                            "Luxury Room",
                            new TypeOfApartment("LX", 12, 50.7M, 7,
                                "This property is 11 minutes walk from the beach. These spacious modern villas each have a private outdoor pool and garden with a barbecue area. Located 100 m from Lanzarote’s Rubicon Marina, Villas Puerto Rubicon offer free on-site parking. Featuring tiled floors and a fan, each villa has a living room with satellite TV, sofa, CD and DVD player. The bathroom comes with a hairdryer, and the well-equipped kitchen includes a washing machine and dishwasher. Guests will receive a free welcome pack on arrival including tea, coffee, juice, milk, water, and biscuits. Luggage storage is available at Villas Puerto Rubicon and there is a tour desk. Playa Blanca Beach and Hesperia Playa Dorada Golf Club are a 10-minute walk away. This property is also rated for the best value in Playa Blanca! Guests are getting more for their money when compared to other properties in this city. We speak your language!")
                        },
                        {
                            "Single Room",
                            new TypeOfApartment("SR", 52, 25.45M, 2,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },
                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 27.99M, 2,
                                "You will live in a amazing double room. It is perfect for family!")
                        }

            }, new Dictionary<string, string>()
            {
                
            }   ), 
            new Property("AKHIL'S VILLA","Paris 19th - Buttes Chaumont - This ingeniously planned apartment of 63 m2 is located on the 10th floor and has a magnificent terrace of 11 m2 right above the Buttes Chaumont parc and an incredible panoramic view over Paris.", new List<string>()
            {
                akiprefix + "imagereader.jpg",
                akiprefix + "imagereader2.jpg",
                akiprefix + "imagereader3.jpg",
                akiprefix + "imagereader4.jpg",
                akiprefix + "imagereader5.jpg",
                akiprefix + "imagereader6.jpg",
                akiprefix + "imagereader7.jpg",
            }, "Japan" ,"Hakuba" , new Dictionary<string, TypeOfApartment>()
            {
                {
                            "Luxury Room",
                            new TypeOfApartment("LX", 12, 50.7M, 7,
                                "This property is 11 minutes walk from the beach. These spacious modern villas each have a private outdoor pool and garden with a barbecue area. Located 100 m from Lanzarote’s Rubicon Marina, Villas Puerto Rubicon offer free on-site parking. Featuring tiled floors and a fan, each villa has a living room with satellite TV, sofa, CD and DVD player. The bathroom comes with a hairdryer, and the well-equipped kitchen includes a washing machine and dishwasher. Guests will receive a free welcome pack on arrival including tea, coffee, juice, milk, water, and biscuits. Luggage storage is available at Villas Puerto Rubicon and there is a tour desk. Playa Blanca Beach and Hesperia Playa Dorada Golf Club are a 10-minute walk away. This property is also rated for the best value in Playa Blanca! Guests are getting more for their money when compared to other properties in this city. We speak your language!")
                        },
                        {
                            "Single Room",
                            new TypeOfApartment("SR", 52, 25.45M, 2,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },
                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 27.99M, 2,
                                "You will live in a amazing double room. It is perfect for family!")
                        }
            }, new Dictionary<string, string>()
            {
                
            }  ),
            new Property("EMIL'S VILLA" , "Paris 5th - Latin Quarter/Sorbonne - This large studio of 36 m2 is located on the third floor out of six in an elegant Haussmann-style building. It has one large room facing south with natural light all day." , new List<string>()
            {
                  emiprefix + "imagereader.jpg",
                  emiprefix + "imagereader2.jpg",
                  emiprefix + "imagereader3.jpg",
                  emiprefix + "imagereader4.jpg",
                  emiprefix + "imagereader5.jpg",
                  emiprefix + "imagereader6.jpg",
                  emiprefix + "imagereader7.jpg",
            } , "Japan" , "Niseko" , new Dictionary<string, TypeOfApartment>()
            {
                 {
                            "Luxury Room",
                            new TypeOfApartment("LX", 12, 50.7M, 7,
                                "This property is 11 minutes walk from the beach. These spacious modern villas each have a private outdoor pool and garden with a barbecue area. Located 100 m from Lanzarote’s Rubicon Marina, Villas Puerto Rubicon offer free on-site parking. Featuring tiled floors and a fan, each villa has a living room with satellite TV, sofa, CD and DVD player. The bathroom comes with a hairdryer, and the well-equipped kitchen includes a washing machine and dishwasher. Guests will receive a free welcome pack on arrival including tea, coffee, juice, milk, water, and biscuits. Luggage storage is available at Villas Puerto Rubicon and there is a tour desk. Playa Blanca Beach and Hesperia Playa Dorada Golf Club are a 10-minute walk away. This property is also rated for the best value in Playa Blanca! Guests are getting more for their money when compared to other properties in this city. We speak your language!")
                        },
                        {
                            "Single Room",
                            new TypeOfApartment("SR", 52, 25.45M, 2,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },
                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 27.99M, 2,
                                "You will live in a amazing double room. It is perfect for family!")
                        }
            }, new Dictionary<string, string>()
            {
                
            }  ) ,
            new Property("HARMAN'S VILLA", "This 8-room apartment is on the 2nd floor of a luxurious 1930’s freestone building in the capital’s desirable Gros Caillou neighbourhood between les Invalides and the Eiffel Tower, and near rue Cler, the shops and schools", new List<string>()
            {
                harprefix + " (1).jpg",
                harprefix + " (2).jpg",
                harprefix + " (3).jpg",
                harprefix + " (4).jpg",
                harprefix + " (5).jpg",
                harprefix + " (6).jpg",
                harprefix + " (7).jpg",
            } , "China" , "Jilin" , new Dictionary<string, TypeOfApartment>()
            {
                  {
                            "Luxury Room",
                            new TypeOfApartment("LX", 12, 50.7M, 7,
                                "This property is 11 minutes walk from the beach. These spacious modern villas each have a private outdoor pool and garden with a barbecue area. Located 100 m from Lanzarote’s Rubicon Marina, Villas Puerto Rubicon offer free on-site parking. Featuring tiled floors and a fan, each villa has a living room with satellite TV, sofa, CD and DVD player. The bathroom comes with a hairdryer, and the well-equipped kitchen includes a washing machine and dishwasher. Guests will receive a free welcome pack on arrival including tea, coffee, juice, milk, water, and biscuits. Luggage storage is available at Villas Puerto Rubicon and there is a tour desk. Playa Blanca Beach and Hesperia Playa Dorada Golf Club are a 10-minute walk away. This property is also rated for the best value in Playa Blanca! Guests are getting more for their money when compared to other properties in this city. We speak your language!")
                        },
                        {
                            "Single Room",
                            new TypeOfApartment("SR", 52, 25.4M, 2,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },
                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 27.99M, 2,
                                "You will live in a amazing double room. It is perfect for family!")
                        }
            }, new Dictionary<string, string>()
            {
                
            }  ),
            new Property("JAKUB'S VILLA", "A substantial and impressive family home with stunning views, 9 hole golf course, guest house, B&B, restaurant and 2 swimming pools. The entire property enjoys a simply superb location and represents a unique offer.", new List<string>()
            {
                jakprefix + "imagereader.jpg",
                jakprefix + "imagereader2.jpg",
                jakprefix + "imagereader3.jpg",
                jakprefix + "imagereader4.jpg",
                jakprefix + "imagereader5.jpg",
                jakprefix + "imagereader6.jpg",
                jakprefix + "imagereader7.jpg",
            }, "China" , "Hebei" , new Dictionary<string, TypeOfApartment>()
            {
                {
                            "Luxury Room",
                            new TypeOfApartment("LX", 12, 50.7M, 7,
                                "This property is 11 minutes walk from the beach. These spacious modern villas each have a private outdoor pool and garden with a barbecue area. Located 100 m from Lanzarote’s Rubicon Marina, Villas Puerto Rubicon offer free on-site parking. Featuring tiled floors and a fan, each villa has a living room with satellite TV, sofa, CD and DVD player. The bathroom comes with a hairdryer, and the well-equipped kitchen includes a washing machine and dishwasher. Guests will receive a free welcome pack on arrival including tea, coffee, juice, milk, water, and biscuits. Luggage storage is available at Villas Puerto Rubicon and there is a tour desk. Playa Blanca Beach and Hesperia Playa Dorada Golf Club are a 10-minute walk away. This property is also rated for the best value in Playa Blanca! Guests are getting more for their money when compared to other properties in this city. We speak your language!")
                        },
                        {
                            "Single Room",
                            new TypeOfApartment("SR", 52, 25.45M, 2,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },
                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 27.99M, 2,
                                "You will live in a amazing double room. It is perfect for family!")
                        }
            }, new Dictionary<string, string>()
                {
                    
                }  
                ),
            new Property("JULIUS'S VILLA", "Close to shops and Cahors. Contemporary house in very good condition and well situated. Upstairs: hallway, living room opening onto a balcony and large terrace with open views, kitchen, 2 bedrooms, bathroom, toilet. On the ground floor: entrance hall, summer kitchen, 1 bedroom, boiler room, 1 room, 2 garages, terrace. Fenced and mature garden of 600 sqm " , new List<string>()
            {
                julprefix + "imagereader.jpg",
                julprefix + "imagereader2.jpg",
                julprefix + "imagereader3.jpg",
                julprefix + "imagereader4.jpg",
                julprefix + "imagereader5.jpg",
                julprefix + "imagereader6.jpg",
                julprefix + "imagereader7.jpg",

            } , "USA" , "Colorado " , new Dictionary<string, TypeOfApartment>()
            {
                 {
                            "Luxury Room",
                            new TypeOfApartment("LX", 12, 50.7M, 7,
                                "This property is 11 minutes walk from the beach. These spacious modern villas each have a private outdoor pool and garden with a barbecue area. Located 100 m from Lanzarote’s Rubicon Marina, Villas Puerto Rubicon offer free on-site parking. Featuring tiled floors and a fan, each villa has a living room with satellite TV, sofa, CD and DVD player. The bathroom comes with a hairdryer, and the well-equipped kitchen includes a washing machine and dishwasher. Guests will receive a free welcome pack on arrival including tea, coffee, juice, milk, water, and biscuits. Luggage storage is available at Villas Puerto Rubicon and there is a tour desk. Playa Blanca Beach and Hesperia Playa Dorada Golf Club are a 10-minute walk away. This property is also rated for the best value in Playa Blanca! Guests are getting more for their money when compared to other properties in this city. We speak your language!")
                        },
                        {
                            "Single Room",
                            new TypeOfApartment("SR", 52, 25.45M, 2,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },
                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 27.99M, 2,
                                "You will live in a amazing double room. It is perfect for family!")
                        }
            }, new Dictionary<string, string>()
            {
                
            }  ),
            new Property("MARCIN'S VILLA" ,"Beautiful 10th and 17th century Chateau located just 30 minutes from Cahors a town which is strategically situated in a loop of the curvaceous river Lot, surrounded by hills. To the north the roads lead straight to Paris, to the south straight to Toulouse and on to the " , new List<string>()
            {
                Marprefix + "1.jpg",
                Marprefix + "2.jpg",
                Marprefix + "3.jpg",
                Marprefix + "4.jpg",
                Marprefix + "5.jpg",
                Marprefix + "6.jpg",
                Marprefix + "7.jpg",
            } , "USA" , "Chicago" , new Dictionary<string, TypeOfApartment>()
            {
                        {   
                            "Luxury Room",
                            new TypeOfApartment("LX", 12, 50.7M, 7,
                                "This property is 11 minutes walk from the beach. These spacious modern villas each have a private outdoor pool and garden with a barbecue area. Located 100 m from Lanzarote’s Rubicon Marina, Villas Puerto Rubicon offer free on-site parking. Featuring tiled floors and a fan, each villa has a living room with satellite TV, sofa, CD and DVD player. The bathroom comes with a hairdryer, and the well-equipped kitchen includes a washing machine and dishwasher. Guests will receive a free welcome pack on arrival including tea, coffee, juice, milk, water, and biscuits. Luggage storage is available at Villas Puerto Rubicon and there is a tour desk. Playa Blanca Beach and Hesperia Playa Dorada Golf Club are a 10-minute walk away. This property is also rated for the best value in Playa Blanca! Guests are getting more for their money when compared to other properties in this city. We speak your language!")
                        },
                        {
                            "Single Room",
                            new TypeOfApartment("SR", 52, 25.45M, 2,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },
                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 27.99M, 2,
                                "You will live in a amazing double room. It is perfect for family!")
                        }
            }, new Dictionary<string, string>()
            {
                
            }  ),
            new Property("PETER'S VILLA" , "Propriete De PRESTIGE \r\nDemeure en L 240M² de plain pied entourée de terrasses et terrain arboré 3625m². \r\nEntrée, grand hall avec poêle granulé, Wc séparée, salles de bains en marbre, cuisine, salle de séjour/manger en Lavec très jolie cheminée " , new List<string>()
            {
                petprefix + "1.jpg",
                petprefix + "2.jpg",
                petprefix + "3.jpg",
                petprefix + "4.jpg",
                petprefix + "5.jpg",
                petprefix + "6.jpg",
                petprefix + "7.jpg",
            } , "Canada" , "Banff" , new Dictionary<string, TypeOfApartment>()
            {
                                 {
                            "Luxury Room",
                            new TypeOfApartment("LX", 12, 50.7M, 7,
                                "This property is 11 minutes walk from the beach. These spacious modern villas each have a private outdoor pool and garden with a barbecue area. Located 100 m from Lanzarote’s Rubicon Marina, Villas Puerto Rubicon offer free on-site parking. Featuring tiled floors and a fan, each villa has a living room with satellite TV, sofa, CD and DVD player. The bathroom comes with a hairdryer, and the well-equipped kitchen includes a washing machine and dishwasher. Guests will receive a free welcome pack on arrival including tea, coffee, juice, milk, water, and biscuits. Luggage storage is available at Villas Puerto Rubicon and there is a tour desk. Playa Blanca Beach and Hesperia Playa Dorada Golf Club are a 10-minute walk away. This property is also rated for the best value in Playa Blanca! Guests are getting more for their money when compared to other properties in this city. We speak your language!")
                        },
                        {
                            "Single Room",
                            new TypeOfApartment("SR", 52, 25.45M, 2,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },
                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 27.9M, 2,
                                "You will live in a amazing double room. It is perfect for family!")
                        }
            }, new Dictionary<string, string>()
            {
                
            } ),
           new Property("RUSHIKA'S VILLA" , "Property summary\r\nThis original round castle, from the Xiii century is classified Ismh. Located on a dominant position on the Lot valley. There are 4 towers and a donjon. Totaly restored. 650 m² of living area, with a possibility to develop it. There is all the modern comfort. Very authentic. Swimming pool, pool house, large garage 4/6 cars " , new List<string>()
           {
               rusprefix + "1.jpg",
               rusprefix + "2.jpg",
               rusprefix + "3.jpg",
               rusprefix + "4.jpg",
               rusprefix + "5.jpg",
               rusprefix + "6.jpg",
               rusprefix + "7.jpg",
           } , "Canada", "Toronto" , new Dictionary<string, TypeOfApartment>()
           {
              {
                            "Luxury Room",
                            new TypeOfApartment("LX", 12, 50.7M, 7,
                                "This property is 11 minutes walk from the beach. These spacious modern villas each have a private outdoor pool and garden with a barbecue area. Located 100 m from Lanzarote’s Rubicon Marina, Villas Puerto Rubicon offer free on-site parking. Featuring tiled floors and a fan, each villa has a living room with satellite TV, sofa, CD and DVD player. The bathroom comes with a hairdryer, and the well-equipped kitchen includes a washing machine and dishwasher. Guests will receive a free welcome pack on arrival including tea, coffee, juice, milk, water, and biscuits. Luggage storage is available at Villas Puerto Rubicon and there is a tour desk. Playa Blanca Beach and Hesperia Playa Dorada Golf Club are a 10-minute walk away. This property is also rated for the best value in Playa Blanca! Guests are getting more for their money when compared to other properties in this city. We speak your language!")
                        },
                        {
                            "Single Room",
                            new TypeOfApartment("SR", 52, 25.45M, 2,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },
                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 27.99M, 2,
                                "You will live in a amazing double room. It is perfect for family!")
                        }
           }, new Dictionary<string, string>()
           {
               
           }  ),
           new Property("RUSMUS'S VILLA" , "Big potential for this property group has about twenty kilometers from Cahors, in a quiet hamlet and in the hills overlooking a clearance. This set offers a house of 80 m with cellar. " , new List<string>()
           {
               rumprefix + "1.jpg",
               rumprefix + "2.jpg",
               rumprefix + "3.jpg",
               rumprefix + "4.jpg",
               rumprefix + "5.jpg",
               rumprefix + "6.jpg",
               rumprefix + "7.jpg",
           } ,"" , "" , new Dictionary<string, TypeOfApartment>()
           {
               {
                            "Luxury Room",
                            new TypeOfApartment("LX", 12, 50.7M, 7,
                                "This property is 11 minutes walk from the beach. These spacious modern villas each have a private outdoor pool and garden with a barbecue area. Located 100 m from Lanzarote’s Rubicon Marina, Villas Puerto Rubicon offer free on-site parking. Featuring tiled floors and a fan, each villa has a living room with satellite TV, sofa, CD and DVD player. The bathroom comes with a hairdryer, and the well-equipped kitchen includes a washing machine and dishwasher. Guests will receive a free welcome pack on arrival including tea, coffee, juice, milk, water, and biscuits. Luggage storage is available at Villas Puerto Rubicon and there is a tour desk. Playa Blanca Beach and Hesperia Playa Dorada Golf Club are a 10-minute walk away. This property is also rated for the best value in Playa Blanca! Guests are getting more for their money when compared to other properties in this city. We speak your language!")
                        },
                        {
                            "Single Room",
                            new TypeOfApartment("SR", 52, 25.45M, 2,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },
                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 27.99M, 2,
                                "You will live in a amazing double room. It is perfect for family!")
                        }
           }, new Dictionary<string, string>()
           {
               
           }  ) ,
           new Property("TANSU'S VILLA" , " A house is habitable quickly between 7 m, 16 m kitchen, living room 14 m, 10 m room, bedroom 9.5 m, 16 m room, complete renovation for the second home 3 rooms of 14.25, 18 m.", new List<string>()
           {
               tanprefix + "1.jpg",
               tanprefix + "2.jpg",
               tanprefix + "3.jpg",
               tanprefix + "4.jpg",
               tanprefix + "5.jpg",
               tanprefix + "6.jpg",
               tanprefix + "7.jpg",

           } , "" , "" , new Dictionary<string, TypeOfApartment>()
           {
              {
                            "Luxury Room",
                            new TypeOfApartment("LX", 12, 50.7M, 7,
                                "This property is 11 minutes walk from the beach. These spacious modern villas each have a private outdoor pool and garden with a barbecue area. Located 100 m from Lanzarote’s Rubicon Marina, Villas Puerto Rubicon offer free on-site parking. Featuring tiled floors and a fan, each villa has a living room with satellite TV, sofa, CD and DVD player. The bathroom comes with a hairdryer, and the well-equipped kitchen includes a washing machine and dishwasher. Guests will receive a free welcome pack on arrival including tea, coffee, juice, milk, water, and biscuits. Luggage storage is available at Villas Puerto Rubicon and there is a tour desk. Playa Blanca Beach and Hesperia Playa Dorada Golf Club are a 10-minute walk away. This property is also rated for the best value in Playa Blanca! Guests are getting more for their money when compared to other properties in this city. We speak your language!")
                        },
                        {
                            "Single Room",
                            new TypeOfApartment("SR", 52, 25.45M, 2,
                                "You will live in a amazing boxroom where are double bed. IT IS GOOD BECAUSE IT IS CHEAP!!!")
                        },
                        {
                            "Double Room",
                            new TypeOfApartment("DR", 5, 27.99M, 2,
                                "You will live in a amazing double room. It is perfect for family!")
                        }

           }, new Dictionary<string, string>()
           {
               
           }  )

            };

            foreach (var prop in Collection)
            {
                Dictionary<string, string> apartDic = new Dictionary<string, string>();

                decimal minPrice = 0;
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

        public PropertyCatalog (string searchInput)
        {
            Collection = new ObservableCollection<Property>();


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

