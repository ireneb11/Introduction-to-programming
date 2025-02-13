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
            float posicionX = 1125.67f;
            int pixelX = (int)posicionX; // Conversion explicita de float a int

            Console.WriteLine("Posición redondeada en pixeles: " + pixelX);
        }
        //Other functions
    }
}

