using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using School.OnlineBookingSystem.Common;

namespace School.OnlineBookingSystem.Models
{
    public sealed class BookingCatalog : Catalog<Booking>
    {
       public BookingCatalog(string name)
        {
            FilePath = name + ".json";
            LoadCollection();
        }
    }
}
