using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Venta.Web.Data.Entities.Users
{
    public class UserImage
    {
        public int Id { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        //TODO: change  the path when publish
        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl) ? null : $"http://myleasing.somee.com{ImageUrl.Substring(1)}";

        public User User { get; set; }
    }
}
