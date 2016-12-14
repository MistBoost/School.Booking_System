using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.OnlineBookingSystem.Common;
using School.OnlineBookingSystem.Models;

namespace School.OnlineBookingSystem.ViewModels
{
    class MyBookingsVm : Catalog<BookingCatalog>
    {
        public BookingCatalog BookingCat { get; set; }
        
    }
}
