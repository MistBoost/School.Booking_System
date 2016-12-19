using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.OnlineBookingSystem.Models
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public ObservableCollection<Booking> Bookings { get; set; }
        public Account(string fullname, string username, string password, string email, string phonenumber)
        {
            Username = username;
            Password = password;
            FullName = fullname;
            PhoneNumber = phonenumber;
            Email = email;
            Bookings = new ObservableCollection<Booking>();

        }
        public Account()
        {
            Username = "default";
            Password = "default";
            Bookings = new ObservableCollection<Booking>();

        }
    }
    
}
