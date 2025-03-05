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
                // Genera un numero aleatorio del 0 al 1000 por cada repetición del bucle.
                int monedasRecolectadas = random.Next(0,1000);

                // Si el numero aleatorio de monedas supera los 100€, entoces Mario puede comprar y se la aplica un descuento del 20%
                if (monedasRecolectadas > 100)
                {
                    precioObjeto *= 0.2f;
                    Console.WriteLine($"Monedas recolectadas en el nivel {nivel}: {monedasRecolectadas}. El precio del objeto es: " + precioObjeto);
                }
                else 
                {
                    Console.WriteLine($"Monedas recolectadas en el nivel {nivel}: {monedasRecolectadas}. No tienes suficientes monedas para comprar.");
                }
            }
        }
    }
}
