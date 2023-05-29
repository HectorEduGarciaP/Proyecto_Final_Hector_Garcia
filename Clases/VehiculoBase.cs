using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Clases
{
    
    internal class VehiculoBase : IVehiculo
    {
        private int Fren = 0;

        public bool Prender = false;

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Anio { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public int VelocidadMaxima { get;  set; }
        public int VelocidadActual { get;  set; }

        public string Bocina()
        {

            return ("Bocina del vehículo >>>> Piiiiiip");
        }


        public string Encender()
        {

            if (Prender)
            {

                return ("El carro ya esta encendido");


            }
            else
            {
                Prender = true;
                return ("Encendiendo el carro");
            }
        }

        public string Apagar()
        {

            if (Prender)
            {
                Fren = 0;
                Prender = false;
                return ("Apagando el carro");


            }
            else
            {

                return ("El auto no esta encendido");

            }

        }
        public int Acelerar(int cuanto)
        {
            if (Prender)
            {
                Fren += 10;
                Console.WriteLine("Acelerando a {0} unidades", Fren);
                return Fren;

            }
            else
            {
                Console.WriteLine("El carro esta apagado no puedes Acelerar si esta pagado");
                return 0;
            }
        }

        public int Frenar(int cuanto)
        {

            if (Prender)
            {
                Fren -= 10;
                Console.WriteLine("Frenando el vehículo en {0} unidades", Fren);
                return Fren;

            }
            else
            {
                Console.WriteLine("El carro esta apagado no puedes frenar si esta pagado");
                return 0;
            }
            
        }

        public int FrenActual
        {
            get { return Fren; }
            set { Fren = value; }
        }

    }
}