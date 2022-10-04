using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerNetCore2022.Models
{
    public interface ICoche
    {
        //DECLARAMOS TODAS LAS PROPIEDADES DE CUALQUIER OBJETO COCHE
        string Marca { get; set; }
        string Modelo { get; set; }
        string Imagen { get; set; }
        int Velocidad { get; set; }
        int VelocidadMaxima { get; set; }
        int Acelerar();
        int Frenar();
    }
}
