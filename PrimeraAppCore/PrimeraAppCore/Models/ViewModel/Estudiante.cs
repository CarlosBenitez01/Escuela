using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeraAppCore.Models
{
    public class Estudiante
    {
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Campo requerido")]
        public String Nombre { get; set; }

        [Display(Name = "Edad")]
        [Range(0, 100, ErrorMessage = "Fuera de rango")]
        [Required(ErrorMessage = "Campo requerido")]
        public int Edad { get; set; }

        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "Campo requerido")]
        public String Sexo { get; set; }

        [Display(Name = "Nivel")]
        [Required(ErrorMessage = "Campo requerido")]
        public String Nivel { get; set; }

    }
}
