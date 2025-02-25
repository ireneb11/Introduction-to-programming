using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int enemigos = 0;
            int puntaje = 0;
            
            do
            {
                enemigos++;
                puntaje += 30;
                Console.WriteLine($"Aparece un enemigo. Ahora hay {enemigos} enemigos.");

            } while ( puntaje <= 500 );
            Console.WriteLine("Mario ha alcanzado los 500 puntos");
        }
    }
}
