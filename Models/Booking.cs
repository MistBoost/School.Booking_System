using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.OnlineBookingSystem.Models
{
    public class Booking
    {
        /// <summary>
        /// Auto-properties
        /// </summary>
        #region
        public string CustomersName { get; set; }
        public string CustomersPhoneNumber { get; set; }
        public string CustomersEmail { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int AdultsCount { get; set; }
        public int ChildrensCount { get; set; }
        public Property Property { get; set; }
        #endregion

        public Booking(string customersName, string customersPhoneNumber, string customersEmail, DateTime checkInDate, DateTime checkOutDate, int adultsCount, int childrensCount, Property property)
        {
            CustomersEmail = customersName;
            CustomersPhoneNumber = customersPhoneNumber;
            CustomersEmail = customersEmail;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            AdultsCount = adultsCount;
            ChildrensCount = childrensCount;
            Property = property;
        }
    }
}
