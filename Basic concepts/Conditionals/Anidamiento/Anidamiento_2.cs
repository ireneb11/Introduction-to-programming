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
            Console.Write("¿Qué nivel de dificultad deseas activar? ");
            int nivel = Convert.ToInt32(Console.ReadLine());

            if (nivel <= 5)
            {
                Console.WriteLine("Modo fácil activado: Enemigos débiles.");
            }
            else if (nivel > 5 && nivel <= 10)
            {
                Console.WriteLine("Modo normal activado: Enemigos balanceados.");
            }
            else if (nivel > 10 && nivel <= 15)
            {
                Console.WriteLine("Modo difícil activado: Enemigos fuertes.");
            }
            else 
            {
                Console.WriteLine("Modo extremo activado: Enemigo IA desbloqueado.");
            }

        }
    }
}
