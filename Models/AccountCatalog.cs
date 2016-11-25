using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.OnlineBookingSystem.Models
{
    public class AccountCatalog
    {
        public ObservableCollection<Account> Accounts { get; set; }
        public AccountCatalog()
        {
            Accounts = new ObservableCollection<Account>()
            {
                new Account("Julius", "pass", AccountTypes.Administrator),
                new Account("Harman", "pass", AccountTypes.Administrator)
            };
        }
    }
}
