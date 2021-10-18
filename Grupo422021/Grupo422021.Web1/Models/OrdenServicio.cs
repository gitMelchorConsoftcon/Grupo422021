using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grupo422021.Web1.Models
{
    public class OrdenServicio
    {
        [Key]
        public int IdOrdenServicio { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public int IdCliente { get; set; }

        [Required]
        public int IdVehiculo { get; set; }

        [Required]
        public int IdMecanico { get; set; }

        
        public string Observaciones { get; set; }

        [Required]
        public int Estado { get; set; }

        //[NotMapped]
        [ForeignKey("IdMecanico")]
        public virtual Mecanico Mecanico { get; set; }

        [ForeignKey("IdCliente")]
        public virtual Cliente Cliente { get; set; }

        [ForeignKey("IdVehiculo")]
        public virtual Vehiculo Vehiculo { get; set; }

        public virtual List<OrdenServicioDetalle> OrdenServicioDetalle { get; set; }
    }
}


//[Foreignkey ]
//[NotMapped]