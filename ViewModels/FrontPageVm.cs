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
        public MainFrameSingleton NavigationControl { get; set; }

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
                new StringValue(SpecialStrings.ImagePrefix + "beavercreek_beavercreeklodge1.jpg"),
                new StringValue(SpecialStrings.ImagePrefix + "bc_borderslodge1_wynbcvl.jpg"),
                new StringValue(SpecialStrings.ImagePrefix + "beavercreek_pineslodge1.jpg"),
                new StringValue(SpecialStrings.ImagePrefix + "parkcity_townpointe1.jpg"),
                new StringValue(SpecialStrings.ImagePrefix + "bc_ritzcarltonbachelorgulch1_ritzbach.jpg")
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
