using System;
using System.Threading;

namespace HilosApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Thread hiloUno = new Thread(MetodoPorEjecturar);
            Thread hiloDos = new Thread(MetodoPorEjecturar);

            Console.WriteLine("Voy a ejecutar el hilo uno xD");
            hiloUno.Start();
            Console.WriteLine("Voy a jecutar el hilo dos xDD");
            hiloDos.Start();

            Thread.Sleep(1000); // El hilo principal se duerme

            //el join sirve para juntar los hilos al principal
            Console.WriteLine("El hilo uno se junta");
            hiloUno.Join();
            Console.WriteLine("El hilo dos se junta");
            hiloDos.Join();
            
        }

        static void MetodoPorEjecturar()
        {
            //To do: Aqui poner el codigo

            var hiloActual = Thread.CurrentThread; //aqui almacenamos el hilo actual xD
            Console.WriteLine("Hilo actual {0}: ", hiloActual.ManagedThreadId); //imprime quien es el hilo

            Console.WriteLine("Mi Cultura es {0} ", hiloActual.CurrentCulture); //Cultura en la que esta ejecutamdose el hilo actual

        }
    }
}
