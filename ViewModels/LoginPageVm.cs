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
    public class LoginPageVm : Catalog<Account>, INotifyPropertyChanged
    {
        public MainFrameSingleton NavigationControl { get; set; }
        private string _statusMessages;
        private DelegateCommand _logOut;
        private string _loginMenuFlyout;
        private string _accountFlyout;
        private string _accountButtonContent;
        private string _rawUsername;
        private string _rawPassword;
        public string RawUsername
        {
            get { return _rawUsername; }
            set
            {
                _rawUsername = value;
                OnPropertyChanged(nameof(RawUsername));
            }
        }
        public string RawPassword
        {
            get { return _rawPassword; }
            set
            {
                _rawPassword = value;
                OnPropertyChanged(nameof(RawPassword));
            }
        }
        public DelegateCommand LoginCommand { get; set; }
        public Catalog<Account> AccountCatalog { get; set; }
        public LoggedUserSingleton UserSingleton { get; set; }
        public string LoginMenuFlyout
        {
            get { return _loginMenuFlyout; }
            set
            {
                _loginMenuFlyout = value;
                OnPropertyChanged(nameof(LoginMenuFlyout));
            }
        }
        public string AccountFlyout
        {
            get { return _accountFlyout; }
            set
            {
                _accountFlyout = value; 
                OnPropertyChanged(nameof(AccountFlyout));
            }
        }
        public string AccountButtonContent
        {
            get { return _accountButtonContent; }
            set
            {
                _accountButtonContent = value;
                OnPropertyChanged(nameof(AccountButtonContent));
            }
        }
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
            UserSingleton = LoggedUserSingleton.Instance;
            NavigationControl = MainFrameSingleton.Instance;
            AccountCatalog = new AccountCatalog();
            RawPassword = string.Empty;
            RawUsername = string.Empty;
            StatusMessages = string.Empty;
            LoginCommand = new DelegateCommand(LoginCommandM);
            LogOut = new DelegateCommand(LogOutM);
            LoginMenuFlyout = "Visible";
            AccountFlyout = "Collapsed";
            AccountButtonContent = "Login";
        }

        private void LogOutM(object sender)
        {
            UserSingleton.LoggedAccount = null;
            LoginMenuFlyout = "Visible";
            AccountFlyout = "Collapsed";
            AccountButtonContent = "Login";
        }
        private void LoginCommandM(object sender)
        {
            UserSingleton.LoggedAccount = null;
            foreach (var account in AccountCatalog.Collection)
            {
                if (account.Username == RawUsername && account.Password == RawPassword)
                {
                    UserSingleton.LoggedAccount = account;
                }
            }
            if (UserSingleton.LoggedAccount != null)
            {
                LoginMenuFlyout = "Collapsed";
                AccountFlyout = "Visible";
                AccountButtonContent = UserSingleton.LoggedAccount.Username;
            }
            else
            {
                StatusMessages = "Invalid Username or Password";
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
