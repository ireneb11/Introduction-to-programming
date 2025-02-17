using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstructuraIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Ingrese tu nombre: ");
            string? nombreCiudadano = Console.ReadLine();
            Console.Write("Introduce tu edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce si tienes licencia (true/false): ");
            bool tieneLicencia = Convert.ToBoolean(Console.ReadLine());

            if (edad  >= 18 && tieneLicencia)
            {
                Console.WriteLine($"Ciudadano {nombreCiudadano}, usted está autorizado a conducir.");
            }
            else
            {
                Console.WriteLine($"Ciudadano {nombreCiudadano}, usted no está autorizado a conducir.");
            }
        }
    }
}
