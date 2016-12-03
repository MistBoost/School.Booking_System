using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
            foreach (var prop in Collection)
            {
                Dictionary<string, Apartment> apartments = new Dictionary<string, Apartment>();
                // Creating Apartments

                for (int i = 0; i < prop.NumberOfSmallRooms; i++)
                {
                    int maxPeople = 5;
                    prop.Id = CreateID(prop.Type, prop.Code, "SR", i); // SR - Small Room apartment type 
                    apartments.Add(prop.Id, new Apartment(prop.PriceOfSmallRoom, maxPeople));
                }
                for (int i = 0; i < prop.NumberOfBigRooms; i++)
                {
                    int maxPeople = 5;
                    prop.Id = CreateID(prop.Type, prop.Code, "BR", i);
                    apartments.Add(prop.Id, new Apartment(prop.PriceOfBigRoom, maxPeople));
                }
            }
        }
        private string CreateID(string _propertyType, string _code, string _apartmentType, int _nr)
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

            string _Id = $"{_propertyType}{_code}_{_apartmentType}{_nrString}";
            Debug.WriteLine(_Id);
            return _Id;
        }
    }
}
