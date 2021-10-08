using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeraAppCore.Dominio
{
    public class EnrollMent
    {
        public enum EGrade {
            A, B, C, D
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnrollmentId { get; set; }

        public int CourseId { get; set; }

        public int StudentId { get; set; }

        public EGrade? Grade { get; set; }

        //Es opcional y hacen rereferncia a las llaves foraneas
        public Course Course { get; set; }

        public Students Student { get; set; }
    }
}
