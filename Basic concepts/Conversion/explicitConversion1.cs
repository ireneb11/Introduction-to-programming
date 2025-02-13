using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace explicitConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte vidaJugador = 100;
            int daño = 25;
            
            vidaJugador -= (byte)daño; // Conversion explicita int a byte
            Console.WriteLine("Vida del jugador: " + vidaJugador);
        }
        //Other functions
    }
}

