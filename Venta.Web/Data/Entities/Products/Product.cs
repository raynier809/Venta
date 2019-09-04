using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Venta.Web.Data.Entities.Products;

namespace Venta.Web.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Product Name")]
        public string Name { get; set; }


        [MaxLength(255, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:c2}", ApplyFormatInEditMode = false)]
        [Display(Name = "Purchase Price")]
        public decimal PurchasePrice { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:c2}", ApplyFormatInEditMode = false)]
        [Display(Name = "Sale Price")]
        public decimal SalePrice { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Barcode")]
        public string Barcode { get; set; }

        [Display(Name = "Is Avalible?")]
        public bool IsAvalible { get; set; }

        [Display(Name = "It has serie?")]
        public bool ItHasSerie { get; set; }

        public ProductCategory ProductCategory { get; set; }
        public ProductMarca ProductMarca { get; set; }
        public ProductType ProductType { get; set; }

        public ICollection<ProductComimssion> ProductCommissions { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }
    }
}
