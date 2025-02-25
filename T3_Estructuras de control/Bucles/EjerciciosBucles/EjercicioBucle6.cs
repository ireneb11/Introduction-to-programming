namespace EjercicioBucle6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool inicio;
            do
            {
                Console.Write("¿Quiere iniciar el nivel del juego? ");
                inicio = Convert.ToBoolean(Console.ReadLine());
            } while (inicio);
             
        }
    }
}
