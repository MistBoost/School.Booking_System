using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using School.OnlineBookingSystem.Annotations;
using School.OnlineBookingSystem.Common;
using School.OnlineBookingSystem.Views;

namespace School.OnlineBookingSystem.ViewModels
{
    public class MainPageVm : INotifyPropertyChanged
    {
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

        public DelegateCommand NavigateToCommand { get; set; }
        public DelegateCommand GoBackCommand { get; set; }
        public MainPageVm()
        {
            MainFrame = new Frame {SourcePageType = typeof(FrontPage)};
            NavigateToCommand = new DelegateCommand(NavigateToCommandM);
            GoBackCommand = new DelegateCommand(GoBackCommandM);
        }

        private void NavigateToCommandM(object sender)
        {
            var input = sender as string;
            switch (input)
            {
                case ("FrontPage"):
                    MainFrame.SourcePageType = typeof(FrontPage);
                    break;
                case ("SearchPage"):
                    MainFrame.SourcePageType = typeof(SearchPage);
                    break;
                case ("PropertiesPage"):
                    MainFrame.SourcePageType = typeof(PropertiesPage);
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
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
