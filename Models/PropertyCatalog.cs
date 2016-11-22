using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.OnlineBookingSystem.Handlers;

namespace School.OnlineBookingSystem.Models
{
    public class PropertyCatalog
    {
        private readonly string prefix = "../Assets/";
        public ObservableCollection<Property> Properties { get; set; }

        public PropertyCatalog()
        {
            Properties = new ObservableCollection<Property>
            {
                new Property("name", "info", 50, new List<string>() {prefix + "france.jpg"}, "paris"),
                new Property("not name", "not info", 20, new List<string>() {prefix + "england.jpg"}, "lourds"),
                new Property("name", "info", 50, new List<string>() {prefix + "france.jpg"}, "paris"),
                new Property("not name", "not info", 20, new List<string>() {prefix + "england.jpg"}, "london"),
                new Property("name", "info", 50, new List<string>() {prefix + "france.jpg"}, "secovce"),
                new Property("not name", "not info", 20, new List<string>() {prefix + "england.jpg"}, "habes"),
                new Property("name", "info", 50, new List<string>() {prefix + "france.jpg"}, "tatry"),
                new Property("not name", "not info", 20, new List<string>() {prefix + "england.jpg"}, "bardejov")
            };
        }
    }
}
