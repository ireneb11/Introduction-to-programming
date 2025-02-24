using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántas monedas ha recolectado Mario? ");
            int monedasRecolectadas = Convert.ToInt32(Console.ReadLine());
            double valorPuntos = monedasRecolectadas;

            if (valorPuntos > 100)
            {
                Console.WriteLine("¡Nivel completado!");
            }
            else
            {
                Console.WriteLine("¡Sigue intentando!");

            }
        }
    }
}
