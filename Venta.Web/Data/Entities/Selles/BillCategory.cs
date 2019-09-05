using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Venta.Web.Data.Entities.Selles
{
    public class BillCategory
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Bill Type")]
        public string Name { get; set; }

        public ICollection<Bill> Bills { get; set; }
    }
}
