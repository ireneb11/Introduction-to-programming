/*

// EJERCICIO 1
namespace p3_BorjaPorteroIrene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 3, 1, 3, 7, 3, 3, 4, 3 };

            Console.WriteLine("El arreglo es: ");
            Console.WriteLine("[" + string.Join(", ", arreglo) + "]");


            Console.Write("Ingrese el numero del que desea encontrar si se repite: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int contador = 0;

            for (int i = 0; i < arreglo.Length -1; i++)
            {
                if (numero == arreglo[i])
                {
                    contador++;
                }

            }
            

            if (contador == 0)
            {
                Console.WriteLine($"El numero {numero} no se repite.");
            }
            else
            {
                Console.WriteLine($"El numero {numero} se repite {contador} veces.");
            }
            
        }
    }
}



// EJERCICIO 2
namespace p3_BorjaPorteroIrene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A continuación crea un vector. ");
            int[] vector = new int[5];
            
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("Ingrese un numero: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                vector[i] = numero;
            }

            Console.WriteLine("\nEl vector es: ");
            Console.WriteLine("{" + string.Join(", ", vector) + "}");

            int[] vectorInvertido = new int[vector.Length];

            for (int k = 0; k < vectorInvertido.Length; k++)
            {
                vectorInvertido[k] = vector[vector.Length - 1 -k];
            }
            Console.WriteLine("\nEl vector invertido es: ");
            Console.WriteLine("{" + string.Join(", ", vectorInvertido) + "}");
        }
    }
}


// EJERCICIO 3
using System.ComponentModel.DataAnnotations;

namespace p3_BorjaPorteroIrene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector = { 6, 8, 2, 1, 5 };

            Console.WriteLine("El vector dado es: ");
            Console.WriteLine("{" + string.Join(", ", vector) + "}");

            Console.WriteLine("\nLas operaciones que se pueden realizar son: ");
            string[] operaciones = { "Sumar", "Promedio", "Valor máximo", "Valor mínimo" };
            for (int i = 0; i < operaciones.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {operaciones[i]}");
            }
            Console.Write("\nIngrese el número de la operación que desea realizar: ");
            int operacion = Convert.ToInt32(Console.ReadLine());

            switch (operacion)
            {
                case 1:
                    Console.WriteLine("Ha seleccionado sumar los elementos del vector.");
                    int suma = 0;
                    for (int i = 0; i < vector.Length; i++)
                    {
                        suma += vector[i];
                    }
                    Console.WriteLine($"La suma de los elementos del vector es: {suma}");
                    break;
                case 2:
                    Console.WriteLine("Ha seleccionado el promedio de los elementos del vector.");
                    int suma2 = 0;
                    for (int i = 0; i < vector.Length; i++)
                    {
                        suma2 += vector[i];
                    }
                    double promedio = suma2 / vector.Length;
                    Console.WriteLine($"El promedio de los elementos del vector es: {promedio}");
                    break;
                case 3:
                    Console.WriteLine("Ha seleccionado el valor máximo del vector.");
                    int max = vector[0];
                    for (int i = 1; i < vector.Length; i++)
                    {
                        if (vector[i] > max)
                        {
                            max = vector[i];
                        }

                    }
                    Console.WriteLine($"El valor máximo del vector es: {max}");
                    break;
                case 4:
                    Console.WriteLine("Ha seleccionado el valor mínimo del vector.");
                    int minimo = vector[0];
                    for (int i = 1; i < vector.Length; i++)
                    {
                        if (vector[i] < minimo)
                        {
                            minimo = vector[i];
                        }

                    }
                    Console.WriteLine($"El valor minimo del vector es: {minimo}");
                    break;
                default:
                    Console.WriteLine("La opción ingresada no es válida.");
                    break;

            }
        }
    }
}




// EJERCICIO 4
using System.Globalization;

namespace p3_BorjaPorteroIrene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dada esta matriz de tamaño 3x4: ");

            int[,] matriz =
            {
                { 1, 3, 5, 7 },
                { 2, 4, 6, 8 },
                { 0, 9, 10, 2 }
            };

            // Mostrar la matriz
            for (int i = 0; i < matriz.GetLength(0); i++) // Recorre las filas
            {
                for (int j =0; j < matriz.GetLength(1); j++) // Recorre las columnas
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nLa matriz transpuesta de tamaño 4x3 es: ");
            for (int i = 0; i < matriz.GetLength(1); i++) // Recorre las filas
            {
                for (int j = 0; j < matriz.GetLength(0); j++) // Recorre las columnas
                {
                    Console.Write(matriz[j, i] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}


// EJERCICIO 5
using System.Globalization;

namespace p3_BorjaPorteroIrene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvienido a la agencia de viajes NuncaJamAir ");
            Console.WriteLine("A continuación, se le mostrarán los destinos disponibles: ");
            string[] destinos = { "Praga", "París", "Brujas", "Marsella" };
            for (int i = 0; i < destinos.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {destinos[i]}");
            }

            Console.Write("\nIngrese el número del destino al que desea viajar: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Destino seleccionado: " + destinos[numero - 1]);

            Console.Write("\nIngrese el número de plazas que desea reservar: ");
            int plazas = Convert.ToInt32(Console.ReadLine());

            string[] diaSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            for (int j = 0; j < diaSemana.Length; j++)
            {
                Console.WriteLine($"{j + 1}. {diaSemana[j]}");
            }
            Console.Write("\nIngrese el día de la semana en el que desea viajar: ");
            int dia = Convert.ToInt32(Console.ReadLine());

            // Matriz de disponibilidad: hay disponibles 5 plazas para cada vuelo de cada destino los 7 dias de la semana
            int[,] disponibilidad =
            {
                { 5, 5, 5, 5, 5, 5, 5 },
                { 5, 5, 5, 5, 5, 5, 5 },
                { 5, 5, 5, 5, 5, 5, 5 },
                { 5, 5, 5, 5, 5, 5, 5 }

            };

            if (disponibilidad[numero - 1, dia -1] >= plazas)
            {
                Console.WriteLine("\nReserva realizada con éxito.");
                disponibilidad[numero - 1, dia - 1] -= plazas - 1;
                Console.WriteLine($"{plazas} pasajeros para viajar a {destinos[numero - 1]}, el {diaSemana[dia -1]}");
            }
            else
            {
                Console.WriteLine("\nNo hay plazas suficientes para realizar la reserva.");
            }


        }
    }
}




// EJERCICIO 6
using System.Globalization;

namespace p3_BorjaPorteroIrene
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvienido a la agencia de viajes NuncaJamAir ");
            bool agencia = true;
            // Matriz de disponibilidad: hay disponibles 5 plazas para cada vuelo de cada destino los 7 dias de la semana
            int[,] disponibilidad =
            {
                { 5, 5, 5, 5, 5, 5, 5 },
                { 5, 5, 5, 5, 5, 5, 5 },
                { 5, 5, 5, 5, 5, 5, 5 },
                { 5, 5, 5, 5, 5, 5, 5 }

            };
            do
            {
                // Selecciona el destino
                Console.WriteLine("\nA continuación, se le mostrarán los destinos disponibles: ");
                string[] destinos = { "Praga", "París", "Brujas", "Marsella" };
                for (int i = 0; i < destinos.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {destinos[i]}");
                }

                Console.Write("\nIngrese el número del destino al que desea viajar: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Destino seleccionado: " + destinos[numero - 1]);

                // Selecciona el día de la semana
                string[] diaSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
                for (int j = 0; j < diaSemana.Length; j++)
                {
                    Console.WriteLine($"{j + 1}. {diaSemana[j]}");
                }
                Console.Write("\nIngrese el día de la semana en el que desea viajar: ");
                int dia = Convert.ToInt32(Console.ReadLine());


                // Indica las plazas disponibles
                Console.WriteLine($"\nLa disponibilidad de plazas para {destinos[numero - 1]} el {diaSemana[dia - 1]} es de {disponibilidad[numero - 1, dia - 1]} plazas. ");
                
                // Realiza la reserva en funcion de las plazas que quieras reservar
                Console.Write("\nIngrese el número de plazas que desea reservar: ");
                int plazas = Convert.ToInt32(Console.ReadLine());

                if (disponibilidad[numero - 1, dia - 1] >= plazas)
                {
                    Console.WriteLine("\nReserva realizada con éxito.");
                    disponibilidad[numero - 1, dia - 1] -= plazas;
                    
                    Console.WriteLine($"Ahora quedan {disponibilidad[numero - 1, dia - 1]} plazas para viajar a {destinos[numero - 1]}, el {diaSemana[dia - 1]}");
                }
                else
                {
                    Console.WriteLine("\nNo hay plazas suficientes para realizar la reserva.");
                }

               // Comprueba si hay un dia en el que ya no hay plazas disponibles, así se cerrará la agencia.
                for (int i = 0; i < disponibilidad.GetLength(0); i++)
                {
                    for (int j = 0; j < disponibilidad.GetLength(1); j++)
                    {
                        if (disponibilidad[i, j] == 0)
                        {
                            Console.WriteLine($"Ya no quedan plazas disponibles para viajar a {destinos[i]} el {diaSemana[j]}");
                            agencia = false;
                        }
                    }
                    Console.WriteLine();
                }
            } while (agencia);




        }
    }
}
*/

