using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Venta.Web.Data.Entities
{
    public class BillDetails
    {
        public int Id { get; set; }

        public Bill Bill { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<Serialization> Serializations { get; set; }
    }
}
