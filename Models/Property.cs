using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
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

        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Location { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Information { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<string> ImagePaths { get; set; }

        [DataMember(EmitDefaultValue = false )]
        public string Country { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public Dictionary<string, TypeOfApartment> TypesOfApartments { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public Dictionary<string, string> ApartmentDic { get; set; }
        
        public decimal MinPrice { get; set; }

        public string DisplayLocation
        {
            get { return Location + " (" + Country + ")"; }
            set { }
        }

        #endregion

        public Property(string name, string information, List<string> imagePaths, string country, string location, Dictionary<string, TypeOfApartment> typesOfApartmentsDictionary, Dictionary<string, string> apartmentDictionary  )
        {
            Name = name;
            Information = information;
            ImagePaths = imagePaths;
            Country = country;
            Location = location;
            TypesOfApartments = typesOfApartmentsDictionary;
            ApartmentDic = apartmentDictionary;
        }
    }
}

