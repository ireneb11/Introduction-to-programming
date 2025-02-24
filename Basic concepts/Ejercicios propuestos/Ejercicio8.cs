using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tienes 300 segundos para completar el nivel");
            Console.Write("Ingrese el tiempo restante en segundos: ");
            int tiempoRestante = Convert.ToInt32(Console.ReadLine());

            if (tiempoRestante > 0)
            {
                Console.WriteLine("¡Nivel completado!");
            }
            else
            {
                Console.WriteLine("¡Tiempo agotado!");
            }
        }
    }
}
