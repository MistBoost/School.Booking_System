using School.OnlineBookingSystem.Common;
using System;
using System.Diagnostics;

namespace School.OnlineBookingSystem.ViewModels
{
    public class SearchPageVm
    {
        public DelegateCommand AutoSuggestBoxTextChanged { get; set; }
        public DelegateCommand CheckInDateChanged { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }
        
        public SearchPageVm()
        {
            CheckIn = DateTime.Today;
            CheckOut = DateTime.Today;
            AutoSuggestBoxTextChanged = new DelegateCommand(AutoSuggestBoxTextChangedM);
            CheckInDateChanged = new DelegateCommand(CheckInDateChangedM);
        }

        private void AutoSuggestBoxTextChangedM(object obj)
        {
            
        }

        private void CheckInDateChangedM(object obj)
        {
            Debug.WriteLine(obj.ToString());
        }
    }
}
