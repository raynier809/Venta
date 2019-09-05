using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Venta.Web.Data.Entities.Products
{
    public class Product_ProductCommission
    {
        public int Id { get; set; }

        public Product Product { get; set; }
        public ProductComimssion ProductComimssion { get; set; }
    }
}
