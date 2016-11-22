using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.OnlineBookingSystem.Handlers;
using School.OnlineBookingSystem.Models;

namespace School.OnlineBookingSystem.ViewModels
{
    public class PropertiesPageVm
    {
        public PropertyCatalog PropertyCatalog { get; set; }

        public PropertiesPageVm()
        {
            PropertyCatalog = new PropertyCatalog();
        }
    }
}
