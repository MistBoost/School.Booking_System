using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using School.OnlineBookingSystem.Annotations;
using School.OnlineBookingSystem.Common;
using School.OnlineBookingSystem.Models;
using static System.String;

namespace School.OnlineBookingSystem.ViewModels
{
    public class RegisterPageVm : INotifyPropertyChanged
    {
        private string _fullName;
        private string _statusBlock;

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
        public Catalog<Account> AccCat { get; set; }
        public string StatusBlock
        {
            get { return _statusBlock; }
            set
            {
                _statusBlock = value; 
                OnPropertyChanged(nameof(StatusBlock));
            }
        }
        public DelegateCommand Register { get; set; }
        public RegisterPageVm()
        {
            FullName = Empty;
            Username = Empty;
            Password = Empty;
            Email = Empty;
            Phone = Empty;
            AccCat = AccountCatalog.Instance;
            Register = new DelegateCommand(RegisterM);
            StatusBlock = "";
        }

        private void RegisterM(object obj)
        {
            AccCat.Collection = AccCat.LoadCollection().Result;
            var a = AccCat.Collection.FirstOrDefault(p => p.Username == Username);
            if (a == null)
            {
                var tempAcc = new Account(FullName, Username, Password, Email, Phone, AccountTypes.User);
                AccCat.Collection.Add(tempAcc);
                StatusBlock = "Account created!";
                AccCat.SaveCollection();
            }
            else
            {
                StatusBlock = "Username is already in use";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
