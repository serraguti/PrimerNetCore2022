using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerNetCore2022.Controllers
{
    public class MatematicasController : Controller
    {
        [HttpGet]
        public IActionResult SumarNumeros()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SumarNumeros(int numero1, int numero2)
        {
            int suma = numero1 + numero2;
            ViewData["MENSAJE"] = "La suma de " + numero1 + " + " + numero2 + " es " + suma;
            return View();
        }
    }
}
