using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grupo422021.Web1.Models
{
    [Table("Servicios")]
    public class Servicio
    {

        [Key]
        [Display(Name ="Codigo")]
        public int IdServicio { get; set; }

        [Required(ErrorMessage ="El {0} es un valor obligatorio")]
        [MaxLength(25,ErrorMessage ="El {0} no pude contener mas de {1} caracteres")]
        [Display(Name ="Nombre de servicio")]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        [Required]
        [Display(Name ="Estatus")]
        [UIHint("Activo")]
        public bool Activo { get; set; }

        public virtual List<OrdenServicioDetalle> OrdenServicioDetalle { get; set; }
    }
}
