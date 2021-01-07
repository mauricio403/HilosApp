using System;
using System.Threading;
namespace HilosApp
{
    class Carrera
    {
        public  static void Corredor(object obj)
        {
            var nombre = (string)obj;

            var hiloActual = Thread.CurrentThread;
            var pasos = 0;
            var random = new Random();

            while ( pasos < 10000 )
            {

                pasos += random.Next(0, 4);
                Console.WriteLine("Corredor {} dio {1} pasos", nombre, pasos);
                Thread.Sleep(10);


            }
            Console.WriteLine("El corredor {0} llego a la meta ",nombre);
        }
    }
}
