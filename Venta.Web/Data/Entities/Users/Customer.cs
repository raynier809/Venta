using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Venta.Web.Data.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        //TODO: Datos del cliente que no esten en usuario
        public User User { get; set; }
    }
}
