using System;
using System.Threading;

namespace HilosApp
{
    class Program
    {
         public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           /* Thread hiloUno = new Thread(MetodoPorEjecturar);
            Thread hiloDos = new Thread(MetodoPorEjecturar);

            Console.WriteLine("La cultura del hilo principal es: {0}", Thread.CurrentThread.CurrentCulture);

            Console.WriteLine("Voy a ejecutar el hilo uno xD");
            hiloUno.Start();
            Console.WriteLine("Voy a jecutar el hilo dos xDD");
            hiloDos.Start();

            Thread.Sleep(1000); // El hilo principal se duerme

            //el join sirve para juntar los hilos al principal
            Console.WriteLine("El hilo uno se junta");
            hiloUno.Join();
            Console.WriteLine("El hilo dos se junta");
            hiloDos.Join();*/

            Thread corredor1 = new Thread(Carrera.Corredor);
            Thread corredor2 = new Thread(Carrera.Corredor);
            Thread corredor3= new Thread(Carrera.Corredor);
            Thread corredor4= new Thread(Carrera.Corredor);

            corredor1.Start();
            corredor2.Start();
            corredor3.Start();
            corredor4.Start();

            corredor1.Join();
            corredor2.Join();
            corredor3.Join();
            corredor4.Join();



        }

        static void MetodoPorEjecturar()
        {
            //To do: Aqui poner el codigo

            var hiloActual = Thread.CurrentThread; //aqui almacenamos el hilo actual xD
            hiloActual.CurrentCulture = new System.Globalization.CultureInfo("en-US"); //cambiar la cultura
            Console.WriteLine("Hilo actual {0}: ", hiloActual.ManagedThreadId); //imprime quien es el hilo

            Console.WriteLine("Mi Cultura es {0} ", hiloActual.CurrentCulture); //Cultura en la que esta ejecutamdose el hilo actual

            var random = new Random();
            for (int i =0; i <= 10; i++)
            {
                Console.WriteLine("Hilo {0} indice {1}", hiloActual.ManagedThreadId, i);

                Thread.Sleep(random.Next(500,2000));
            }

        }
    }
}
