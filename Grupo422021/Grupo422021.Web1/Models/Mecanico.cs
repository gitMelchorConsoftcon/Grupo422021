using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grupo422021.Web1.Models
{
    [Table("Mecanicos")]
    public class Mecanico
    {
        [Key]
        [Display(Name ="Codigo")]
        public int IdMecanico { get; set; }

        [Required(ErrorMessage ="El {0} es un dato obligatorio")]
        [MaxLength(35,ErrorMessage ="El {0} no puede temer mas de {1} caracteres")]
        public string Nombre { get; set; }

        [Required (ErrorMessage ="El {0} es un dato obligatorio")]
        [MaxLength(35)]
        [Display(Name = "Apellido paterno")]
        public string ApellidoPaterno { get; set; }

       
        [MaxLength(35)]
        [Display(Name = "Apellido materno")]
        public string ApellidoMaterno { get; set; }

        [MaxLength(10)]
        public string Telefono { get; set; }

        [NotMapped]
        public virtual List<OrdenServicio> OrdenServicio { get; set; }
    }
}

//Dataanotation

// Table ->propiedades de la tabla como el nombre
// Key -> convertir el campoo en primary key
// Required -> campo obligaotiro
// Maxlenght-> numero maximo de caracteres en los strings
// Display -> cambia el fotmato del campo