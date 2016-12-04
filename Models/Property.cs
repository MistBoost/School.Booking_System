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

        [DataMember (EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Location { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Information { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<string> ImagePaths { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ResorseTypeCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public Dictionary<string, TypeOfApartment> TypesOfApartments { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public Dictionary<string, Apartment> ApartmentDic { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string PropertyCode { get; set; } // Has to name a company in some initials, for instance - AA (For ID purpose)

        public float MinPrice { get; set; }
        #endregion

    }
    }

