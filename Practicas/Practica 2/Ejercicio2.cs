namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Luigi comenzo ahorrando el 1 de enero 3 monedas
            Console.Write("Ingrese el dia del año específico para saber la cantidad ahorrada: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            if (dia < 1 || dia > 365)
            {
                Console.WriteLine("El dia tiene que estar entre 1 y 365.");
                return;
            }

            double ahorroDiario = 1;
            for (int i = 1; i <= dia; i++)
            {
                ahorroDiario *= 3;
            }
            Console.WriteLine($"El ahorro total de Luigi en el dia {dia} es de {ahorroDiario} monedas.");

            // Cantidad ahorrada al final del año si cada dia ahorra el triple del dia anterior
            double ahorroTotal = 1;
            for (int j = 1; j <= 365; j++)
            {
                ahorroTotal *= 3;
            }
            Console.WriteLine("Al final del año habrá ahorrado un total de " + ahorroTotal + " monedas.");



        }
    }
}
