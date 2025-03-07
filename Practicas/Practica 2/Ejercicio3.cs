namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float monedas = 1500f;
            float monedaMagica = 0.1f;
            // generamos un bucle que se repita 17 veces ya quequeremos obtener las monedas que tien despues de 17 años.
            for (int año = 1; año <= 17; año++)
            {
                monedas += (monedas * monedaMagica);
                Console.WriteLine("Después de " + año + " años tendrá: " + monedas);
            }
            Console.WriteLine("En los 17 años ha obtenido: " + monedas);  

        }
    }
}
