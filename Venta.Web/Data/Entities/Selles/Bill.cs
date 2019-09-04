using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Venta.Web.Data.Entities
{
    public class Bill
    {
        public int Id { get; set; }

        public Seller Seller { get; set; }

        public Customer Customer { get; set; }

        public ICollection<BillDetails> BillDetails { get; set; }
    }
}
