using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace EstructuraSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿En qué estado se encuentra Mario? ");
            string? estadoMario = Console.ReadLine();

            switch (estadoMario)
            {
                case "Idle":
                    Console.WriteLine("Super Mario está en estado de reposo");
                    break;
                case "Running":
                    Console.WriteLine("Super Mario está corriendo");
                    break;
                case "Jummping":
                    Console.WriteLine("Super Mario está saltando");
                    break;
                case "Attacking":
                    Console.WriteLine("Super Mario está atacando");
                    break;
                default:
                    Console.WriteLine("El estado de Super Mario es desconocido");
                    break;
            }
            
        }
    }
}
