using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using School.OnlineBookingSystem.Common;

namespace School.OnlineBookingSystem.Models
{
    public sealed class BookingCatalog : Catalog<Booking>
    {
        public BookingCatalog()
        {
            FilePath = "booking_data.json";
            LoadCollection();
        }

        public BookingCatalog(Booking bookingInfo, Property property)
        {
            FilePath = property.Name + ".json";
            Collection = new ObservableCollection<Booking>();
            Collection.Add(bookingInfo);
            SaveCollection();
        }
    }
}
