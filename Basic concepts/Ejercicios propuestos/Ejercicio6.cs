using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vidaInicialMario = 100;
            int dañobrowser = 20;
            Console.Write("Ingrese la cantidad de ataques de browser recibidos: ");
            int ataquesRecibidos =  Convert.ToInt32(Console.ReadLine());

            int vidaRestante = vidaInicialMario - (ataquesRecibidos*dañobrowser);
            if (vidaRestante <= 0)
            {
                Console.WriteLine("¡Mario ha perdido!");
            }
            else
            {
                Console.WriteLine("¡Mario sigue en pie!");
            }
        }
    }
}
