using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrimeraAppCore.Dominio;
using PrimeraAppCore.Models;
using PrimeraAppCore.Models.ViewModel;
using PrimeraAppCore.Servicio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeraAppCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ICourse icourse;
        public HomeController(ILogger<HomeController> logger, ICourse icourse)
        {
            this.icourse = icourse;
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Course course = new Course();
            //course.Title = "POO";
            //course.Credits = 100;
            //icourse.Insertar(course);
            return View();
        }

        public IActionResult Insert(CourseViewModel courseVM)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", courseVM);
            }
            else
            {
                Course course = new Course
                {
                    Title = courseVM.Title,
                    Credits = courseVM.Credits
                };
                icourse.Insertar(course);
                //Obtener los datos
                List<Course> lista = icourse.Extraer();
                ViewBag.lista = lista;
                return View("ListaDeCursos");
            }
        }
        
        public ActionResult ListaDeCursos()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
