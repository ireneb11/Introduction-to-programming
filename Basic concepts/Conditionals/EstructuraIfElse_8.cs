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
            int muertesEnemigos = 0;
            int energia = 50;
            int energiaRequerida = 30;
            bool ataqueEspecialUsado = true;

            if (ataqueEspecialUsado && energia >= energiaRequerida)
            {
                muertesEnemigos++;
                energia -= 30;
                Console.WriteLine($"¡Ataque especial usado! Enemigos derrotados: {muertesEnemigos}");
                Console.WriteLine($"Energía restante: {energia}");
            }
            else
            {
                Console.WriteLine("No tienes suficiente energia para usar el ataque especial");
            }
            
        }
    }
}
