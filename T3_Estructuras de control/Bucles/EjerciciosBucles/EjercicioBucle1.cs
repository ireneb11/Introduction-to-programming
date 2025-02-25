using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioBucle1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool corriendo = true;
            int tiempo = 200;

            while (corriendo)
            {
                tiempo -= 10;
                Console.WriteLine($"Tiempo restante {tiempo} segundos.");

                if (tiempo <= 0)
                {
                    corriendo = false;
                    Console.WriteLine("Mario deja de correr.");
                }
            }

        }
    }
}
