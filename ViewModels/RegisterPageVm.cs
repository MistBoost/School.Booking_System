using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using School.OnlineBookingSystem.Annotations;
using School.OnlineBookingSystem.Common;
using School.OnlineBookingSystem.Models;
using School.OnlineBookingSystem.Views;

namespace School.OnlineBookingSystem.ViewModels
{
    public class RegisterPageVm : INotifyPropertyChanged
    {
        private string _fullName;

        public string FullName
        {
            get { return _fullName; }
            set
            {
                _fullName = value;
                OnPropertyChanged(nameof(FullName));
            }
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public DelegateCommand Register { get; set; }
        public RegisterPageVm()
        {
            Register = new DelegateCommand(RegisterM);
        }

        private void RegisterM(object obj)
        {
            var tempAcc = new Account(FullName, Username, Password, Email, Phone, AccountTypes.User);
            var accCat = new AccountCatalog();
            accCat.Collection.Add(tempAcc);

            var frame = Window.Current.Content as Frame;
            frame?.Navigate(typeof(MainPage));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
