using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mario está ante un castillo...");
            Console.Write("¿Mario tiene la llave? ");
            bool llave = Convert.ToBoolean(Console.ReadLine());

            if (llave)
            {
                Console.WriteLine("Mario puede abrir la puerta.");
            }
            else
            {
                Console.Write("¿Mario tiene una estrella? ");
                bool estrella = Convert.ToBoolean(Console.ReadLine());
                if (estrella)
                {
                    Console.WriteLine("Mario derrota a los enemigos y encuentra la llave.");
                }
                else
                {
                    Console.WriteLine("Mario tiene que derrotar a los enemigos");
                }
            }

        }
    }
}
