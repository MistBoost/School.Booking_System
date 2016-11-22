using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.OnlineBookingSystem.Handlers;

namespace School.OnlineBookingSystem.Models
{
    public class BookingCatalog
    {
        private ObservableCollection<Booking> Bookings { get; }

        public BookingCatalog()
        {
            Bookings = FileManipulationHandler.LoadBookingsFromJson().Result;
        }

        ~BookingCatalog()
        {
            FileManipulationHandler.SaveBookingToJson(Bookings).Wait();
        }
    }
}
