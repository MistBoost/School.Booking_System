using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using School.OnlineBookingSystem.Annotations;
using School.OnlineBookingSystem.Models;

namespace School.OnlineBookingSystem.ViewModels
{
    public class PropertiesPageVm : INotifyPropertyChanged
    {
        private Property _selectedAccommodation;
        private PropertyCatalog _propertyCatalog;
        private int _selectedIndex;
        private List<StringValue> _selectedStringValues;
        private string _selectedImageString;
        private int _selectedImageIndex;

        public int SelectedImageIndex
        {
            get { return _selectedImageIndex; }
            set
            {
                _selectedImageIndex = value;
                OnPropertyChanged(nameof(SelectedImageIndex));
                OnPropertyChanged(nameof(SelectedImageString));
            }
        }

        public string SelectedImageString
        {
            get { return SelectedStringValues[_selectedImageIndex].Value; }
            set
            {
                _selectedImageString = value;
                OnPropertyChanged(nameof(SelectedImageString));
            }
        }

        public List<StringValue> SelectedStringValues
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
                OnPropertyChanged(nameof(SelectedAccommodation));
                SelectedImageIndex = 0;
            }
        }

        public Property SelectedAccommodation
        {
            get
            {
                try
                {
                    return PropertyCatalog.Properties[SelectedIndex];
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                }
                return new Property();
            }
            set
            {
                _selectedAccommodation = value;
                OnPropertyChanged(nameof(SelectedAccommodation));
            }
        }

        public PropertyCatalog PropertyCatalog
        {
            get { return _propertyCatalog; }
            set
            {
                _propertyCatalog = value;
                OnPropertyChanged(nameof(PropertyCatalog));
            }
        }

        public PropertiesPageVm()
        {
            PropertyCatalog = new PropertyCatalog();
            SelectedIndex = 0;
            SelectedStringValues = SelectedAccommodation.ImagePaths.Select(p => new StringValue(p)).ToList();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class StringValue
    {
        public StringValue(string s)
        {
            Value = s;
        }
        public string Value { get; set; }
    }
}
