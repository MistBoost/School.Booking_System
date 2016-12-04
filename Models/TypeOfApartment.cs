using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace School.OnlineBookingSystem.Models
{
    [DataContract]
    public class TypeOfApartment
    {

        [DataMember(EmitDefaultValue = false)]
        public string Initial { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int NumberOfApartments { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public float Price { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int MaxPeople { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Information { get; set; }

    }

}