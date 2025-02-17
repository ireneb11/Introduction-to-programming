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
            int puntosParaDesbloquear = 100;
            
            Console.Write("Ingrese el nombre del jugador: ");
            string? nombreJugador = Console.ReadLine();
            Console.Write("Ingrese los puntos del jugador: ");
            int puntosJugador = Convert.ToInt32(Console.ReadLine());

            if (puntosJugador  >= puntosParaDesbloquear)
            {
                Console.WriteLine($"¡Felicidades {nombreJugador} !");
                Console.WriteLine("Has desbloqueado una nueva etapa");
            }
            else
            {
                Console.WriteLine($" {nombreJugador}, te faltan {puntosParaDesbloquear - puntosJugador} para desbloquear la siguiente etapa.");
            }
        }
    }
}
