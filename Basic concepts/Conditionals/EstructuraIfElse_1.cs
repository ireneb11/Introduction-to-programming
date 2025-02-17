using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EstructuraIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool colisionConEnemigo = true;

            if (colisionConEnemigo)
            {
                Console.WriteLine("¡Colisión con enemigo detectada!");
            }
            else
            {
                Console.WriteLine("No hay colisiones.");
            }

        }
    }
}
