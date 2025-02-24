using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido al mundo acuatico!");

            bool estrella = false;
            bool flor = true;
            // Cambiar de false a true para probar casos diferentes 

            if (estrella)
            {
                Console.WriteLine("Mario nada rápido.");
            }
            else
            {
                if (flor)
                {
                    Console.WriteLine("Mario lanza bolas de fuego.");
                }
                else
                {
                    Console.WriteLine("Mario nada lentamente.");
                }
            }

        }
    }
}
