using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Venta.Web.Data.Entities;

namespace Venta.Web.Models
{
    public class ProductViewModel: Product
    {
        [Display(Name = "Product Categories")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Range(1, int.MaxValue, ErrorMessage = "You moust select a Product category.")]
        public int ProductCategoryId { get; set; }
        public IEnumerable<SelectListItem> ProductCategories { get; set; }

        [Display(Name = "Product Marca")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Range(1, int.MaxValue, ErrorMessage = "You moust select a Product marca.")]
        public int ProductMarcaId { get; set; }
        public IEnumerable<SelectListItem> ProductMarcas { get; set; }

        [Display(Name = "Product Type")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Range(1, int.MaxValue, ErrorMessage = "You moust select a Product type.")]
        public int ProductTypeId { get; set; }
        public IEnumerable<SelectListItem> ProductTypes { get; set; }
    }
}
