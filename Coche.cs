using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioDia5_Interface
{
    class Coche : IVehiculo
    {

        private int nafta;

        public Coche()
        {
            nafta = 0;
        }
        public Coche(int nafta)
        {
            this.nafta = nafta;
        }

        public void Conducir()
        {
            if(nafta > 0)
            { 
            Console.WriteLine("El coche esta conduciento");
            }
        }

        public bool CargarNafta(int cargar)
        {
            nafta += cargar;
            return true;
        }
    }
}
