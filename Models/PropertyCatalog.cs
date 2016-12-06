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

        public PropertyCatalog() : base("properties_data.json")
        {
        }

        //private string CreateID (string _apartmentTypeInitial, int _nr)
        //    {
        //        string _nrString;
        //        if (_nr < 10)
        //        {
        //            _nrString = "00" + _nr;
        //        }
        //        else if (_nr < 100 && _nr >= 10)
        //        {
        //            _nrString = "0" + _nr;
        //        }
        //        else _nrString = _nr.ToString();

        //        string _Id = $"{_apartmentTypeInitial}{_nrString}";
        //        return _Id;
        //    }

        //}
    }
}

