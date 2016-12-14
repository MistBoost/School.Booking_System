using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace School.OnlineBookingSystem.Models
{
    [DataContract]
    public class Booking
    {
        /// <summary>
        /// Auto-properties
        /// </summary>
        #region


        [DataMember(EmitDefaultValue = false)]
        public string CustomersName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string CustomersPhoneNumber { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string CustomersEmail { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTimeOffset CheckInDate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTimeOffset CheckOutDate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int AdultsCount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int ChildrensCount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ApartmentId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ApartmentType { get; set; }
        #endregion

        public Booking(string customersName, string customersPhoneNumber, string customersEmail, DateTimeOffset checkInDate, DateTimeOffset checkOutDate, int adultsCount, int childrensCount, string apartmentId, string apartmentType)
        {
            CustomersName = customersName;
            CustomersPhoneNumber = customersPhoneNumber;
            CustomersEmail = customersEmail;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            AdultsCount = adultsCount;
            ChildrensCount = childrensCount;
            ApartmentId = apartmentId;
            ApartmentType = apartmentType;
        }
    }
}
