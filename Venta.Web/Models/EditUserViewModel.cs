using System.ComponentModel.DataAnnotations;

namespace Venta.Web.Models
{
    public class EditUserViewModel
    {
        [Display(Name = "Document")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Document { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Address { get; set; }

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Phone Number")]
        public string PhoneNumer { get; set; }
    }
}
