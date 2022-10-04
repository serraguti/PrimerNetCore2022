using Microsoft.AspNetCore.Mvc;
using PrimerNetCore2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerNetCore2022.Controllers
{
    public class CochesController : Controller
    {
        //ESTA CLASE UTILIZAR OBJETOS DE TIPO COCHE
        private ICoche car;

        //POR AHORA, NO VOY A UTILIZAR DI
        public CochesController(ICoche car)
        {
            this.car = car;
        }

        public IActionResult Index()
        {
            return View(this.car);
        }

        [HttpPost]
        public IActionResult Index(string accion)
        {
            if (accion.ToLower() == "acelerar")
            {
                this.car.Acelerar();
            }
            else
            {
                this.car.Frenar();
            }
            return View(this.car);
        }
    }
}
