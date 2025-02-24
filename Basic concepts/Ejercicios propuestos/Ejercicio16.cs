using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mario encuentra una tuberia verde...");
            Console.Write("¿Mario tiene la llave? ");
            bool llave = Convert.ToBoolean(Console.ReadLine());

            if (llave)
            {
                Console.WriteLine("Mario entra a un nivel secreto.");
            }
            else
            {
                Console.Write("¿Mario tiene una estrella? ");
                bool estrella = Convert.ToBoolean(Console.ReadLine());
                if (estrella)
                {
                    Console.WriteLine("Mario puede destruir la tubería y encontrar una llave.");
                }
                else
                {
                    Console.WriteLine("Mario tiene que segui adelante.");
                }
            }
        }
    }
}
