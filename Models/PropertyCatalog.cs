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

        public PropertyCatalog()
        {
            FilePath = "properties_data.json";
            LoadCollection();
        }
    }
}