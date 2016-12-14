using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Appointments;
using Windows.UI.Xaml;
using School.OnlineBookingSystem.Annotations;
using School.OnlineBookingSystem.Common;
using School.OnlineBookingSystem.Models;
using School.OnlineBookingSystem.Views;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace School.OnlineBookingSystem.ViewModels
{
    public class CreateBookingVm : Catalog<Booking>, INotifyPropertyChanged
    {
        bool _aviableApartment = false;
        private string typeSelected { get; set; }
        public string TypeSelected
        {
            get { return typeSelected; }
            set
            {
                typeSelected = value;
                OnPropertyChanged(nameof(TypeSelected));
                TypeSelectedM();
            }
        }
        private DateTimeOffset checkInTime = DateTimeOffset.Now;
        private DateTimeOffset checkOutTime = DateTimeOffset.Now.AddYears(1);
        private DateTimeOffset maxDate = DateTimeOffset.Now.AddDays(365);
        public DateTimeOffset MaxDate
        {
            get { return maxDate; }
            set
            {
                maxDate = value;
                OnPropertyChanged(nameof(MaxDate));
            }
        }
        private DateTimeOffset minDate = DateTimeOffset.Now;
        public DateTimeOffset MinDate
        {
            get { return minDate; }
            set
            {
                minDate = value;
                OnPropertyChanged(nameof(MinDate));
            }
        }
        public DateTimeOffset CheckInDate
        {
            get { return checkInTime; }
            set
            {
                checkInTime = value;
                OnPropertyChanged(nameof(CheckInDate));
                MaxDate = CheckInDate.AddDays(365);
                MinDate = CheckInDate;
            }
        }

        public DateTimeOffset CheckOutDate
        {
            get { return checkOutTime; }
            set
            {
                checkOutTime = value;
                OnPropertyChanged(nameof(CheckOutDate));
            }
        }
        public DelegateCommand Book { get; set; }
        public Property _selectedProperty { get; set;}
        public LoggedUserSingleton UserSingleton { get; set; } = LoggedUserSingleton.Instance;
        public string CustomersName { get; set; }
        public string CustomersPhoneNumber { get; set; }
        public string CustomersEmail { get; set; }
        public int AdultsCount { get; set; }
        public int ChildrensCount { get; set; }
        public string Id { get; set; }
        private string ApartmentType { get; set; }
        public BookingCatalog BookingCat { get; set; }
        public TransportSingleton TransportSingleton { get; set; } = TransportSingleton.Instance;
        public ObservableCollection<string> apartSelectList { get; set; }
        public ObservableCollection<string> peopleSelectList { get; set; }
        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged(nameof(Price));

            }
        }


        public CreateBookingVm()
        {
            UserSingleton = LoggedUserSingleton.Instance;
            _selectedProperty = TransportSingleton.SelectedProp;
            BookingCat = new BookingCatalog(_selectedProperty.Name);
            if (UserSingleton.LoggedAccount != null)
            {
                CustomersName = UserSingleton.LoggedAccount.FullName;
                CustomersEmail = UserSingleton.LoggedAccount.Email;
                CustomersPhoneNumber = UserSingleton.LoggedAccount.PhoneNumber;
            }
            apartSelectList = new ObservableCollection<string>();
            peopleSelectList = new ObservableCollection<string>();
            foreach (var type in _selectedProperty.TypesOfApartments)
            {
                apartSelectList.Add(type.Key);
            }

            Book = new DelegateCommand(BookM);
        }

        private void TypeSelectedM()
        {
            peopleSelectList.Clear();
            for (int i = 1; i <= _selectedProperty.TypesOfApartments[TypeSelected].MaxPeople; i++)
            {
                peopleSelectList.Add(i.ToString());
            }
            Price = (CheckOutDate - CheckInDate).Days * _selectedProperty.TypesOfApartments[TypeSelected].Price;

        }
     

        private void BookM(object obj)
        {
            if (CanBook(typeSelected))
            {
                var tempBook = new Booking(CustomersName, CustomersPhoneNumber, CustomersEmail, CheckInDate, CheckOutDate, AdultsCount, ChildrensCount, Id, typeSelected);
                BookingCat.Collection.Add(tempBook);
                BookingCat.SaveCollection();
                MessageDialog Show = new MessageDialog("You Successfully booked vacation in " + _selectedProperty.Name + ". For " + Price.ToString("C0"), "Thank You!");
                Show.ShowAsync();
                var frame = Window.Current.Content as Frame;
                frame?.Navigate(typeof(MainPage));
            }
            else
            {
                MessageDialog Show = new MessageDialog("Sorry! There is no aviable apartments for this booking. ");
                Show.ShowAsync();
            }
        }

        private bool CanBook(string selectedApartmentType)
        {
        //    Id = _selectedProperty.ApartmentDic.FirstOrDefault(x => x.Value == selectedApartmentType).Key;
            int bestApartGap = 0;
            int bestApartGapBetweenBooking = 0;
            int bookingBeforeGap = 0, bookingAfterGap = 0;
            bool firstAviableApart = true, aviableApartment = false;
            foreach (var apartm in _selectedProperty.ApartmentDic)
            {
                int gapBetweenBookings = 0;
                int _bookingBeforeGap = 0, _bookingAfterGap = 0;
                if (apartm.Value == selectedApartmentType)
                {
                    _aviableApartment = true;
                        foreach (var booking in BookingCat.Collection)
                      {
                        if (booking.ApartmentId == apartm.Key)
                        {
                            if (CheckInDate > booking.CheckOutDate)
                            {
                                _aviableApartment = true;
                                if (bookingBeforeGap == 0)
                                {
                                    bookingBeforeGap = (CheckInDate - booking.CheckOutDate).Days;

                                }
                                else
                                {
                                    _bookingBeforeGap = (CheckInDate - booking.CheckOutDate).Days;
                                    if (bookingBeforeGap > _bookingBeforeGap)
                                    {
                                        bookingBeforeGap = _bookingBeforeGap;
                                    }
                                }
                            }
                            else if (CheckOutDate < booking.CheckInDate)
                            {
                                _aviableApartment = true;
                                if (bookingAfterGap == 0)
                                {
                                    bookingAfterGap = (booking.CheckInDate - CheckOutDate).Days;
                                }
                                else
                                {
                                    _bookingAfterGap = (booking.CheckInDate - CheckOutDate).Days;
                                    if (bookingAfterGap > _bookingAfterGap)
                                    {
                                        bookingAfterGap = _bookingAfterGap;
                                    }
                                }
                            }
                            else { _aviableApartment = false; break; }
                        }
                        else _aviableApartment = true;
                        }
                        if (_aviableApartment && firstAviableApart)
                    {
                        firstAviableApart = false;
                        Id = apartm.Key;
                        aviableApartment = true;
                    }
                
                }
                else _aviableApartment = false;
                if (_aviableApartment && BookingCat.Collection.Count != 0)
                {
                    if (bestApartGap == 0 )
                    {
                        if (bookingAfterGap != 0 && bookingBeforeGap != 0)
                        {
                            if (bookingAfterGap < bookingBeforeGap)
                            {
                                bestApartGap = bookingAfterGap;
                                bestApartGapBetweenBooking = bookingAfterGap + bookingBeforeGap;
                            }
                            else if (bookingBeforeGap <= bookingAfterGap)
                            {
                                bestApartGap = bookingBeforeGap;
                                Id = apartm.Key;
                                aviableApartment = true;
                                bestApartGapBetweenBooking = bookingAfterGap + bookingBeforeGap;
                            }
                        }
                    }
                    else
                    {
                        if (bestApartGap > bookingAfterGap && bookingAfterGap != 0)
                        {
                            bestApartGap = bookingAfterGap;
                            Id = apartm.Key;
                            aviableApartment = true;
                            bestApartGapBetweenBooking = bookingAfterGap + bookingBeforeGap;
                        }
                        else if (bestApartGap > bookingBeforeGap && bookingBeforeGap != 0)
                        {
                            bestApartGap = bookingBeforeGap;
                            Id = apartm.Key;
                            aviableApartment = true;
                            bestApartGapBetweenBooking = bookingAfterGap + bookingBeforeGap;
                        }
                        else if (bestApartGap == bookingAfterGap)
                        {
                            int _gapBetweenBooking = bookingAfterGap + bookingBeforeGap;
                            if (bestApartGapBetweenBooking > _gapBetweenBooking)
                            {
                                bestApartGap = bookingAfterGap;
                                Id = apartm.Key;
                                aviableApartment = true;
                                bestApartGapBetweenBooking = bookingAfterGap + bookingBeforeGap;
                            }
                        }
                        else if (bestApartGap == bookingBeforeGap)
                        {
                            int _gapBetweenBooking = bookingAfterGap + bookingBeforeGap;
                            if (bestApartGapBetweenBooking > _gapBetweenBooking)
                            {
                                bestApartGap = bookingBeforeGap;
                                Id = apartm.Key;
                                aviableApartment = true;
                                bestApartGapBetweenBooking = bookingAfterGap + bookingBeforeGap;
                            }
                        }
                    }
                }
            }
            
            return aviableApartment;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
