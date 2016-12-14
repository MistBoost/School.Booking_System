using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using School.OnlineBookingSystem.Annotations;
using School.OnlineBookingSystem.Common;
using School.OnlineBookingSystem.Models;
using School.OnlineBookingSystem.Views;

namespace School.OnlineBookingSystem.ViewModels
{
    public class RegisterPageVm : Catalog<AccountCatalog>, INotifyPropertyChanged
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
        public AccountCatalog accCat;

        public DelegateCommand Register { get; set; }
        public RegisterPageVm()
        {
            accCat = new AccountCatalog();
            Register = new DelegateCommand(RegisterM);
        }

        private void RegisterM(object obj)
        {
            var tempAcc = new Account(FullName, Username, Password, Email, Phone, AccountTypes.User);
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
