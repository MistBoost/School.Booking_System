using System.Collections.ObjectModel;
using School.OnlineBookingSystem.Common;

namespace School.OnlineBookingSystem.Models
{
    public class AccountCatalog : Catalog<Account>
    {
        public AccountCatalog()
        {
            FilePath = "accounts_data.json";
            Collection = new ObservableCollection<Account>()
            {
                new Account("Julius Cizmar", "juli714", "pass", "emiasdlfkj", "asdoisajd", AccountTypes.Administrator),
                new Account("Julius Cizmar", "orange", "pass", "emiasdlfkj", "asdoisajd", AccountTypes.Administrator),
                new Account("Julius Cizmar", "asd", "pass", "emiasdlfkj", "asdoisajd", AccountTypes.Administrator)
            };
            SaveCollection();
        }
    }
}
