using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace MANTENIMIENTO_APP.Models
{
    [Table("Empleados")]
    public class Empleado
    {
        [Column("EmpleadoId"), Key]
        public int Codigo { get; set; }
        [Required(ErrorMessage="El Apellido es obligatorio...")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El Nombre es obligatorio...")]
        public string Nombre { get; set; }
        [RegularExpression("[0-9]{8}",ErrorMessage = "Dìgitos hasta 8 caracteres...")]
        [Required(ErrorMessage = "El DNI es obligatorio...")]
        public string DNI { get; set; }
        [DataType(DataType.Date)]
        [Column("FechaNac"),DisplayFormat(ApplyFormatInEditMode=true, DataFormatString="{0:yyyy-MM-dd}")]
        public DateTime Nacimiento { get; set; }
    }
}