using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeraAppCore.Dominio
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }

        public String Title { get; set; }

        public int Credits { get; set; }

        //Con esto indico que hay una relacion entre course y entollment
        public ICollection<EnrollMent> IEnrollment { get; set; }
    }
}
