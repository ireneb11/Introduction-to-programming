using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstructuraIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa la vida actual del jugador: ");
            int vidaJugador = Convert.ToInt32(Console.ReadLine());

            if (vidaJugador > 75)
            {
                Console.WriteLine("El enemigo usa un ataque ligero.");
            }
            else if (vidaJugador > 50 && vidaJugador <= 75)
            {
                Console.WriteLine("El enemigo usa un ataque medio.");
            }
            else if (vidaJugador > 25 && vidaJugador <= 50)
            {
                Console.WriteLine("El enemigo usa un ataque fuerte.");
            }
            else 
            {
                string cad = "Preparate para el nuevo ataque!";
                Console.WriteLine("El enemigo usa su  ataque definiitivo. " + cad);
            }

        }
    }
}
