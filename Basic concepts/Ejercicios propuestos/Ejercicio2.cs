using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la altura del obstáculo: ");
            double alturaObstaculo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la altura del salto de Mario: ");
            int alturaSalto = Convert.ToInt32(Console.ReadLine());

            if ((int)alturaObstaculo > alturaSalto)
            {
                Console.WriteLine("¡Salto exitoso!");
            }
            else
            {
                Console.WriteLine("¡Mario ha chocado!");
            }

        }
    }
}
