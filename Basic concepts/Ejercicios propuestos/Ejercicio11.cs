using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Power Up recogido: ");
            string? powerUp = Console.ReadLine();

            switch (powerUp)
            {
                case "Hongo":
                    Console.WriteLine("Mario se transforma en Super Mario!");
                    break;
                case "Flor de Fuego":
                    Console.WriteLine("Mario se transforma en Fire Mario!");
                    break;
                case "Superestrella":
                    Console.WriteLine("Mario se vuelve invencible!");
                    break;
                default:
                    Console.WriteLine("Mario sigue siendo normal");
                    break;
            }
        }
    }
}
