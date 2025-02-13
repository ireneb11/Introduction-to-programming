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
            byte livesMario = 3;
            int maxLives = 5;    

           int remainingLives = maxLives - livesMario;  // Implicit conversion from byte to int
            Console.WriteLine("Remaining lives: " + remainingLives);

        }
        //Other functions
    }
}

