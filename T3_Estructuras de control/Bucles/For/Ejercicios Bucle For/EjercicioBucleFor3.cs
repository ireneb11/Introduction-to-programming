using System;

namespace EjercicioBucleFor3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            // Recorremos 15 veces el bucle, 15 saltos
            for (int salto = 0; salto < 15; salto++)
            {
                // Generamos un numero aleatorio entre 0 y 1
                int saltarTubo = random.Next(1,3)-1;

                // Si el número aleatorio es 1 significa que Mario ha saltado correctamente, si es 0 significa que se ha caído.
                if ( saltarTubo == 1)
                {
                    Console.WriteLine("Salto exitoso.");
                }
                else
                {
                    Console.WriteLine("Mario se cayó");
                }
            }
        }
    }
}
