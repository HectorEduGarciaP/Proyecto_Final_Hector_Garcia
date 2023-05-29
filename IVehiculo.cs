using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    interface IVehiculo
    {
        string Marca { get; set; }
        string Modelo { get; set; }
        string Color { get; set; }
        int Anio { get; set; }
        string Placa { get; set; }
        string Tipo { get; set; }
        int VelocidadMaxima { get; set; }
        int VelocidadActual { get; set; }
        string Bocina();
        int Acelerar(int cuanto);
        string Encender();
        string Apagar();
        int Frenar(int cuanto);
    }
}
