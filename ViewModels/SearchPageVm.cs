﻿using School.OnlineBookingSystem.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using School.OnlineBookingSystem.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using School.OnlineBookingSystem.Views;
using System.ComponentModel;
using School.OnlineBookingSystem.Annotations;
using System.Runtime.CompilerServices;

namespace School.OnlineBookingSystem.ViewModels
{
    public class SearchPageVm : INotifyPropertyChanged
    {

        public DelegateCommand SearchCommand { get; set; }
        public string SearchInput { get; set; }
        private DateTimeOffset checkIn = DateTimeOffset.Now;
        private DateTimeOffset checkOut = DateTimeOffset.Now.AddDays(14);
        private DateTimeOffset maxDate = DateTimeOffset.Now.AddDays(365);
        public PropertyCatalog propCat;
        private Catalog<Property> _searchCatalog = new Catalog<Property>();
        public List<string> searchSource = new List<string>();
        private List<string> nameList, cityList, countryList;
        private Property _selectedProperty;
        private int _selectedIndex = -1;
        public TransportSingleton TransportSingleton { get; set; } = TransportSingleton.Instance;
        public MainFrameSingleton NavigationControl { get; set; }

        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set { _selectedIndex = value;
                OnPropertyChanged(nameof(SelectedIndex));
                if (_selectedIndex != -1)
                SelectedProperty = SearchCatalog.Collection[SelectedIndex];
            }
        }

        public Property SelectedProperty {
            get { return _selectedProperty; }
            set { _selectedProperty = value;
                OnPropertyChanged(nameof(SelectedProperty));
                TransportSingleton.Instance.SelectedProp = SelectedProperty;
            }
        }

        public Catalog<Property> SearchCatalog
        {
            get { return _searchCatalog; }
            set { _searchCatalog = value;
                OnPropertyChanged(nameof(SearchCatalog)); }
        }
        

        public DateTimeOffset CheckIn
        {
            get { return checkIn; }
            set
            {
                if (value >= DateTimeOffset.Now && CheckIn < maxDate)
                {
                    checkIn = value;
                    OnPropertyChanged(nameof(CheckIn));
                    TransportSingleton.Instance.CheckIn = CheckIn;
                    if (CheckOut < CheckIn)
                    {
                        TransportSingleton.Instance.CheckOut = DateTimeOffset.Now.AddDays(7);
                    }
                }
                else
                {
                    checkIn = DateTimeOffset.Now;
                    OnPropertyChanged(nameof(CheckIn));
                    TransportSingleton.Instance.CheckIn = CheckIn;
                    if (CheckOut < CheckIn)
                    {
                        TransportSingleton.Instance.CheckOut = DateTimeOffset.Now.AddDays(7);
                    }
                }
                }
        }
        public DateTimeOffset CheckOut
        {
            get { return checkOut; }
            set
            {
                if (value > DateTimeOffset.Now.AddDays(1))
                {
                    checkOut = value;
                    OnPropertyChanged(nameof(CheckOut));
                    TransportSingleton.Instance.CheckOut = CheckOut;
                    if (CheckOut < CheckIn) CheckIn = CheckOut.AddDays(-1);
                }
                else
                {
                    checkOut = CheckIn;
                    OnPropertyChanged(nameof(CheckOut));
                    TransportSingleton.Instance.CheckOut = CheckOut;
                    if (CheckOut < CheckIn) CheckIn = CheckOut.AddDays(-1);
                }
            }
        }
        public SearchPageVm()
        {
            NavigationControl = MainFrameSingleton.Instance;
            _searchCatalog = new Catalog<Property>();
            propCat = new PropertyCatalog();
            SearchCatalog = new Catalog<Property>();
            SearchCatalog.Collection = new ObservableCollection<Property>();
            SearchCommand = new DelegateCommand(SearchM);
            CheckIn = DateTimeOffset.Now;
            CheckOut = DateTimeOffset.Now.AddDays(7);
    }

        private void SearchM(object obj)
        {
            _selectedIndex = -1;
            SearchCatalog.Collection = new ObservableCollection<Property>();
            foreach (var property in propCat.Collection)
            {
                if (property.Name == SearchInput) _searchCatalog.Collection.Add(property);
                if (property.Location + " (" + property.Country + ")" == SearchInput) _searchCatalog.Collection.Add(property);
                if (property.Country == SearchInput) _searchCatalog.Collection.Add(property);
            }
            if (_searchCatalog != null) SearchCatalog = _searchCatalog;
        }

        public void SearchSource(string searchInput)
        {
            searchSource = new List<string>();
            cityList = new List<string>();
            countryList = new List<string>();
            nameList = new List<string>();
            string displayName;
            foreach (var prop in propCat.Collection)
            {
                displayName = prop.Name.ToLower();
                if (displayName.IndexOf(searchInput) != -1)
                {
                    nameList.Add(prop.Name);
                }
                displayName = prop.Location.ToLower();
                if (displayName.IndexOf(searchInput) != -1)
                {
                    if (!cityList.Contains(prop.Location))
                        cityList.Add(prop.Location + " (" + prop.Country + ")");
                }
                displayName = prop.Country.ToLower();
                if (displayName.IndexOf(searchInput) != -1)
                {
                    if (!countryList.Contains(prop.Country))
                        countryList.Add(prop.Country);
                }
            }
            searchSource = new List<string>();
            if (nameList.Count > 0)
            {
                searchSource.Add("----- PROPERTY NAME -----");
                searchSource.AddRange(nameList);
            }
            if (cityList.Count > 0)
            {
                searchSource.Add("--- SEARCH BY CITY ---");
                searchSource.AddRange(cityList);
            }
            if (countryList.Count > 0)
            {
                searchSource.Add("--- SEARCH BY COUNTRY ---");
                searchSource.AddRange(countryList);
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