using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositorioProyectos repoProyectos;

        public HomeController(IRepositorioProyectos repositorioProyectos) 
        {
            this.repoProyectos = repositorioProyectos;

        }

        public IActionResult Index()
        {
            var proyectos = repoProyectos.ObtenerProyectos().Take(3).ToList();

            var modelo = new HomeIndex() {
                Proyectos = proyectos
            };
            return View(modelo);
        }

        public IActionResult Proyectos()
        {
            var proyectos = repoProyectos.ObtenerProyectos();
            return View(proyectos);  
        }

        public IActionResult Contact()
        {
            return View();  
        }

        public IActionResult Gracias()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Contacto contacto)
        {
            return RedirectToAction("Gracias");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}