using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioBucle3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mario está atacando a Bowser");
            bool ataque = true;
            int vidaBowser = 105;
            int golpes = 0;

            while (ataque)
            {
                golpes++;
                vidaBowser -= 10;
                Console.WriteLine($"Bowser tiene {vidaBowser} puntos de vida.");

                if (vidaBowser <= 0)
                {
                    ataque = false;
                    Console.WriteLine($"Mario ha derrotado a Bowser, ha necesitado de {golpes} golpes.");
                }
            }
                
        }
    }
}
