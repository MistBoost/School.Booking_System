using System.Threading.Tasks;
using School.OnlineBookingSystem.Common;

namespace School.OnlineBookingSystem.Models
{
    public class AccountCatalog : Catalog<Account>
    {
        public AccountCatalog() : base("accounts_data.json")
        {
        }
    }
}
