namespace EjercicioBucle4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tiempo = 300;

            while (tiempo > 0)
            {
                tiempo--;
                Console.WriteLine($"Tiempo restante: {tiempo} segundos.");
            }

            if (tiempo <= 0)
            {
                Console.WriteLine("El tiempo se ha terminado");
            }
        }
    }
}
