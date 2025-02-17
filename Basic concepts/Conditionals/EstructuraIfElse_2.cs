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
            Console.Write("Ingrese el nombre del jugador: ");
            string? nombreJugador = Console.ReadLine();
            Console.Write("Ingrese la salud del jugador: ");
            int vidajugador = Convert.ToInt32(Console.ReadLine());

            if (vidajugador > 0)
            {
                Console.WriteLine($"El jugador {nombreJugador} está vivo");
            }
            else
            {
                Console.WriteLine($"El jugador {nombreJugador} ha muerto.");
            }
        }
    }
}
