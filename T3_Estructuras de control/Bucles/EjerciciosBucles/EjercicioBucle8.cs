namespace EjercicioBucle8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mario ha tocado la bandera.");
            int alturaBandera = 0;
            do
            {
                alturaBandera++;
                Console.WriteLine("La bandera ha subido a la altura: " + alturaBandera);
            } while (alturaBandera < 10);

            Console.WriteLine("¡La bandera ha alcanzado la cima del mástil!");
        }
    }

}
