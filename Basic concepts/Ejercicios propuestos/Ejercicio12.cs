using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese qué come Yoshi (manzana, moneda o nada): ");
            string? comida = Console.ReadLine();

            if (comida == "manzana")
            {
                Console.WriteLine("Yoshi escupe fuego.");
            }
            else if (comida == "moneda")
            {
                Console.WriteLine("Yoshi guarda la moneda.");
            }
            else
            {
                Console.WriteLine("Yoshi sigue corriendo.");
            }
        }
    }
}


