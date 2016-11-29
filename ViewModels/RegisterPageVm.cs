using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private ObservableCollection<string> _viewData;

        public ObservableCollection<string> ViewData
        {
            get { return _viewData; }
            set
            {
                _viewData = value;
                OnPropertyChanged(nameof(ViewData));
            }
        }

        public DelegateCommand Register { get; set; }
        public RegisterPageVm()
        {
            Register = new DelegateCommand(RegisterM);
            ViewData = new ObservableCollection<string>() {"", "", "", ""};
        }

        private void RegisterM(object obj)
        {
            var tempAcc = new Account(ViewData[0], ViewData[1], ViewData[2], ViewData[3], ViewData[4], AccountTypes.User);        
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
