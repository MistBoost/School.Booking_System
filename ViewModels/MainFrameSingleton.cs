using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using School.OnlineBookingSystem.Annotations;
using School.OnlineBookingSystem.Common;
using School.OnlineBookingSystem.Views;

namespace School.OnlineBookingSystem.ViewModels
{
    public sealed class MainFrameSingleton : INotifyPropertyChanged
    {
        private static MainFrameSingleton _instance;
        public static MainFrameSingleton Instance
        {
            get {
                if (_instance != null)
                {
                    return _instance;
                }
                _instance = new MainFrameSingleton();
                return _instance;
            }
        }

        public DelegateCommand NavigateToCommand { get; set; }
        public DelegateCommand GoBackCommand { get; set; }

        private Frame _mainFrame;

        public Frame MainFrame
        {
            get { return _mainFrame; }
            set
            {
                _mainFrame = value;
                OnPropertyChanged(nameof(MainFrame));
            }
        }
        private MainFrameSingleton()
        {
            MainFrame = new Frame { SourcePageType = typeof(FrontPage) };
            NavigateToCommand = new DelegateCommand(NavigateToCommandM);
            GoBackCommand = new DelegateCommand(GoBackCommandM);
        }
        private void NavigateToCommandM(object sender)
        {
            var input = sender as string;
            switch (input)
            {
                case ("FrontPage"):
                    Instance.MainFrame.SourcePageType = typeof(FrontPage);
                    break;
                case ("SearchPage"):
                    Instance.MainFrame.SourcePageType = typeof(SearchPage);
                    break;
                case ("PropertiesPage"):
                    Instance.MainFrame.SourcePageType = typeof(PropertiesPage);
                    break;
                case ("CreateBookingView"):
                    Instance.MainFrame.SourcePageType = typeof(CreateBookingView);
                    break;
            }
        }

        private void GoBackCommandM(object sender)
        {
            if (MainFrame.CanGoBack)
            {
                MainFrame.GoBack(new SlideNavigationTransitionInfo());
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
