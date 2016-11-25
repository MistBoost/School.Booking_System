using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using School.OnlineBookingSystem.Annotations;
using School.OnlineBookingSystem.Common;

namespace School.OnlineBookingSystem.ViewModels
{
    public class FrontPageVm : INotifyPropertyChanged
    {
        private int _selectedIndex;
        private ObservableCollection<StringValue> _images;

        public ObservableCollection<StringValue> Images
        {
            get { return _images; }
            set
            {
                _images = value;
                OnPropertyChanged(nameof(Images));
            }
        }

        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set
            {
                _selectedIndex = value;
                OnPropertyChanged(nameof(SelectedIndex));
            }
        }

        public FrontPageVm()
        {
            Images = new ObservableCollection<StringValue>
            {
                new StringValue(SpecialStrings.ImagePrefix + "1.jpg"),
                new StringValue(SpecialStrings.ImagePrefix + "2.jpg"),
                new StringValue(SpecialStrings.ImagePrefix + "3.jpg"),
                new StringValue(SpecialStrings.ImagePrefix + "4.jpg"),
                new StringValue(SpecialStrings.ImagePrefix + "5.jpg")
            };
            SelectedIndex = 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
