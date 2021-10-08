using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeraAppCore.Dominio
{
    public class Students
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }

        public String LastName { get; set; }

        public String FirstMidName { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public ICollection<EnrollMent> IEnrrollment { get; set; }
    }
}
