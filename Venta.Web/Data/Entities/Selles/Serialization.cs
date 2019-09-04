using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Venta.Web.Data.Entities
{
    public class Serialization
    {
        public int Id { get; set; }
        public Serializer Serializer { get; set; }

        public BillDetails BillDetails { get; set; }
    }
}
