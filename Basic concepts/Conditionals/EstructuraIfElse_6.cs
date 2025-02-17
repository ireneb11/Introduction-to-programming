using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstructuraIf
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool escudoActivo = true;
            int duracionEscudo = 10; //Duración en segundos

            if (escudoActivo && duracionEscudo > 0)
            {
                Console.WriteLine($"Escudo activo. Duración restante {duracionEscudo} segundos.");
                Console.WriteLine($"Quedan {--duracionEscudo} segundos de escudo.");
            }
            else
            {
                Console.WriteLine($"Escudo inactivo.");
            }
        }
    }
}
