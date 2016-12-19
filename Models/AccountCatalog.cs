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
            Collection.Add(new Account("Julius Cizmar", "juli", "pass", "email@email.com", "27246461", AccountTypes.Administrator));
            Collection.Add(new Account("Harman Sidhu", "harm", "pass", "email@email.com", "27246461", AccountTypes.Administrator));
            Collection.Add(new Account("Emilis Gu", "emil", "pass", "email@email.com", "27246461", AccountTypes.Administrator));
            Collection.Add(new Account("Peter Lacko", "pete", "pass", "email@email.com", "27246461", AccountTypes.Administrator));
            Collection.Add(new Account("Rushika Gurung", "pete", "pass", "email@email.com", "27246461", AccountTypes.Administrator));
            SaveCollection();
        }
    }
}
