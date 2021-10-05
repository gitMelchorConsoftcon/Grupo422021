using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grupo422021.Web1.Models
{
    [Table("Vehiculos")]
    public class Vehiculo
    {
        [Key]
        public int IdVehiculo { get; set; }

        [Required]
        [MaxLength(10)]
        public string Placa { get; set; }

        [Required]
        public int IdMarca { get; set; }

        [MaxLength(30)]
        public string Modelo { get; set; }

        [Required]
        public int Color { get; set; }

        [Required]
        public  int  IdCliente { get; set; }

        [Required]
        public bool Activo { get; set; }

        [ForeignKey("IdCliente")]
        public virtual Cliente Cliente { get; set; }

        [ForeignKey("IdMarca")]
        public virtual Marca Marca { get; set; }

        public virtual List<OrdenServicio> OrdenServicio { get; set; }
    }
}
