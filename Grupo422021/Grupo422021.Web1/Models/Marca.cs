using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grupo422021.Web1.Models
{
    [Table("Marcas")]
    public class Marca
    {
        [Key]
        public int IdMarca { get; set; }

        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }

        [Required]
        public bool Activo { get; set; }


        public virtual List<Vehiculo> Vehiculo{ get; set; }
    }
}
