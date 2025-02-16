namespace EstructuraIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el nombre del jugador: ");
            string? nombreJugador = Console.ReadLine();
            Console.Write("Ingrese la salud del jugador: ");
            int saludjugador = Convert.ToInt32(Console.ReadLine());

            if (saludjugador > 0)
            {
                Console.WriteLine($"El jugador {nombreJugador} está vivo");
                Console.WriteLine($"El jugador {nombreJugador} puede seguir en el juego");
            }
        }
    }
}
