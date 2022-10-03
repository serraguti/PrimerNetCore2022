using Microsoft.AspNetCore.Mvc;
using PrimerNetCore2022.Models;
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

        [HttpGet]
        public IActionResult TablaMultiplicarEnteros()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicarEnteros(int numero)
        {
            List<int> coleccion = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                int operacion = numero * i;
                coleccion.Add(operacion);
            }
            return View(coleccion);
        }

        [HttpGet]
        public IActionResult TablaMultiplicarObjetos()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicarObjetos(int numero)
        {
            List<ElementoTabla> coleccion = new List<ElementoTabla>();
            for (int i = 1; i <= 10; i++)
            {
                ElementoTabla elemento = new ElementoTabla();
                elemento.Operacion = numero + " * " + i;
                elemento.Resultado = numero * i;
                coleccion.Add(elemento);
            }
            return View(coleccion);
        }
    }
}
