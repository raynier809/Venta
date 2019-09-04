using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Venta.Web.Data.Entities
{
    public class Log
    {
        public int Id { get; set; }

        public employee Employee { get; set; }

        //TODO: Usuario afectado (Cliente, Provedor, Etc).
        public User User { get; set; }

        //TODO: Aqui van las acciones que se almacenara (Modificacion,Eliminar,Agregar cualquier cosa)
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Action")]
        public string Action { get; set; }

        //TODO: Aqui van los mensajes de las alteraciones o creacion de lo que sea.
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Message")]
        public String Message { get; set; }


        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-ddThh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Create Date")]
        public DateTime CreateDate { get; set; }


        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-ddThh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Create Date")]
        public DateTime CreateDateLocal => CreateDate.ToLocalTime();


    }
}
