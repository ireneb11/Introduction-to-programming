namespace Bucle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool movingRight = true;
            int position = 0;

            while (movingRight)
            {
                position += 5;
                Console.WriteLine($"Mario avanza hasta la posición {position}.");

                // Simulamos una condición de parada, por ejemplo, si el jugador suelta la tecla
                if (position >= 100)
                {
                    movingRight = false;
                    Console.WriteLine("Mario deja de moverse.");
                }
            }

        }
    }
}
