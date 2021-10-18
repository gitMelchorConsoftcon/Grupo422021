using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Grupo422021.Web1.Models
{
    public class OrdenServicioDetalle
    {
     
        [Key]
        public int IdOrdenServicioDetalle { get; set; }

        [Required]
        public int IdOrdenServicio { get; set; }

        [Required]
        public int IdServicio { get; set; }

        [Required]
        [Column(TypeName = "decimal(6,2)")]
        public decimal Cantidad { get; set; }

        [Required]
        [Column(TypeName ="decimal(6,2)")]
        public decimal Costo { get; set; }

        [MaxLength(250)]
        public string Observaciones { get; set; }

        [ForeignKey("IdOrdenServicio")]
        public virtual OrdenServicio OrdenServicio { get; set; }


        [ForeignKey("IdServicio")]
        public virtual Servicio Servicio { get; set; }


    }
}
