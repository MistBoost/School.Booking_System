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
        public decimal Price { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int MaxPeople { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string InformationAboutApartment { get; set; }

        public string DisplayApartInfo
        {
            get { return InformationAboutApartment + "\n The price is " + Price.ToString("C0") + " per night and there can book " + MaxPeople.ToString() + " people."; }
            set { }
        }

        public TypeOfApartment(string initial, int numberOfApartments, decimal price, int maxPeople, string informationAboutApartmentAboutApartment)
        {
            Initial = initial;
            NumberOfApartments = numberOfApartments;
            Price = price;
            MaxPeople = maxPeople;
            InformationAboutApartment = informationAboutApartmentAboutApartment;
        }
    }

}