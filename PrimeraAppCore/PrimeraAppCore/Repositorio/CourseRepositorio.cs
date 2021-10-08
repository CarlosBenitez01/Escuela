using PrimeraAppCore.Data;
using PrimeraAppCore.Dominio;
using PrimeraAppCore.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeraAppCore.Repositorio
{
    public class CourseRepositorio : ICourse
    {
        //El servicio es solamente para decirle al repo como va a trabajar
        //El repo va a establecer la conexion y a aplicar la interface
        private ApplicationDbContext app;

        public CourseRepositorio(ApplicationDbContext app) {
            this.app = app;
        }

        public void Insertar(Course c) {
            app.Update(c);
            app.SaveChanges();
        }

        public List<Course> Extraer()
        {
            var lista = app.Courses.ToList();
            return lista;
        }
    }
}
