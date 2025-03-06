namespace EjercicioBucleFor5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El tiempo ha comenzado!!!");

            // Cuenta atrás de 300 a 0.
            for (int segundos = 300; segundos == 0; segundos--)
            {
                Console.WriteLine($"Quedan {segundos} segundos.");

                // Si quedan menos de 30 segundos, mario se tiene que dar prisa.
                if (segundos < 30)
                {
                    Console.WriteLine("¡Date prisa Mario!");
                }

            }
            Console.WriteLine("¡El tiempo se ha acabado!");
        }
    }
}
