using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using School.OnlineBookingSystem.Common;

namespace School.OnlineBookingSystem.Models
{
    public sealed class BookingCatalog : Catalog<Booking>
    {
        private Property prop1 { get; set; }
        private Property prop2 { get; set; }
        private Property prop3 { get; set; }

        // Load all bookings
        public BookingCatalog()
        {
            FilePath = "booking_data.json";
            LoadCollection();
        }

        // When we adding a new bookingInfo to propertyName.json
        public BookingCatalog(Booking bookingInfo, Property property)
        {
            FilePath = property.Name + ".json";
            LoadCollection();
            Collection = new ObservableCollection<Booking>();
            Collection.Add(bookingInfo);
            SaveCollection();
        }

        private string CreateID(string _apartmentTypeInitial, int _nr)
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
