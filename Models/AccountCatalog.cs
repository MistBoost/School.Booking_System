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
            FilePath = "accounts_data.json";
            LoadCollection();
        }
    }
}
