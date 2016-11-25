using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.OnlineBookingSystem.Annotations;

namespace School.OnlineBookingSystem.Models
{
    public sealed class UserSingleton
    {
        public Account LoggedAccount { get; set; }
        private static UserSingleton _instance;

        public static UserSingleton Instance => _instance ?? new UserSingleton();

        private UserSingleton()
        {
            LoggedAccount = null;
        }
    }
}
