using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Venta.Web.Data.Entities.Providers
{
    public class Orderpurchase
    {
        public int id { get; set; }
        public OrderpurchaseType OrderpurchaseType { get; set; }

        public ICollection<OrderpurchaseDetails> OrderPurchasesDetails { get; set; }

        
    }
}
