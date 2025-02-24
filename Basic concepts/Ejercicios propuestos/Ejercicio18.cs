using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mario tiene 5 vidas. ");
            bool saltoCorrecto = false; //Cambiar de true a false para probar diferentes resultados
            int vidasMario = 5;

            if (saltoCorrecto)
            {
                Console.WriteLine("Mario elimina a Goomba");
            }
            else
            {
                vidasMario--;
                Console.WriteLine("mario pierde una vida. Vidas restantes: " + vidasMario);
            }
        }
    }
}
