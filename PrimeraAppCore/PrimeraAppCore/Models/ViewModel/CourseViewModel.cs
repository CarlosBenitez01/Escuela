using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeraAppCore.Models.ViewModel
{
    public class CourseViewModel
    {
        [Display(Name = "Course title")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public String Title { get; set; }

        [Display(Name = "Credits")]
        [Range(0, int.MaxValue, ErrorMessage = "No valido")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public int Credits { get; set; }
    }
}
