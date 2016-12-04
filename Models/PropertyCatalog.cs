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
        public PropertyCatalog()
        {
            FilePath = "properties_data.json";
            LoadCollection();
            foreach (var prop in Collection)
            {
                prop.ApartmentDic = new Dictionary<string, Apartment>();
                float minPrice = 500;
                foreach (KeyValuePair<string, TypeOfApartment> typeOfApartment in prop.TypesOfApartments)
                {
                    for (int i = 0; i < typeOfApartment.Value.NumberOfApartments; i++)
                    {
                        string Id = CreateID(prop.ResorseTypeCode, prop.PropertyCode, typeOfApartment.Value.Initial, i);
                        prop.ApartmentDic.Add(Id, new Apartment(typeOfApartment.Value.Price, typeOfApartment.Value.MaxPeople));
                        if (minPrice > typeOfApartment.Value.Price)
                        {
                            minPrice = typeOfApartment.Value.Price;
                        }
                    }
                    prop.MinPrice = minPrice;
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
            return _Id;
        }
    }
}
