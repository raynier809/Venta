using System.ComponentModel.DataAnnotations;

namespace Venta.Web.Models
{
    public class AddUserViewModel : EditUserViewModel
    {
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string username { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password Confirm")]
        [Compare("Password")]
        public string PasswordConfrirm { get; set; }
    }
}
