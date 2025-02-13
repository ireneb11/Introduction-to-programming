using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace implicitConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vidaJugador = 100;
            byte daño = 25;    

            vidaJugador -= daño;  // Implicit conversion from byte to int
            Console.WriteLine("Vida del jugador: " + vidaJugador);
            Console.WriteLine("Tipo de dato de jugador: " + vidaJugador.GetType());

        }
        //Other functions
    }
}
