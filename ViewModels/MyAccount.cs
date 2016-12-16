using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.OnlineBookingSystem.Models;

namespace School.OnlineBookingSystem.ViewModels
{
    public class MyAccount
    {
        public LoggedUserSingleton LoggedUserSingleton { get; set; }
        public MyAccount()
        {
            LoggedUserSingleton = LoggedUserSingleton.Instance;
        }
    }
}
