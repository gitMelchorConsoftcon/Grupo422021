using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grupo422021.Web1.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required]
        [MaxLength(90)]
        public string Nombre { get; set; }

        [MaxLength(13)]
        [MinLength(11)]
        public string RFC { get; set; }

        [MaxLength(10)]
        [MinLength(10)]
        public string Telefono { get; set; }

        [MaxLength(200)]
        public string Correo { get; set; }
       
        [Required]
        public bool Activo { get; set; }


        public virtual List<OrdenServicio> OrdenServicio { get; set; }
        public virtual List<Vehiculo> Vehiculo { get; set; }


    }
}
