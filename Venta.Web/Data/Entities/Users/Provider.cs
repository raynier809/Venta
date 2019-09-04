using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Venta.Web.Data.Entities.Providers;

namespace Venta.Web.Data.Entities.Users
{
    public class Provider
    {
        public int Id { get; set; }

        public User User { get; set; }
        public ICollection<Orderpurchase> OrderPurchases { get; set; }
    }
}
