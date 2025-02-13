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
            // INT TO FLOAT
            int speed = 5;  //integer
            float deltaTime = 0.016f;  // Time between frames (~60 FPS)

            float movement = speed * deltaTime;  // Implicit conversion from int to float
            Console.WriteLine("Movement in this frame: " + movement);

        }
        //Other functions
    }
}
