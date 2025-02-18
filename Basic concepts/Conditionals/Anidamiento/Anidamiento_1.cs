using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anidamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Con qué objeto quiere interctuar? ");
            string? objeto = Console.ReadLine();

            if (objeto == "enemigo")
            {
                Console.WriteLine("¡Has sido golpeado por un enemigo! Pierdes una vida.");
            }
            else if (objeto == "moneda")
            {
                Console.WriteLine("¡Has recogido una moneda! +10 puntos.");
            }
            else if (objeto == "poción")
            {
                Console.WriteLine("¡Has recogido una poción! Vida restaurada.");
            }
            else 
            {
                Console.WriteLine("No hay interacción con este objeto.");
            }

        }
    }
}
