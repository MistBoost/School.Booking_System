using School.OnlineBookingSystem.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using School.OnlineBookingSystem.Annotations;
using School.OnlineBookingSystem.Models;

namespace School.OnlineBookingSystem.ViewModels
{
    public class SearchPageVm
    {
        private PropertyCatalog _propertyCatalog;
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

         

        private void AutoSuggestBoxTextChangedM( object obj)
        {
            
        }

        private void CheckInDateChangedM(object obj)
        {
            Debug.WriteLine(obj.ToString());
        }

    
  

     
    }
}
