namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el articulo a comprar: ");
            string? articulo = Console.ReadLine();

            int precioBase = 0;

            switch (articulo)
            {
                case "hongo":
                    precioBase = 80;
                    break;
                case "estrella":
                    precioBase = 500;
                    break;
                case "flor de fuego":
                    precioBase = 165;
                    break;
                default:
                    Console.WriteLine("Articulo no encontrado");
                    break;
            }
            if (precioBase >= 200)
            {
                Console.WriteLine("Descuento del 15%");
                Console.WriteLine($"El precio del articulo {articulo} es {precioBase - (precioBase * 0.15)} euros.");
            }
            else if (precioBase > 100 && precioBase < 200)
            {
                Console.WriteLine("Descuento del 12%");
                Console.WriteLine($"El precio del articulo {articulo} es {precioBase - (precioBase * 0.12)} euros.");
            }
            else if (precioBase < 100)
            {
                Console.WriteLine("Descuento del 10%");
                Console.WriteLine($"El precio del articulo {articulo} es {precioBase - (precioBase * 0.10)} euros.");
            }
            
        }
    }
}
