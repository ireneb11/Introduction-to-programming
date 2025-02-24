using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
  
namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántos minutos tarda Luigi en terminar la carrera? ");
            double tiempoLuigi = Convert.ToDouble(Console.ReadLine());
            Console.Write("¿Cuántos minutos tarda Mario en terminar la carrera? ");
            double tiempoMario = Convert.ToDouble(Console.ReadLine());

            if (tiempoMario < tiempoLuigi)
            {
                Console.WriteLine("¡Mario gana!");
            }
            else
            {
                Console.WriteLine("¡Luigi gana!");
            }

        }
    }
}
