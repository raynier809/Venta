using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Venta.Web.Data.Entities
{
    public class Seller
    {
        public int Id { get; set; }

        public User User { get; set; }
        public ICollection<Bill> Bills { get; set; }
    }
}
