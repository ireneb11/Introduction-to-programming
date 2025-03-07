namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
            string? nombre = Console.ReadLine();
            Console.Write("Ingrese la cantidad de horas trabajadas semanalmente: ");
            int horasTrabajadas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el sueldo por hora trabajada: ");
            double sueldoPorHora = Convert.ToDouble(Console.ReadLine());

            double sueldoSemanal = horasTrabajadas * sueldoPorHora;

            if (sueldoSemanal > 0 && sueldoSemanal < 150)
            {
                Console.WriteLine($"Trabajador {nombre}, se le descontara un 5% de su sueldo debido a los impuestos.");
                Console.WriteLine($"Su sueldo semanal es de: {sueldoSemanal - (sueldoSemanal * 0.05)}");
            }
            else if (sueldoSemanal > 150 && sueldoSemanal < 300)
            {
                Console.WriteLine($"Trabajador {nombre}, se le descontara un 7% de su sueldo debido a los impuestos.");
                Console.WriteLine($"Su sueldo semanal es de: {sueldoSemanal - (sueldoSemanal * 0.07)}");
            }
            else if (sueldoSemanal > 300 && sueldoSemanal < 450)
            {
                Console.WriteLine($"Trabajador {nombre}, se le descontara un 9% de su sueldo debido a los impuestos.");
                Console.WriteLine($"Su sueldo semanal es de: {sueldoSemanal - (sueldoSemanal * 0.09)}");
            }
            else 
            {
                Console.WriteLine($"Introduzca bien los valores.");
            }

        }
    }
}
