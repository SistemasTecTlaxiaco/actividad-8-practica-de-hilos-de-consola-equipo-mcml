using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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

        }

    }
}
}
