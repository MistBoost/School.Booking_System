using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using School.OnlineBookingSystem.Annotations;
using School.OnlineBookingSystem.Common;
using School.OnlineBookingSystem.Models;

namespace School.OnlineBookingSystem.ViewModels
{
    public class PropertiesPageVm : INotifyPropertyChanged
    {
        private Catalog<Property> _propertyCatalog;
        private int _selectedIndex;
        private ObservableCollection<StringValue> _selectedStringValues;
        private string _selectedImageString;
        private int _selectedImageIndex;
        private bool _isPaneOpen;
        private Property _selectedProperty;

        public Property SelectedProperty
        {
            get { return _selectedProperty; }
            set
            {
                _selectedProperty = value;
                OnPropertyChanged(nameof(SelectedProperty));
            }
        }
        public MainFrameSingleton NavigationControl { get; set; }
        public bool IsPaneOpen
        {
            get { return _isPaneOpen; }
            set
            {
                _isPaneOpen = value;
                OnPropertyChanged(nameof(IsPaneOpen));
            }
        }

        public int SelectedImageIndex
        {
            get { return _selectedImageIndex; }
            set
            {
                if (value > 0 && value < SelectedStringValues.Count)
                {
                    _selectedImageIndex = value;
                }
                else
                {
                    _selectedImageIndex = 0;
                }
                OnPropertyChanged(nameof(SelectedImageIndex));
                SelectedImageString = SelectedStringValues[_selectedImageIndex].Value;
            }
        }

        public string SelectedImageString
        {
            get { return _selectedImageString; }
            set
            {
                _selectedImageString = value;
                OnPropertyChanged(nameof(SelectedImageString));
            }
        }

        public ObservableCollection<StringValue> SelectedStringValues
        {
            get { return _selectedStringValues; }
            set
            {
                _selectedStringValues = value;
                OnPropertyChanged(nameof(SelectedStringValues));
            }
        }

        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set
            {
                _selectedIndex = value;
                OnPropertyChanged(nameof(SelectedIndex));
                SelectedProperty = PropertyCatalog.Collection[_selectedIndex];
                SelectedStringValues = new ObservableCollection<StringValue>(SelectedProperty.ImagePaths.Select(p => new StringValue(p)).ToList());
                SelectedImageIndex = 0;
            }
        }

        public Catalog<Property> PropertyCatalog
        {
            get { return _propertyCatalog; }
            set
            {
                _propertyCatalog = value;
                OnPropertyChanged(nameof(PropertyCatalog));
            }
        }

        public DelegateCommand OpenPane { get; set; }
        public PropertiesPageVm()
        {
            IsPaneOpen = true;
            PropertyCatalog = Catalog<Property>.Instance;
            SelectedIndex = 0;
            SelectedImageIndex = 0;
            SelectedStringValues = new ObservableCollection<StringValue>(PropertyCatalog.Collection[SelectedIndex].ImagePaths.Select(p => new StringValue(p)).ToList());
            OpenPane = new DelegateCommand(OpenPaneM);
            NavigationControl = MainFrameSingleton.Instance;
            SelectedProperty = PropertyCatalog.Collection[0];
        }

        private void OpenPaneM(object sender)
        {
            if (!IsPaneOpen)
            {
                IsPaneOpen = true;
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
