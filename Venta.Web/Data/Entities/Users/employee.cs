using System;
using System.ComponentModel.DataAnnotations;

namespace Venta.Web.Data.Entities
{
    public class employee
    {
        public int Id { get; set; }
        //TODO: Datos de los empleados que no esten en User
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:c2}", ApplyFormatInEditMode = false)]
        [Display(Name = "Salary")]
        public decimal Salary { get; set; }

        [Display(Name = "Weekly Hours")]
        public int WeeklyHours { get; set; }

        [Display(Name = "It Has Commission?")]
        public bool ItCommission { get; set; }

        [Display(Name = "Status")]
        public bool Status { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-ddThh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Create Date")]
        public DateTime StartDate { get; set; }        

        [Display(Name = "It has driver's license?")]
        public bool License { get; set; }

        public User User { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-ddThh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Create Date")]
        public DateTime StartDateLocal => StartDate.ToLocalTime();
    }
}
