using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.OnlineBookingSystem.Common;

namespace School.OnlineBookingSystem.Models
{
    public class AccountCatalog : Catalog<Account>
    {
        public AccountCatalog()
        {
            Collection = new ObservableCollection<Account>()
            {
                new Account("Julius Cizar", "Julius", "pass", "27246461", "julius.cizmar@gmail.com", AccountTypes.Administrator),
                new Account("Julius Cizar", "Julius", "pass", "27246461", "julius.cizmar@gmail.com", AccountTypes.Administrator),
                new Account("Julius Cizar", "Julius", "pass", "27246461", "julius.cizmar@gmail.com", AccountTypes.Administrator),
                new Account("Julius Cizar", "Julius", "pass", "27246461", "julius.cizmar@gmail.com", AccountTypes.Administrator),
                new Account("Julius Cizar", "Julius", "pass", "27246461", "julius.cizmar@gmail.com", AccountTypes.Administrator)
            };
            SaveCollection();
        }
    }
}
