using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.OnlineBookingSystem.Annotations;

namespace School.OnlineBookingSystem.Models
{
    public sealed class LoggedUserSingleton
    {
        public Account LoggedAccount { get; set; }
        private static LoggedUserSingleton _instance;

        public static LoggedUserSingleton Instance
        {
            get
            {
                if (_instance != null)
                {
                    return _instance;
                }
                _instance = new LoggedUserSingleton();
                return _instance;
            }
        }

        private LoggedUserSingleton()
        {
            LoggedAccount = null;
        }
    }
}
