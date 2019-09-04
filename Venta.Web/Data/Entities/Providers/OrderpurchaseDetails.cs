using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Venta.Web.Data.Entities.Users;

namespace Venta.Web.Data.Entities.Providers
{
    public class OrderpurchaseDetails
    {
        public int Id { get; set; }

        public Provider  Provider { get; set; }        

        public Orderpurchase OrderPurchase { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