// EJERCICIO 7
using System.ComponentModel.Design;

namespace juegoclase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Bienvienido a al restaurante The Black Pearl...");
            int estrellas = 0;


            // Selecciona el personaje
            Console.WriteLine("Estos son los personajes disponibles: ");
            string[] personajes = { "Jack Sparrow", "Elizabeth Swann", "Barbanegra", "Hector Barbossa", "Davy Jones" };
            for (int i = 0; i < personajes.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {personajes[i]}");
            }
            Console.Write("Seleccione a un personaje (ingrese el numero asociado): ");
            int personaje = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Confío en tí {personajes[personaje - 1]}, si estas aquí significa que te lo mereces...Ahora solo tienes que demostrarlo.");



            // Muestra las comandas del día
            List<string> comandas = new List<string> { "Sopa de Sirena", "Estofado de Cocodrilo", "Pasta de Hadas" };
            Console.WriteLine("\nLas comandas del día de hoy son: " + string.Join(", ", comandas) + ".");
            Console.WriteLine("¡Buena suerte navegante!, y recuerda tu objetivo final....");

            Console.WriteLine("\nPresiona ENTER para abrir el restaurante...");
            Console.ReadLine();

            Console.WriteLine("Restaurante: OPEN");
            bool restaurante = true;








            // Esta matriz tiene el orden de los ingredientes de cada plato. Cada fila corresponde con un plato
            int[,] matrizPlatos =
            {
                { 3, 6, 9 },  //Sopa de Sirena
                { 10, 2, 4 },  //Estofado de Cocodrilo
                { 1, 5, 7 }   //Pasta de Hadas
            };

            bool sonIguales = true;

            List<string> despensa = new List<string> { "Polvo de hadas", "Salsa de luna llena", "Agua de laguna encantada", "Pimienta de mar", "Bayas de ensueño", "Perlas de coral", "Néctar de Flor Nocturna", "Sal de los Siete Mares", "Alga dorada", "Raíces de la Selva Perdida", "Lágrimas de sirena", "Hierba Susurrante" };  // Lista de despensa
            List<int> seleccion = new List<int>(); // Lista para almacenar los números de los ingredientes a elegir

            do
            {
                // genera un numero aleatorio entre 1 y 4 (el 5 no se incluye)
                Random rand = new Random();
                int numeroAleatorio = rand.Next(1, 5);

                switch (numeroAleatorio)
                {
                    case 1:
                        Console.WriteLine("\nEl cliente ha pedido una Sopa de Sirena");

                        Console.WriteLine("Los ingredientes que necesita para cocinar este plato son: ");
                        string[] ingredientes = { "Agua de laguna encantada", "Perlas de coral", "alga dorada" };
                        foreach (string ingrediente in ingredientes)
                        {
                            Console.WriteLine($"- {ingrediente}");
                        }

                        // Hay que ir a la despensa para coger los ingredientes
                        Console.WriteLine("\nPresiona ENTER para ir a la despensa a por ingredientes...");
                        Console.ReadLine();


                        // Muestra todos los ingredientes disponibles en la despensa
                        Console.WriteLine("\nDESPENSA: ");

                        for (int i = 0; i < despensa.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {despensa[i]}");
                        }


                        //Elige de la lista los ingredientes correspondientes para el plato y crea una lista 
                        Console.WriteLine("\nSelecciona los ingredientes que desea coger en el orden correspondiente (numeros asignados)");

                        int numero;
                        Console.WriteLine(" INgrese el 0 cuando quiera abandonar la despensa");
                        do
                        {
                            seleccion.Clear();
                            Console.Write("Número: ");
                            numero = Convert.ToInt32(Console.ReadLine());

                            if (numero != 0) // No agregar el 0 a la lista
                            {
                                seleccion.Add(numero); // Agregar número a la lista
                            }

                        } while (numero != 0);


                        // Compara con la fila de la matriz asignada al plato si los elementos coinciden para ver si el plato se ha realizado correctamente
                        for (int j = 0; j < seleccion.Count; j++)
                        {
                            if (matrizPlatos[0, j] != seleccion[j])
                            {
                                sonIguales = false;
                                break; // Si un elemento es diferente, salimos del bucle
                            }
                        }

                        if (sonIguales) // Si son iguales gana una estrella de recompensa.
                        {
                            Console.WriteLine("¡Bien hecho!, has ganado una estrella");
                            estrellas += 1;
                        }
                        else
                        {
                            Console.WriteLine("Una pregunta,¿sabes cocinar?...");
                        }

                        break;
                    case 2:

                        Console.WriteLine("\nEl cliente ha pedido una Estofado de Cocodrilo");

                        Console.WriteLine("Los ingredientes que necesita para cocinar este plato son: ");
                        string[] ingredientes2 = { "Raíces de la Selva Perdida", "Salsa de luna llena", "Pimienta de mar" };
                        foreach (string ingrediente in ingredientes2)
                        {
                            Console.WriteLine($"- {ingrediente}");
                        }

                        // Hay que ir a la despensa para coger los ingredientes
                        Console.WriteLine("\nPresiona ENTER para ir a la despensa a por ingredientes...");
                        Console.ReadLine();


                        // Muestra todos los ingredientes disponibles en la despensa
                        Console.WriteLine("\nDESPENSA: ");

                        for (int i = 0; i < despensa.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {despensa[i]}");
                        }


                        //Elige de la lista los ingredientes correspondientes para el plato y crea una lista 
                        Console.WriteLine("\nSelecciona los ingredientes que desea coger de la despensa en el orden correspondiente (numeros asignados)");


                        Console.WriteLine(" INgrese el 0 cuando quiera abandonar la despensa");
                        do
                        {
                            seleccion.Clear();
                            Console.Write("Número: ");
                            numero = Convert.ToInt32(Console.ReadLine());

                            if (numero != 0) // No agregar el 0 a la lista
                            {
                                seleccion.Add(numero); // Agregar número a la lista
                            }

                        } while (numero != 0);


                        // Compara con la fila de la matriz asignada al plato si los elementos coinciden para ver si el plato se ha realizado correctamente
                        sonIguales = true;
                        for (int j = 0; j < seleccion.Count; j++)
                        {
                            if (matrizPlatos[1, j] != seleccion[j])
                            {
                                sonIguales = false;
                                break; // Si un elemento es diferente, salimos del bucle
                            }
                        }

                        if (sonIguales) // Si son iguales gana una estrella de recompensa.
                        {
                            Console.WriteLine("¡Bien hecho!, has ganado una estrella");
                            estrellas += 1;
                        }
                        else
                        {
                            Console.WriteLine("Una pregunta,¿sabes cocinar?...");
                        }

                        break;
                    case 3:

                        Console.WriteLine("\nEl cliente ha pedido una Pasta de Hadas");

                        Console.WriteLine("Los ingredientes que necesita para cocinar este plato son: ");
                        string[] ingredientes3 = { "Polvo de hadas", "Bayas de ensueño", "Nectar de flor nocturna" };
                        foreach (string ingrediente in ingredientes3)
                        {
                            Console.WriteLine($"- {ingrediente}");
                        }

                        // Hay que ir a la despensa para coger los ingredientes
                        Console.WriteLine("\nPresiona ENTER para ir a la despensa a por ingredientes...");
                        Console.ReadLine();


                        // Muestra todos los ingredientes disponibles en la despensa
                        Console.WriteLine("\nDESPENSA: ");

                        for (int i = 0; i < despensa.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {despensa[i]}");
                        }


                        //Elige de la lista los ingredientes correspondientes para el plato y crea una lista 
                        Console.WriteLine("\nSelecciona los ingredientes que desea coger de la despensa en el orden correspondiente (numeros asignados)");


                        Console.WriteLine(" INgrese el 0 cuando quiera abandonar la despensa");
                        do
                        {
                            seleccion.Clear();
                            Console.Write("Número: ");
                            numero = Convert.ToInt32(Console.ReadLine());

                            if (numero != 0) // No agregar el 0 a la lista
                            {
                                seleccion.Add(numero); // Agregar número a la lista
                            }

                        } while (numero != 0);



                        // Compara con la fila de la matriz asignada al plato si los elementos coinciden para ver si el plato se ha realizado correctamente
                        sonIguales = true;
                        for (int j = 0; j < seleccion.Count; j++)
                        {
                            if (matrizPlatos[2, j] != seleccion[j])
                            {
                                sonIguales = false;
                                break; // Si un elemento es diferente, salimos del bucle
                            }
                        }

                        if (sonIguales) // Si son iguales gana una estrella de recompensa.
                        {
                            Console.WriteLine("¡Bien hecho!, has ganado una estrella");
                            estrellas += 1;
                        }
                        else
                        {
                            Console.WriteLine("Una pregunta,¿sabes cocinar?...");
                        }

                        break;
                }

                Console.WriteLine("¿Desea realizar otra comanda?");
                restaurante = Convert.ToBoolean(Console.ReadLine());
            } while (restaurante);

            if (estrellas >= 3)
            {
                Console.WriteLine("Felicidades The Black Pearl es un exito");
                Console.WriteLine("Desafío final para comprobar tu valía. Navegante, ¡buena suerte!");

                // DESAFIO FINAL . Encuentra la rata en la cocina  
                char[,] tablero = new char[5, 5]; // Matriz 5x5
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        tablero[i, j] = 'x'; // Todo oculto
                    }
                }


                bool encontrado = false;
                int contador = 0;
                int fila;
                int columna;
                int tesoroFila = 2;
                int tesoroColumna = 0;

                while (!encontrado)
                {
                    // escribe el tablero
                    Console.Clear();
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.Write($"|{tablero[i, j]}");
                        }
                        Console.WriteLine("|");
                    }
                    // Pide al usuario que introduzca la posición que quiere descrifrar.
                    Console.WriteLine("Encuentra la rata que se ha colado en la cocina. ");
                    Console.Write("Ingresa fila (0-4): ");
                    fila = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingresa columna (0-4): ");
                    columna = Convert.ToInt32(Console.ReadLine());
                    
                    // si escriben una fila o columna que no existe, se les vuelve a pedir
                    while (fila < 0 || fila >= 5)
                    {
                        Console.WriteLine("Fila inválida. Intenta de nuevo (0-4): ");
                        fila = Convert.ToInt32(Console.ReadLine());
                    }
                    while (columna < 0 || columna >= 5)
                    {
                        Console.WriteLine("Columna inválida. Intenta de nuevo (0-4): ");
                    }

                    if (fila == tesoroFila && columna == tesoroColumna)
                    {
                        tablero[fila, columna] = 'R';
                        encontrado = true;
                    }
                    else
                    {
                        Console.WriteLine("Ahí no está la rata . ¡Sigue buscando!");
                        tablero[fila, columna] = 'O'; // Marca intento fallido
                    }
                    contador += 1;
                }

                Console.Clear();
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write($"|{tablero[i, j]}");
                    }
                    Console.WriteLine("|");
                }
                Console.WriteLine("¡Felicidades! ¡Has encontrado la rata!");
                Console.WriteLine($"Número de intentos: {contador}");
                if (contador < 7)
                {
                    Console.WriteLine("¡Eres un verdadero pirata!");
                }
                else if (contador == 7)
                {
                    Console.WriteLine("Eres un pirata de agua dulce, te lo perdonaré por esta vez.");
                }
                else
                {
                    Console.WriteLine("Ya me había ilusionado contigo, desgraciadamente has decepcionado al capitán.");
                }

            }
            if (estrellas < 3)
            {
                Console.WriteLine("Tu trabajo es mejorable.");
            }
            else
            {
                Console.WriteLine("¡Maldición!, sabía que no debía fiarme de las opiniones de la gente, no quiero volver a verte por estos mares. DESPEDIDO");

            }
        }
    }
}


