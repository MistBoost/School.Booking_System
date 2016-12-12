using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.OnlineBookingSystem.Models;

namespace School.OnlineBookingSystem.Common
{
    public sealed class TransportSingleton
    {
        private static TransportSingleton _instance;

        public Property SelectedProp { get; set; }
        public static TransportSingleton Instance
        {
            get
            {
                if (_instance != null)
                {
                    return _instance;
                }
                _instance = new TransportSingleton();
                return _instance;
            }
        }

        private TransportSingleton()
        {
            
        }
}
}
