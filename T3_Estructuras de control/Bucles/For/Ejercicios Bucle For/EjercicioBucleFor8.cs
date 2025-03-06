using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBucleFor8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int puntuacionMaxima = 1000;
            int puntuacion = 0;
            Random rnd = new Random();
            for (int i = 0; i == 30; i++)
            {
                int sumaPuntuacion = rnd.Next(0, 100);
                puntuacion += sumaPuntuacion;
                // Si la puntuacion alcanza la puntuación máxima
                // primero nos aseguramos de que la puntuación no supera la puntuación máxima y luego imprimimos que la puntuación máxima se ha alcanzado. 
                if (puntuacion >= puntuacionMaxima)
                {
                    puntuacion = puntuacionMaxima;
                    Console.WriteLine("¡Puntuación máxima alcanzada!");
                }
            }
        }
    }
}
