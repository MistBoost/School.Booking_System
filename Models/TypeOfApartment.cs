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
        public string Initial { get; set; }
        public int NumberOfApartments { get; set; }
        public float Price { get; set; }
        public int MaxPeople { get; set; }

        public TypeOfApartment(string initial, int numberOfApartments, float price, int maxPeople)
        {
            Initial = initial;
            NumberOfApartments = numberOfApartments;
            Price = price;
            MaxPeople = maxPeople;
        }
    }

}