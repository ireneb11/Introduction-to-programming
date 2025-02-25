using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioBucle5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int llaves = 0;
            bool nivelSecreto = false;

            while (!nivelSecreto)
            {
                llaves++;
                Console.WriteLine($"Mario ha recolectado {llaves} llaves.");

                if (llaves == 5)
                {
                    nivelSecreto = true;
                    Console.WriteLine("Mario puede entrar en el nivel secreto.");
                }
            }

        }
    }
}
