using System;
using System.Collections.ObjectModel;
using School.OnlineBookingSystem.Common;

namespace School.OnlineBookingSystem.Models
{
    public sealed class BookingCatalog : Catalog<Booking>
    {
        private BookingCatalog()
        {
            FilePath = "booking_data.json";
            LoadCollection();
        }
    }
}
