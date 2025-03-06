namespace EjercicioBucleFor1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            Random random = new Random();

            for (int i = 1; i <= 10; i++)
            {
                // Generamos un número aleatorio, por ejemplo entre 1 y 100
                int bloquesMisteriosos = random.Next(1, 100);
                // Si el numero es par, imprime Flor de Fuego, si no, imprime Super Champiñon
                if (bloquesMisteriosos % 2 == 0)
                {
                    Console.WriteLine($"Bloques misteriosos: {bloquesMisteriosos}. -> Flor de Fuego");
                }
                else
                {
                    Console.WriteLine($"Bloques misteriosos: {bloquesMisteriosos}. -> Super Champiñon");
                }
            }
        }
    }
}
