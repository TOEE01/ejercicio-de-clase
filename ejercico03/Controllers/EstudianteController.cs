using ejercico03.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercico03.Controllers
{
    public class EstudianteController : Controller
    {
        [HttpPost]
        public IActionResult Index(Estudiante estudiante)
        {
            if (ModelState.IsValid)
            {
                return View ("Registro");
            }
            else
            {
                return Redirect("Estudiante/Index");
            }
            
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registro()
        {
            return View();
        }
    }
}
