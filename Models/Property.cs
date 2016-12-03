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
        public string Type { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public float PriceOfSmallRoom { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int NumberOfSmallRooms { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public float PriceOfBigRoom { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int NumberOfBigRooms { get; set; }

       [DataMember(EmitDefaultValue = false)]
        public string Code { get; set; } // Admin has to name a company in two letter, for instance - AA (For ID purpose)

        #endregion
        public Property(string name,string typeOfProperty, string companyCode, string information, List<string> imagePaths, string location, int numberOfSmallRooms, float priceOfSmallRoom, int numberOfBigRooms, float priceOfBigRoom)
        {
            Name = name;
            Type = typeOfProperty;
            Code = companyCode;
            Information = information;
            ImagePaths = imagePaths;
            Location = location;
        }

        public Property()
        {
            Name = "name";
            Information = "information";
            ImagePaths = new List<string>()
            {
              



            };
            Location = "seasoninfo";
        }
        }
    }

