using PrimeraAppCore.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeraAppCore.Servicio
{
    public interface ICourse
    {
        void Insertar(Course c){}

        List<Course> Extraer(){
            List<Course> lista = new List<Course>();
            return lista;
        }
    }
}
