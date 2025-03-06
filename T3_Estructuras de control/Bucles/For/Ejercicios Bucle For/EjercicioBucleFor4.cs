using System;

namespace EjercicioBucleFor4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int recuentoEnemigosDerrotados = 0;

            for (int enemigo = 0; enemigo < 20; enemigo++)
            {
                // Se genera un numero aleatorio entre 1 y 2
                int enemigoDerrotado = random.Next(1, 3)-1;
             
                // Si el número aleatorio es 1 significa que mario ha derrotado al enemigo, si no lo derrota el numero es 0
                if (enemigoDerrotado == 1)
                {
                    // Si el enemigo se ha derrotado se suma 1 al recuento de enemigos derrotados
                    recuentoEnemigosDerrotados += 1;
                    Console.WriteLine($"Mario ha derrotado a este enemigo.");
                }
                else
                {
                    Console.WriteLine("Mario no ha derrotado a este enemigo.");
                }

            }
            // Si el total de enemigos derrotados es mayor de 10 entonces Mario es invencible
            if ( recuentoEnemigosDerrotados > 10)
                {
                    Console.WriteLine("¡Mario es invencible!");
                }
        }
    }
}
