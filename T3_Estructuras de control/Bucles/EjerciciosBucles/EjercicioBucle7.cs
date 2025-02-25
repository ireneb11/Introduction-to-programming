namespace EjercicioBucle7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir;
            do
            {
                Console.Write("Has perdido. ¿Quieres volver a intentarlo? ");
                salir = Convert.ToBoolean(Console.ReadLine());
            } while (!salir);

        }
    }
}
