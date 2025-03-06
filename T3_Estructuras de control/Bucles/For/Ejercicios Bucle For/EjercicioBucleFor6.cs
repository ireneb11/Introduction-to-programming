namespace EjercicioBucleFor6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int recuentoEnemigosDerrotados = 0;

            for (int enemigo = 0; enemigo == 100; enemigo++)
            {
                int enemigoDerrotado = random.Next(1, 3) - 1;

                // Si el numero aleatorio es 1 significa que Mario ha derrotado al enemigo, si no lo derrota el numero es 0
                if (enemigoDerrotado == 1)
                {
                    // Si el enemigo se ha derrotado se suma 1 al recuento de enemigos derrotados
                    recuentoEnemigosDerrotados += 1;
                    Console.WriteLine("Mario ha derrotado a este enemigo.");
                }
                else
                {
                    Console.WriteLine("Mario no ha derrotado a este enemigo.");
                }

            }
            // Si Mario ha derrotado a todos los enemigos entonces ha completado el nivel. 
            if (recuentoEnemigosDerrotados == 100)
            {
                Console.WriteLine("¡Nivel completado!");
            }
        }
    }
}
