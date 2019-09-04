using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Venta.Web.Data.Entities
{
    public class ProductInventary
    {
        public int Id { get; set; }

        public Product Product { get; set; }

        public int Cantidad { get; set; }

    }
}
