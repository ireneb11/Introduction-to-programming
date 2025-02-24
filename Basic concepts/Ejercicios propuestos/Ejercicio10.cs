using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Personajes: Mario, Luigi, Toad y Peach");
            Console.Write("Selecciona personaje: ");
            string? personaje = Console.ReadLine();

            switch (personaje)
            {
                case "Mario":
                    Console.WriteLine("Habilidad especial: fuego");
                    break;
                case "Luigi":
                    Console.WriteLine("Habilidad especial: estrella");
                    break;
                case "Toad":
                    Console.WriteLine("Habilidad especial: salto triple");
                    break;
                case "Peach":
                    Console.WriteLine("Habilidad especial: flotar");
                    break;
                default:
                    Console.WriteLine("No exixte ese personaje");
                    break;
            }
        }
    }
}
