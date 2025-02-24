using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Mario necesita mover un bloque para alcanzar una moneda. 
// Crea un programa en C# que use operadores de desplazamiento (<< o >>) para simular el movimiento del bloque. Si el bloque se mueve correctamente, muestra ¡Moneda recolectada!, de lo contrario, muestra ¡Bloque atascado!.

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int bloque = 1; // La posición inicial del bloque
            Console.Write("Cantidad de desplazamiento: ");
            int movimiento = Convert.ToInt32(Console.ReadLine());

            bloque = bloque << movimiento; // Esto mueve el bloque a la izquierda
 
            if (bloque >= 5) // Si el bloque se movió correctamente
            {
                Console.WriteLine("¡Moneda recolectada!");
            }
            else
            {
                Console.WriteLine("¡Bloque atascado!");

            }
        }
    }
}
