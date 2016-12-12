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

namespace School.OnlineBookingSystem.ViewModels
{
    public class CreateBookingVm : Catalog<Booking>, INotifyPropertyChanged
    {
        bool _aviableApartment;
        public DelegateCommand CheckInDateChanged { get; set; }
        public DelegateCommand CheckOutDateChanged { get; set; }
        public DelegateCommand Book { get; set; }
        public Property _selectedProperty { get; set; }
        public string CustomersName { get; set; }
        public string CustomersPhoneNumber { get; set; }
        public string CustomersEmail { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int AdultsCount { get; set; }
        public int ChildrensCount { get; set; }
        public string Id { get; set; }
        private string ApartmentType { get; set; }
        public BookingCatalog BookingCat { get; set; }
        public TransportSingleton TransportSingleton { get; set; } = TransportSingleton.Instance;

        public CreateBookingVm()
        {
            _selectedProperty = TransportSingleton.SelectedProp;
            Book = new DelegateCommand(BookM);
        }



        private void BookM(object obj)
        {
            if (CanBook(ApartmentType))
            {
                var tempBook = new Booking(CustomersName, CustomersPhoneNumber, CustomersEmail, CheckInDate, CheckOutDate, AdultsCount, ChildrensCount, Id, ApartmentType);
                BookingCat = new BookingCatalog();
                BookingCat.Collection.Add(tempBook);
                BookingCat.SaveCollection();
            }
        }

        private bool CanBook(string selectedApartmentType)
        {
            FilePath = _selectedProperty.Name + ".json";
            LoadCollection();
            Id = _selectedProperty.ApartmentDic.FirstOrDefault(x => x.Value == selectedApartmentType).Key;
            int gapBetweenBookings = 0;
            int bestApartGap = 0;
            int bestApartGapBetweenBooking = 0;
            int _bookingBeforeGap, _bookingAfterGap;
            int bookingBeforeGap = 0, bookingAfterGap = 0;
            foreach (var apartm in _selectedProperty.ApartmentDic)
            {
                if (apartm.Value == selectedApartmentType)
                {
                    _aviableApartment = true;
                    foreach (var booking in Collection)
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
                            else _aviableApartment = false;
                        }
                        if (!_aviableApartment) break;
                    }
                }
                else _aviableApartment = false;
                if (_aviableApartment)
                {
                    if (bestApartGap == 0)
                    {
                        if (bookingAfterGap < bookingBeforeGap)
                        {
                            bestApartGap = bookingAfterGap;
                            Id = apartm.Key;
                            bestApartGapBetweenBooking = bookingAfterGap + bookingBeforeGap;
                        }
                        else if (bookingBeforeGap <= bookingAfterGap)
                        {
                            bestApartGap = bookingBeforeGap;
                            Id = apartm.Key;
                            bestApartGapBetweenBooking = bookingAfterGap + bookingBeforeGap;
                        }
                    }
                    else
                    {
                        if (bestApartGap > bookingAfterGap)
                        {
                            bestApartGap = bookingAfterGap;
                            Id = apartm.Key;
                            bestApartGapBetweenBooking = bookingAfterGap + bookingBeforeGap;
                        }
                        else if (bestApartGap > bookingBeforeGap)
                        {
                            bestApartGap = bookingBeforeGap;
                            Id = apartm.Key;
                            bestApartGapBetweenBooking = bookingAfterGap + bookingBeforeGap;
                        }
                        else if (bestApartGap == bookingAfterGap)
                        {
                            int _gapBetweenBooking = bookingAfterGap + bookingBeforeGap;
                            if (bestApartGapBetweenBooking > _gapBetweenBooking)
                            {
                                bestApartGap = bookingAfterGap;
                                Id = apartm.Key;
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
                                bestApartGapBetweenBooking = bookingAfterGap + bookingBeforeGap;
                            }
                        }
                    }
                }
            }
            return _aviableApartment;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
