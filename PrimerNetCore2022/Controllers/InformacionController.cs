using Microsoft.AspNetCore.Mvc;
using PrimerNetCore2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerNetCore2022.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult ControladorVista()
        {
            ViewData["NOMBRE"] = "Paco";
            ViewData["EDAD"] = 12;
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Apellidos = "Net Core";
            persona.Edad = 2022;
            return View(persona);
        }

        [HttpGet]
        public IActionResult VistaGet(string aplicacion, int version)
        {
            ViewData["Aplicacion"] = aplicacion;
            ViewData["Version"] = version;
            return View();
        }

        //METODO GET PARA VISTAPOST.CSHTML
        public IActionResult VistaPost()
        {
            return View();
        }

        //METODO POST PARA LA VISTAPOST.CSHTML
        [HttpPost]
        public IActionResult VistaPost(Persona persona)
        {
            return View(persona);
        }
    }
}
