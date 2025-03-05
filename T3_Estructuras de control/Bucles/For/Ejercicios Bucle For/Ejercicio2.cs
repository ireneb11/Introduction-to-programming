namespace EjercicioBucleFor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            float precioObjeto = 50;
            for (int nivel = 1; nivel < 10; nivel++)
            {
                int monedasRecolectadas = random.Next(0,1000);

                if (monedasRecolectadas > 100)
                {
                    precioObjeto *= 0.2f;
                    Console.WriteLine($"Monedas recolectadas en el nivel {nivel}: {monedasRecolectadas}. El precio del objeto es: " + precioObjeto);
                }
                else 
                {
                    Console.WriteLine("No tienes suficientes monedas para comprar.");
                }
            }
        }
    }
}
