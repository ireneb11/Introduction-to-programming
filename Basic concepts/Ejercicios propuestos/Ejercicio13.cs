using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mario golpea un bloque...");
            Console.Write("¿Mario tiene una estrella? ");
            bool estrella = Convert.ToBoolean(Console.ReadLine());
            int monedas = 0;

            if (estrella)
            {
                monedas = 10;
            }
            else
            {
                Console.Write("¿Tiene el poder de Super Mario? ");
                bool superMario = Convert.ToBoolean(Console.ReadLine());
                if (superMario)
                {
                    monedas = 1;
                }
                else
                {
                    monedas = 0;
                }

            }
            Console.WriteLine("Mario obtiene " + monedas + " monedas.");
        }
    }
}
