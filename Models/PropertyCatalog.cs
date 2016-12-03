using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq.Expressions;
using Newtonsoft.Json;
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

        public string Id { get; set; }

        public PropertyCatalog()
        {
            FilePath = "properties_data.json";
            LoadCollection();

            foreach (var prop in Collection)
            {
                prop.ApartmentDic = new Dictionary<string, Apartment>();
                foreach (KeyValuePair<string, TypeOfApartment> typeOfApartment in prop.TypesOfApartments)
                {
                    for (int i = 0; i < typeOfApartment.Value.NumberOfApartments; i++)
                    {
                        Id = CreateID(prop.ResorseTypeCode, prop.PropertyCode, typeOfApartment.Value.Initial, i);
                        prop.ApartmentDic.Add(Id, new Apartment(typeOfApartment.Value.Price, typeOfApartment.Value.MaxPeople));
                    }
                }
                string toJson = JsonConvert.SerializeObject(prop.ApartmentDic);
                Debug.WriteLine(toJson);
            }
            //            Dictionary<string, Apartment> ApartmentDic = new Dictionary<string, Apartment>();
            //for (int j = 0; j<3; j++)
            //{

            //        for (int i = 0; i < 5; i++)
            //        {
            //            Id = CreateID("a","b" ,"c", i);
            //            ApartmentDic.Add(Id, new Apartment(45f,15));
            //        }

            //    string toJson = JsonConvert.SerializeObject(ApartmentDic);
            //    Debug.WriteLine(toJson);
            //}
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
            return _Id;
        }
    }
}
