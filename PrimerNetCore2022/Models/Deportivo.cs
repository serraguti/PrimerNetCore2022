using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerNetCore2022.Models
{
    //UN DEPORTIVO ES UNA INTERFACE ICOCHE
    public class Deportivo: ICoche
    {
        public Deportivo()
        {
            this.Marca = "Ferrari";
            this.Modelo = "Testarrossa";
            this.Imagen = "ferrari.jpg";
            this.Velocidad = 0;
            this.VelocidadMaxima = 320;
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Imagen { get; set; }
        public int Velocidad { get; set; }
        public int VelocidadMaxima { get; set; }

        public int Acelerar()
        {
            this.Velocidad += 40;
            if (this.Velocidad >= this.VelocidadMaxima) {
                this.Velocidad = this.VelocidadMaxima;
            }
            return this.Velocidad;
        }

        public int Frenar()
        {
            this.Velocidad -= 40;
            if (this.Velocidad < 0)
            {
                this.Velocidad = 0;
            }
            return this.Velocidad;
        }
    }
}
