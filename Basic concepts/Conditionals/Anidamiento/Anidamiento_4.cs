using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace EstructuraIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese los puntos obtenidos durante el juego: ");
            int puntosJugador = Convert.ToInt32(Console.ReadLine());

            if (puntosJugador >= 100)
            {
                Console.WriteLine("¡Felicidades! Serás recompensado...");
                if (puntosJugador >= 200)
                {
                    string ms = "Estrella de oro";
                    Console.WriteLine("Has desbloqueado una nueva habilidad: " + ms);
                }
                else
                {
                    string ms = "Estrella de plata";
                    Console.WriteLine("Has desbloqueado una nueva habilidad: " + ms);
                }  
            }
            else
            {
                int puntosRestantes = 100 - puntosJugador;
                string ms = $"Te faltan {puntosRestantes} para alcanzar la meta inicial";
                Console.WriteLine("Sigue jugando, aún no tienes 100 puntos, " + ms);
            }
            

        }
    }
}
