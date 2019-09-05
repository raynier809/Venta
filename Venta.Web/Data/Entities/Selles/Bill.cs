using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Venta.Web.Data.Entities.Selles;
using System.ComponentModel.DataAnnotations;

namespace Venta.Web.Data.Entities
{
    public class Bill
    {
        public int Id { get; set; }

        //TODO: Agregar NCF, Compania, Almacen, Sucursal,Comprobante fiscal,

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-ddThh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Create Date")]
        public DateTime CreateDate { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-ddThh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-ddThh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Create Date")]
        public DateTime CreateDateLocal => CreateDate.ToLocalTime();

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-ddThh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "End Date")]
        public DateTime EndDateLocal => EndDate.ToLocalTime();

        public Seller Seller { get; set; }
        public Customer Customer { get; set; }
        public BillType BillType { get; set; }
        public BillCategory BillCategory { get; set; }

        public ICollection<BillDetails> BillDetails { get; set; }
    }
}
