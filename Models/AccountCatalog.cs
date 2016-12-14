using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Xml.Linq;
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
