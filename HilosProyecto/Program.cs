using System;  // Importa funcionalidades básicas (como Console)
using System.Collections.Generic;
using System.Linq; // Proporciona funcionalidades para trabajar con consultas LINQ (Language Integrated Query)
using System.Text; // Proporciona clases para la manipulación de texto y codificaciones.
using System.Threading; // Necesario para trabajar con hilos (Thread)
using System.Threading.Tasks; // Ofrece tareas asincrónicas (no se usa en este ejemplo)

namespace HilosProyecto
{
    internal class Program //// Clase principal del programa

    {
        static void Main(string[] args) // // Método principal: punto de entrada del programa
        {
            Console.WriteLine(" Iniciando proceso de empacado..."); // Muestra mensaje de inicio

            // Crea cinco hilos, ambos ejecutarán el método Empacar
            Thread empacador1 = new Thread(Empacar);
            Thread empacador2 = new Thread(Empacar);
            Thread empacador3 = new Thread(Empacar);
            Thread empacador4 = new Thread(Empacar);
            Thread empacador5 = new Thread(Empacar);

            // Inicia los cinco hilos, pasando el nombre del empacador como parámetro
            empacador1.Start("Empacador 1");
            empacador2.Start("Empacador 2");
            empacador3.Start("Empacador 3");
            empacador4.Start("Empacador 4");
            empacador5.Start("Empacador 5");

            // Espera a que los cinco hilos terminen antes de continuar
            empacador1.Join();
            empacador2.Join();
            empacador3.Join();
            empacador4.Join();
            empacador5.Join();

            // Cuando los cinco hilos terminan, se muestra este mensaje final
            Console.WriteLine(" Todos los productos han sido empacados.");

        }
        // Método que simula el proceso de empacado por un trabajador
        static void Empacar(object nombre)  // Recibe un parámetro que representa el nombre del empacador
        {
            for (int i = 1; i <= 4; i++)  // Cada empacador empaca 4 productos
            {
                // Muestra qué empacador empacó qué producto
                Console.WriteLine($"{nombre} empacó producto {i}");

                // Simula el tiempo que tarda en empacar un producto (entre 700 y 1500 milisegundos)
                Thread.Sleep(new Random().Next(700, 1500));
            }

        }
    }
}
