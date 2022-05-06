using System;

namespace EjercicioDia5_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flagNafta = true;
            Coche coche = new Coche();
            Console.WriteLine("Por favor indique el combustible que le añadira al auto");
            do
            {
                try
                {
                    coche.CargarNafta(int.Parse(Console.ReadLine()));
                    flagNafta = true;
                }catch
                {
                    flagNafta = false;
                }
            } while (!flagNafta);

            coche.Conducir();
        }


    }
}
