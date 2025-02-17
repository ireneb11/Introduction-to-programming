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
            int enemigosRequeridos = 100;
            
            Console.Write("Ingrese el nombre del jugador: ");
            string? nombreJugador = Console.ReadLine();
            Console.Write("Introduce la cantidad de enemigos derrotados: ");
            int enemigosDerrotados = Convert.ToInt32(Console.ReadLine());

            if (enemigosDerrotados  >= enemigosRequeridos)
            {
                Console.WriteLine($"¡Misión completada! {nombreJugador} has derrotado a todos los enemigos.");
            }
            else
            {
                int enemigosDerrotar = enemigosRequeridos - enemigosDerrotados;
                Console.WriteLine($" ¡Misión en progreso! {nombreJugador} aun te faltan {enemigosDerrotar} enemigos por derrotar.");
            }
        }
    }
}
