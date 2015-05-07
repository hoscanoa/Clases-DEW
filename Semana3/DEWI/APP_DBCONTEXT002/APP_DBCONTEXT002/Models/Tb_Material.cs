using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace APP_DBCONTEXT002.Models
{
    public class Tb_Material
    {
        [Required(ErrorMessage = "Ingrese el ID")]
        [RegularExpression("[0-9]{3}", ErrorMessage = "Solo hasta 3 digitos")]
        [Key]
        public int idmat { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese la descripcion")]
        public string desmat { get; set; }

        [Required(AllowEmptyStrings=false, ErrorMessage="Ingrese la categoria")]
        [RegularExpression("[C][0-9]{4}", ErrorMessage="Error de Ingreso")]
        public string catmat{get; set;}

        [Required(ErrorMessage="Ingrese el precio")]
        [Range(1,500,ErrorMessage="Entre 1 y 500")]
        public decimal preuni{get; set;}

        [Required(ErrorMessage="Ingrese el stock")]
        [Range(1,1000,ErrorMessage="Entre 1 y 1000")]
        public int stock{get; set;}

    }
}