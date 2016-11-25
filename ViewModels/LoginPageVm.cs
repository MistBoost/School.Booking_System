using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using School.OnlineBookingSystem.Annotations;
using School.OnlineBookingSystem.Common;
using School.OnlineBookingSystem.Models;
using School.OnlineBookingSystem.Views;

namespace School.OnlineBookingSystem.ViewModels
{
    public class LoginPageVm : INotifyPropertyChanged
    {
        private string _statusMessages;
        public string RawUsername { get; set; }
        public string RawPassword { get; set; }
        public DelegateCommand LoginCommand { get; set; }
        public AccountCatalog AccountCatalog { get; set; }
        public UserSingleton UserSingleton { get; set; }
        public DelegateCommand SkipToMainPage { get; set; }

        public string StatusMessages
        {
            get { return _statusMessages; }
            set
            {
                _statusMessages = value; 
                OnPropertyChanged(nameof(StatusMessages));
            }
        }

        public LoginPageVm()
        {
            AccountCatalog = new AccountCatalog();
            RawPassword = string.Empty;
            RawUsername = string.Empty;
            LoginCommand = new DelegateCommand(LoginCommandM);
            UserSingleton = UserSingleton.Instance;
            StatusMessages = string.Empty;
            SkipToMainPage = new DelegateCommand(SkipToMainPageM);
        }

        private void LoginCommandM(object sender)
        {
            foreach (var account in AccountCatalog.Accounts)
            {
                if (account.Username == RawUsername && account.Password == RawPassword)
                {
                    UserSingleton.LoggedAccount = account;
                }
            }
            if (UserSingleton.LoggedAccount != null)
            {
                var frame = Window.Current.Content as Frame;
                frame?.Navigate(typeof(MainPage));
            }
            else
            {
                StatusMessages = "Invalid Username or Password";
            }
        }

        private void SkipToMainPageM(object sender)
        {
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
