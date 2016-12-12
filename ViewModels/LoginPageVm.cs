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
    public class LoginPageVm : Catalog<Account>, INotifyPropertyChanged
    {
        public MainFrameSingleton NavigationControl { get; set; }
        private string _statusMessages;
        private DelegateCommand _logOut;
        public string RawUsername { get; set; }
        public string RawPassword { get; set; }
        public DelegateCommand LoginCommand { get; set; }
        public Catalog<Account> AccountCatalog { get; set; }
        public LoggedUserSingleton UserSingleton { get; set; }
        public DelegateCommand SkipToMainPage { get; set; }
        public DelegateCommand RegisterAccount { get; set; }
        public DelegateCommand KeyDown { get; set; }

        public DelegateCommand LogOut
        {
            get { return _logOut; }
            set
            {
                _logOut = value;
                OnPropertyChanged();
            }
        }

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
            NavigationControl = MainFrameSingleton.Instance;
            AccountCatalog = new AccountCatalog();
            RawPassword = string.Empty;
            RawUsername = string.Empty;
            UserSingleton = LoggedUserSingleton.Instance;
            StatusMessages = string.Empty;
            LoginCommand = new DelegateCommand(LoginCommandM);
            SkipToMainPage = new DelegateCommand(SkipToMainPageM);
           RegisterAccount = new DelegateCommand(RegisterAccountM);
            LogOut = new DelegateCommand(LogOutM);
        }

        private void LogOutM(object sender)
        {
            UserSingleton.LoggedAccount = null;
        }

        private void LoginCommandM(object sender)
        {
            foreach (var account in AccountCatalog.Collection)
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

        private void RegisterAccountM(object sender)
        {
            var frame = Window.Current.Content as Frame;
            frame?.Navigate(typeof(RegisterPage));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
