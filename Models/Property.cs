using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Diagnostics;

namespace School.OnlineBookingSystem.Models
{
    [DataContract]
    public class Property
    {
        #region

        [DataMember (EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Location { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Information { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int PricePerNight { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<string> ImagePaths { get; set; }
        
        #endregion
        public Property(string name, string information, int pricePerNight, List<string> imagePaths, string location)
        {
            Name = name;
            Information = information;
            PricePerNight = pricePerNight;
            ImagePaths = imagePaths;
            Location = location;
        }

        public Property()
        {
            Name = "name";
            Information = "information";
            PricePerNight = 10;
            ImagePaths = new List<string>()
            {
                "../Images/france.jpg"
                



            };
            Location = "seasoninfo";
        }
    }
}
