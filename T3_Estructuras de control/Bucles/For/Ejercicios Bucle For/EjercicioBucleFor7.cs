namespace EjercicioBucleFor7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Es hora de recolectar estrellas!");
            Random random = new Random();
            int estrellasRecolectadas = 0;

            for (int i = 0; i == 5; i++)
            {
                int estrellas = random.Next(1, 3)-1;
                // Si el número aleatorio es 1 significa que Mario ha recolectado esa estrella, si no lo recolecta el número es 0

                if (estrellas == 1)
                {
                    // Si el enemigo se ha recolectado se suma 1 al recuento de estrellas recolectadas.
                    estrellasRecolectadas += 1;
                    Console.WriteLine("Estrella" + i + " recolectada.");
                }
                else
                {
                    Console.WriteLine("Estrella " + i + " no recolectada.");
                }
                
            }

            // Si Mario ha recolectado 3 estrellas o más, se vuelve invencible. 
            if (estrellasRecolectadas >= 3)
            {
                Console.WriteLine("¡Mario es invencible!");
            }
           
        }
    }
}
