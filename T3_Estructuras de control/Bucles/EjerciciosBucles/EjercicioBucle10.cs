namespace EjercicioBucle10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Presiona la tecla B par que Mario corra.");
            char tecla;
            do
            {
                tecla = Console.ReadKey(true).KeyChar; // Lee la tecla sin mostrarla. Para mostrar la tecla usada, cambiar true por false.
            } while (tecla != 'B' && tecla != 'b');  // El programa espera hasta que se ingrese la tecla B o b.

            Console.WriteLine("¡Mario empieza a correr!");


        }
    }
}
