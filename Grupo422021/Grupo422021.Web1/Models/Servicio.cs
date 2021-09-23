using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grupo422021.Web1.Models
{
    [Table("Servicios")]
    public class Servicio
    {

        [Key]
        public int IdServicio { get; set; }

        [Required(ErrorMessage ="El {0} es un valor obligatorio")]
        [MaxLength(25,ErrorMessage ="El {0} no pude contener mas de {1} caracteres")]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        [Required]
        public bool Activo { get; set; }
    }
}
