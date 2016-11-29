using System;
using System.Collections.ObjectModel;
using School.OnlineBookingSystem.Handlers;
using School.OnlineBookingSystem.Common;

namespace School.OnlineBookingSystem.Models
{
    public sealed class BookingCatalog : Catalog<Booking>
    {
        private BookingCatalog()
        {
            Collection = new ObservableCollection<Booking>()
            {
                new Booking("name", "27246461", "julius.cizmar@gmail.com", new DateTime(2016,12,19), 
                    new DateTime(2016,12,27), 1, 0, PropertyCatalog.Instance.Collection[0]),
                new Booking("not name", "12365487", "asd.v@gmail.com", new DateTime(2017,12,19),
                    new DateTime(2016,12,27), 1, 0, PropertyCatalog.Instance.Collection[1]),
                new Booking("name", "14528596", "vvvvcizmar@gmail.com", new DateTime(2019,12,19),
                    new DateTime(2016,12,27), 1, 0, PropertyCatalog.Instance.Collection[2])
            };
        }
    }
}
