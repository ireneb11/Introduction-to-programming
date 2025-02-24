using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Mario posee el poder del fuego? ");
            bool fuego = Convert.ToBoolean(Console.ReadLine());
            Console.Write("¿Mario posee el poder de la estrella? ");
            bool estrella = Convert.ToBoolean(Console.ReadLine());

            if (fuego && estrella)
            {
                Console.WriteLine("¡Invencible!");
            }
            else
            {
                Console.WriteLine("¡Cuidado!");
            }



        }
    }
}
