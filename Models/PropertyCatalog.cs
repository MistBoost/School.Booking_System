using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Bluetooth.Advertisement;
using School.OnlineBookingSystem.Common;
using School.OnlineBookingSystem.Handlers;

namespace School.OnlineBookingSystem.Models
{
    public class PropertyCatalog : Catalog<Property>
    {

        private readonly string TownPointePrefix = "../Images/SkiResorts/TownPointe/";
        private readonly string BeaverPrefix = "../Images/SkiResorts/BeaverCreekLodge/";
        private readonly string charterPrefix = "../Images/SkiResorts/CharetatBeaverCreek/";
        private readonly string harischprefix = "../Images/Skiresorts/HarischHotelWeissesRossl/";
        private readonly string hayattprefix = "../Images/Skiresorts/ElkhornLodge";
        private readonly string Pinesprefix = "../Images/Skiresorts/PinesLodgeARockResort";

        public PropertyCatalog()
        {
            Collection = new ObservableCollection<Property>
            {
                new Property("TOWN POINTE",
                    "Town Pointe Condominiums offer the utmost in location nestled at the base of historic Main Street in Park City Town Pointe also offers style and amenities Conveniently located it is just a short walk from the Town Lift where the guests can catch a chairlift and be on the slopes of Park City Mountain Resort in a matter of minutes. \r\n\r\nDirect access to Main Street and Old Town by way of the pedestrian path",
                    2160,
                    new List<string>()
                    {
                        TownPointePrefix + "parkcity_townpointe1.jpg",
                        TownPointePrefix + "parkcity_townpointe2.jpg",
                        TownPointePrefix + "parkcity_townpointe3.jpg",
                        TownPointePrefix + "parkcity_townpointe4.jpg ",
                        TownPointePrefix + "parkcity_townpointe5.jpg",
                        TownPointePrefix + "parkcity_townpointe6.jpg",
                        TownPointePrefix + "parkcity_townpointe7.jpg"
                    }, "Alpe d\'Huez"),
                new Property("BEAVER CREEK LODGE",
                    "Beaver Creek’s only all-suite hotel, Beaver Creek Lodge is surrounded by Beaver Creek’s world-class slopes, and just steps away from the Strawberry Park Express Lift and Centennial Express Lift. Guests will enjoy staying in one of the spacious 71 ski in ski out, 1 bedroom suites, which offer upscale touches like pillow-top bedding",
                    2000,
                    new List<string>()
                    {
                        BeaverPrefix + "beavercreek_beavercreeklodge1.jpg",
                        BeaverPrefix + "beavercreek_beavercreeklodge6.jpg",
                        BeaverPrefix + "beavercreek_beavercreeklodge7.jpg",
                        BeaverPrefix + "beavercreek_beavercreeklodge10.jpg",
                        BeaverPrefix + "beavercreek_beavercreeklodge2.jpg",
                        BeaverPrefix + "beavercreek_beavercreeklodge3.jpg",
                        BeaverPrefix + "beavercreek_beavercreeklodge4.jpg"
                    }, "chamonix"),
                new Property("CHARTER AT BEAVER CREEK",
                    "\r\nProviding exceptional convenience the Charter offers ski in ski out access and is within walking distance of the Bavarian-style Beaver Creek Village Recognized by Condé Nast as one of the Top 50 Ski Hotels in the US and Canada in 2010 this",
                    3000,
                    new List<string>()
                    {
                        charterPrefix + "bc_charteratbeavercreek1_wynbcvl.jpg",
                        charterPrefix + "bc_charteratbeavercreek10_wynbcvl.jpg",
                        charterPrefix + "bc_charteratbeavercreek3_wynbcvl.jpg",
                        charterPrefix + "bc_charteratbeavercreek5_wynbcvl.jpg",
                        charterPrefix + "bc_charteratbeavercreek6_wynbcvl.jpg",
                        charterPrefix + "bc_charteratbeavercreek8_wynbcvl.jpg",
                        charterPrefix + "bc_charteratbeavercreek9_wynbcvl.jpg"
                    }, "Avoriaz"),

                new Property("HARISCH HOTEL WEISSES ROSSL", " Meeting the high demands of fine dining you will delight in the culinary creations of one of two restaurants For wine enthusiasts the Hotel Weisses Rssl offers a historic wine cellar built in the 15th century" , 4000,
                new List<string>()
                {
                    harischprefix + "kit_hotelweisses1.jpg",
                    harischprefix + "kit_hotelweisses6.jpg",
                    harischprefix + "kit_hotelweisses7.jpg",
                    harischprefix + "kit_hotelweisses8.jpg",
                    harischprefix + "kit_hotelweisse9.jpg",
                    harischprefix + "kit_hotelweisses2.jpg",
                    harischprefix + "kit_hotelweisses5.jpg"

                },"FLAINE" ),

                new Property("Elkhorn Lodge", "At the Elkhorn Lodge simply walk out your door and catch the Elkhorn Lift Chair 14 for a true ski-in and ski-out experience from mid-December through March" , 3500 , new List<string>()
                {
                    hayattprefix + "beavercreek_elkhornlodge1.jpg",
                    hayattprefix + "beavercreek_elkhornlodge2.jpg",
                    hayattprefix + "beavercreek_elkhornlodge3.jpg",
                    hayattprefix + "beavercreek_elkhornlodge4.jpg",
                    hayattprefix + "beavercreek_elkhornlodge5.jpg",
                    hayattprefix + "beavercreek_elkhornlodge6.jpg",
                }, "LES ARCS"),

                new Property("PINES LODGE A ROCKRESORT", "The Pines Lodge A RockResort provides a unique blend of European Alpine charm and modern luxury Guests and their pooches are greeted by relaxation and rejuvenation from the moment they enter A diners delight the AAA Four Diamond Grouse Mountain Grill attracts guests and non-guests alike, and four-legged guests will enjoy noshing on the Pines’ homemade dog treats", 4000,
                new List< string>()
                {
                    Pinesprefix + "beavercreek_pineslodge1.jpg",
                    Pinesprefix + "beavercreek_pineslodge2.jpg",
                    Pinesprefix + "beavercreek_pineslodge3.jpg",
                    Pinesprefix + "beavercreek_pineslodge4.jpg",
                    Pinesprefix + "beavercreek_pineslodge5.jpg",
                    Pinesprefix + "beavercreek_pineslodge8.jpg",
                    Pinesprefix + "beavercreek_pineslodge9.jpg",
                }, "MORZINE")
            };
        }
    }
}