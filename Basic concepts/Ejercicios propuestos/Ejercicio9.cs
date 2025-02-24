using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de monedas obtenidas: ");
            int monedas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la cantidad de enemigos derrotados: ");
            int enemigosDerrotados = Convert.ToInt32(Console.ReadLine());

            if (monedas > 50 && enemigosDerrotados >= 10)
            {
                Console.WriteLine("¡Nivel secreto desbloqueado!");
            }
            else
            {
                Console.WriteLine("¡Sigue intentando!");
            }

        }
    }
}
