using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de monedas recolectadas: ");
            int monedas = Convert.ToInt32(Console.ReadLine());
            bool puerta = true;

            if (puerta && monedas == 10)
            {
                Console.WriteLine("¡Puerta abierta!");
            }
            else
            {
                Console.WriteLine("¡Puerta cerrada!");
            }
        } 
    }
}
