using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace School.OnlineBookingSystem.Models
{
    [DataContract]
    public class Apartment
    {
        [DataMember(EmitDefaultValue = false)]
        public float Price { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int MaxPeople { get; set; }

        public Apartment(float price, int maxPeople)
        {
            Price = price;
            MaxPeople = maxPeople;
        }
    }
}
