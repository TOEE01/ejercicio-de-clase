using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ejercico03.Models
{
    public class Estudiante
    {
        [Display(Name = "Nombre")]
        [Required(ErrorMessage ="Este campo {0} es requerido")]
        public string Nombre { get; set; }


        //[Display(Name = "Edad")]
        [Required(ErrorMessage = "Este campo {0} es requrido")]
        public int Edad { get; set; }


        //[Display(Name = "TipoDeEstudiante")]
        [Required(ErrorMessage = "Este campo {0} es requrido")]
        public string TipoDeEstudiante { get; set; }


        //[Display(Name = "Sexo")]
        [Required(ErrorMessage = "Este campo {0} es requrido")]
        public char Sexo { get; set; }
        

    }
}
