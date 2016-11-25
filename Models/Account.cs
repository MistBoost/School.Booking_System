using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.OnlineBookingSystem.Models
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public AccountTypes AccountType { get; set; }

        public List<Booking> Bookings { get; set; }

        public Account(string username, string password, AccountTypes type)
        {
            Username = username;
            Password = password;
            AccountType = type;
            Bookings = new List<Booking>();
        }
        public Account()
        {
            Username = "default";
            Password = "default";
            AccountType = AccountTypes.User;
            Bookings = new List<Booking>();
        }
    }

    public enum AccountTypes
    {
        Administrator,
        User
    }
}
