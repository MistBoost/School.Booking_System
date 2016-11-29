using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.OnlineBookingSystem.Common;
using School.OnlineBookingSystem.Handlers;

namespace School.OnlineBookingSystem.Models
{
    public sealed class PropertyCatalog : Catalog<Property>
    {

        private readonly string prefix = "../Images/";

        public PropertyCatalog()
        {
            Collection = new ObservableCollection<Property>
            {
                new Property("name", "info", 50, new List<string>() {prefix + "france.jpg", prefix + "england.jpg",prefix + "france.jpg",prefix + "england.jpg", prefix + "france.jpg", prefix + "england.jpg",prefix + "france.jpg",prefix + "england.jpg"}, "paris"),
                new Property("not name", "not info", 20, new List<string>() {prefix + "france.jpg", prefix + "england.jpg",prefix + "france.jpg",prefix + "england.jpg",prefix + "england.jpg", prefix + "france.jpg", prefix + "england.jpg",prefix + "france.jpg",prefix + "england.jpg"}, "lourds"),
                new Property("name", "info", 50, new List<string>() {prefix + "france.jpg"}, "paris"),
                new Property("not name", "not info", 20, new List<string>() {prefix + "france.jpg", prefix + "england.jpg",prefix + "france.jpg",prefix + "england.jpg",prefix + "england.jpg", prefix + "france.jpg", prefix + "england.jpg",prefix + "france.jpg",prefix + "england.jpg"}, "london"),
                new Property("name", "info", 50, new List<string>() {prefix + "france.jpg"}, "secovce"),
                new Property("not name", "not info", 20, new List<string>() {prefix + "france.jpg", prefix + "england.jpg",prefix + "france.jpg",prefix + "england.jpg",prefix + "england.jpg", prefix + "france.jpg", prefix + "england.jpg",prefix + "france.jpg",prefix + "england.jpg"}, "habes"),
                new Property("name", "info", 50, new List<string>() {prefix + "france.jpg"}, "tatry"),
                new Property("not name", "not info", 20, new List<string>() {prefix + "france.jpg", prefix + "england.jpg",prefix + "france.jpg",prefix + "england.jpg",prefix + "england.jpg", prefix + "france.jpg", prefix + "england.jpg",prefix + "france.jpg",prefix + "england.jpg"}, "bardejov")
            };
        }
    }
}
