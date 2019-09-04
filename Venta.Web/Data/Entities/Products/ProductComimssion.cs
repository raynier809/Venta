using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Venta.Web.Data.Entities.Products
{
    public class ProductComimssion
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal CommissionPreci { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
