using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerNetCore2022.Models
{
    public class Coche
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Imagen { get; set; }
        public int Velocidad { get; set; }
        public int VelocidadMaxima { get; set; }
        public Coche()
        {
            this.Marca = "BatMovil";
            this.Modelo = "Antiguo";
            this.Imagen = "batmovil.jpg";
            this.Velocidad = 0;
            this.VelocidadMaxima = 120;
        }

        public int Acelerar()
        {
            this.Velocidad += 20;
            if (this.Velocidad >= this.VelocidadMaxima)
            {
                this.Velocidad = this.VelocidadMaxima;
            }
            return this.Velocidad;
        }

        public int Frenar()
        {
            this.Velocidad -= 20;
            if (this.Velocidad < 0)
            {
                this.Velocidad = 0;
            }
            return this.Velocidad;
        }
    }
}
