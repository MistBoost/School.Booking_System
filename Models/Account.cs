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
        public AccountTypes AccountType { get; set; }
        public ObservableCollection<Booking> Bookings { get; set; }
        public Account(string fullname, string username, string password, string email, string phonenumber, AccountTypes type)
        {
            Username = username;
            Password = password;
            FullName = fullname;
            PhoneNumber = phonenumber;
            Email = email;
            AccountType = type;
            Bookings = new ObservableCollection<Booking>();
        }
        public Account()
        {
            Username = "default";
            Password = "default";
            AccountType = AccountTypes.User;
            Bookings = new ObservableCollection<Booking>();
        }
    }

    public enum AccountTypes
    {
        Administrator,
        User
    }
}
