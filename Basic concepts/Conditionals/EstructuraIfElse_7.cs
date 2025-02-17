using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstructuraIf
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int durabilidadArma = 50;
            bool armaRota = false;

            if (!armaRota && durabilidadArma > 0)
            {
                durabilidadArma--; // Decrementa la durabilidad del arma
                Console.WriteLine("Arma usada. Durabilidad restante: {0}", durabilidadArma);
            }
            else
            {
                Console.WriteLine($"El arma está rota o no tiene durabilidad.");
            }
        }
    }
}
