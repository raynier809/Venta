using System.ComponentModel.DataAnnotations;

namespace Venta.Web.Data.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        //TODO: change  the path when publish
        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl) ? null : $"http://myleasing.somee.com{ImageUrl.Substring(1)}";

        public Product Product { get; set; }

    }
}
