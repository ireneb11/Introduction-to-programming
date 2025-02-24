using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mario vs Browser");
            Console.Write("¿Mario tiene una estrella? ");
            bool estrella = Convert.ToBoolean(Console.ReadLine());

            switch (estrella)
            {
                case true:
                    Console.WriteLine("Mario gana automáticamente.");
                    break;
                case false:
                    Console.Write("Elige un ataque: ");
                    string? ataque = Console.ReadLine();
                    switch (ataque)
                    {
                        case "salto":
                            Console.WriteLine("Mario se hace daño");
                            break;
                        case "fuego":
                            Console.WriteLine("Browser pierde el 15% de vida");
                            break;
                        case "Martillo":
                            Console.WriteLine("Browser pierde el 30% de vida");
                            break;
                        case null:
                            Console.WriteLine("Ese ataque no esta registrado");
                            break;
                    }
                    break;
            }
        }

        
    }
}
