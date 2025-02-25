namespace EjercicioBucle9.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Recolecta los hongos!");
            int hongos = 0;
            do
            {
                hongos++;
                Console.WriteLine($"Mario ha recogido un hongo. Ahora tiene {hongos} hongos.");
            } while ( hongos < 5 );
        }
    }
}
