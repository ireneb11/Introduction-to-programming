using static System.Runtime.InteropServices.JavaScript.JSType;

namespace examen2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU PRINCIPAL:");
            Console.Write("Bandos disponibles:");
            List<string> bando = new List<string> { "La Resistencia", "El Imperio" };
            for (int i = 0; i < bando.Count; i++)
            {
                Console.Write(bando[i] + "(" + i + ") ");
            }

            int bandoElegido = SeleccionarBando();  


            Console.WriteLine("Quire pertenecer al bando " + bando[bandoElegido]);


            Console.WriteLine("\nPersonajes disponibles:");
            List<string> personajesResistencia = new List<string> { "Luke Skywalker", "Obi - Wan Kenobi", "Yoda", "Leia Organa", "Han Solo", "Chewbacca", "R2-D", "C3-PO", "Finn" };
            List<string> personajesImperio = new List<string> { "Darth Vader", "Darth Maul", " Kylo Ren", "Gran Moff Tarkin", "Conde Dooku", "Emperador Palpatine", "General Hux", "....", "...." };

            int personajeElegido;
            if (bandoElegido == 0)
            {
                //muestra lista de personajes en la resistencia
                for (int i = 0; i < personajesResistencia.Count; i++)
                {
                    Console.WriteLine (i + 1 + ". " + personajesResistencia[i]);
                }
                Console.Write("Elija el personaje con el que desea jugar:");
                personajeElegido = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Usted ha elegido jugar con el personaje " + personajesResistencia[personajeElegido - 1]);
                personajesResistencia.RemoveAt(personajeElegido-1);

                MostrarPuntosDeEspera();
                HistoriaResistencia();

            }
            else if (bandoElegido == 1)
            {
                //muestra lista de personajes en el imperio
                for (int i = 0; i < personajesImperio.Count; i++)
                {
                    Console.WriteLine(i + 1 + ". " + personajesImperio[i]);
                }
                Console.Write("Elija el personaje con el que desea jugar:");
                personajeElegido = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Usted ha elegido jugar con el personaje " + personajesImperio[personajeElegido - 1]);
                personajesImperio.RemoveAt(personajeElegido-1);

                MostrarPuntosDeEspera();
                HistoriaImperio();
            }


            EnterParaContinuar();



            // Lo primero es preparar a tu equipo
            Console.WriteLine("Lo primero de todo es elegir a tu tripulación, tenga encuenta que cada uno tendrá habilidades diferentes para combatir:");
            Random rnd = new Random();
            int[] vida = new int[9];
            int[] daño = new int[9];
            int[] velocidad = new int[9];

            // rellena el vector vida con valores aleatorios entre 20 y 100
            for (int i = 0; i < vida.Length; i++)
            {
                vida[i] = rnd.Next(20, 101);
            }
            // rellena el vector daño con valores aleatorios 
            for (int i = 0; i < daño.Length; i++)
            {
                daño[i] = rnd.Next(30, 101);
            }
            // rellena el vector velocidad con valores aleatorios 
            for (int i = 0; i < velocidad.Length; i++)
            {
                velocidad[i] = rnd.Next(1, 10);
            }


            // muestra los datos de los personajes
            if (bandoElegido == 0)
            {
                for (int i = 0; i < personajesResistencia.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {personajesResistencia[i]} - Vida: {vida[i]}, Daño: {daño[i]}, Velocidad: {velocidad[i]}");
                }

            }
            else if (bandoElegido == 1)
            {
                // muestra los datos de los personajes
                for (int i = 0; i < personajesImperio.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {personajesImperio[i]} - Vida: {vida[i]}, Daño: {daño[i]}, Velocidad: {velocidad[i]}");
                }
            }


            List<string> tripulación = new List<string>();
            // Selección de personajes            
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"\n Seleccione el miembro {i + 1}:");
                string? seleccion = Console.ReadLine();

                // Validar la selección
                if (!int.TryParse(seleccion, out int miembro))
                {
                    Console.WriteLine("Selección inválida. Intente de nuevo.");
                    i--;
                    continue;
                }
                else if (miembro < 1 || miembro > personajesResistencia.Count+1)
                {
                    Console.WriteLine("Selección fuera de rango. Intente de nuevo.");
                    i--;
                    continue;
                }
                else
                {
                    if (bandoElegido == 0)
                    {
                        tripulación.Add(personajesResistencia[miembro-1]);    // Agregar el personaje seleccionado a la lista
                        //personajesResistencia.RemoveAt(miembro-1);            // Eliminar el personaje seleccionado de la lista de personajes disponibles
                    }
                    else if (bandoElegido == 1)
                    {
                        tripulación.Add(personajesImperio[miembro-1]);
                        //personajesImperio.RemoveAt(miembro-1);
                    }
                }

            }

            // Mostrar los personajes seleccionados
            Console.Write("\nTu tripulación es:");
            Console.WriteLine(string.Join(", ", tripulación));

            EnterParaContinuar();



            // BATALLA

            // historia para dar comienzo a la batalla........
            Console.WriteLine("\n\n¡La batalla comienza!");

            MostrarPuntosDeEspera();


            // se genera un equipo aleatorio con personajes del bando no seleccionado
            List<string> enemigos = new List<string>();
            EquipoEnemigoAleatorio(enemigos, personajesImperio, tripulación, 4);


            Random rndm = new Random();
            int[] vidaEnemigos = new int[9];
            int[] dañoEnemigos = new int[9];
            int[] velocidadEnemigos = new int[9];

            // rellena el vector vida con valores aleatorios entre 20 y 100
            for (int i = 0; i < vidaEnemigos.Length; i++)
            {
                vidaEnemigos[i] = rnd.Next(20, 101);
            }
            // rellena el vector daño con valores aleatorios 
            for (int i = 0; i < dañoEnemigos.Length; i++)
            {
                dañoEnemigos[i] = rnd.Next(30, 101);
            }
            // rellena el vector velocidad con valores aleatorios 
            for (int i = 0; i < velocidadEnemigos.Length; i++)
            {
                velocidadEnemigos[i] = rnd.Next(1, 10);
            }


            // Mostrar los personajes enemigos
            Console.Write("\nLos enemigos a los que te vas a enfrentar junto con tu tripulación son:");
            Console.WriteLine(string.Join(", ", enemigos));
             
             

            int turno = 1;
            int j = 0;
            while (tripulación.Count > 0 && enemigos.Count > 0)
            {
                Console.WriteLine($"--- Turno {turno} ---");

                // Seleccionar primer enfrentamiento
                Console.WriteLine($"Seleccione el miembro de su tripulación para el primer enfrentamiento. ");
                for (int i = 0; i < tripulación.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tripulación[i]} - Vida: {vida[i]}, Daño: {daño[i]}, Velocidad: {velocidad[i]}");
                }
                

                bool Valida = false;
                int miembroSeleccionado;
                do
                {
                    // Solicitar al usuario que elija un miembro
                    Console.Write($"Miembro: ");
                    string? miembr = Console.ReadLine();

                    // Validar la entrada
                    if (!int.TryParse(miembr, out  miembroSeleccionado))
                    {
                        Console.WriteLine("Selección inválida. Intente de nuevo.");
                    }
                    else if (miembroSeleccionado < 1 || miembroSeleccionado > tripulación.Count+1)
                    {
                        Console.WriteLine("Selección fuera de rango. Intente de nuevo.");
                    }
                    else
                    {
                        Valida = true;  // Selección válida, salimos del bucle
                    }

                } while (!Valida);  // El bucle continuará hasta que la selección sea válida



                string miembroTripulacion = tripulación[miembroSeleccionado-1];
                string miembroEnemigo = enemigos[j]; ;




                // El más rápido ataca primero
                if (velocidad[j] >= velocidadEnemigos[j])
                {
                    Atacar(miembroTripulacion, miembroEnemigo, daño, vidaEnemigos, j);
                    if (EstaVivo(vidaEnemigos, j))
                    {
                        Atacar(miembroEnemigo, miembroTripulacion, dañoEnemigos, vida, j);
                    }
                }
                else
                {
                    // Un miembro del ejercito del imperio ataca a uno de la resistencia
                    Atacar(miembroEnemigo, miembroTripulacion, dañoEnemigos, vida, j);
                    Console.WriteLine(vida[j]);
                    if (EstaVivo(vida, j))
                    {
                        Atacar(miembroTripulacion, miembroEnemigo, daño, vidaEnemigos, j);
                    }
                }

                // Revisar si algún robot murió
                if (!EstaVivo(vida, j))
                {
                    Console.WriteLine($"{miembroTripulacion[j]} ha sido destruido!");
                    tripulación.RemoveAt(j);
                }
                if (!EstaVivo(vidaEnemigos, j))
                {
                    Console.WriteLine($"{miembroEnemigo[j]} ha sido destruido!");
                    enemigos.RemoveAt(j);
                }

                turno++;
                j++;
                Console.WriteLine();
            }

            // Declarar al ganador
            if (tripulación.Count > 0)
            {
                Console.WriteLine("¡La resistencia ha ganado la batalla!");
            }
            else if (enemigos.Count > 0)
            {
                Console.WriteLine("¡El Imperio ha ganado la batalla!");
            }
            else
            {
                Console.WriteLine("¡Es un empate!");
            }


            Console.WriteLine("Es el momento de ir a por los planos");
            // jcnhlsgcyisaygvygf
        }

        public static int Atacar(string miembro1, string miembro2, int[] daño, int[] vida, int i)
        {
            Console.WriteLine($"{miembro1} ataca a {miembro2} causando {daño[i]} de daño.");
            vida[i] -= daño[i];
            return vida[i];
        }

        public static bool EstaVivo(int[] vida, int i)
        {
            return vida[i] > 0;
        }

        public static List<string> EquipoEnemigoAleatorio(List<string> enemigos, List<string> listapersonajes, List<string> tripulacion, int cantidad)
        {
            Random random = new Random();
            

            for (int i = 0; i < cantidad; i++)
            {
                int enemigoAleatorio;
                do
                {
                    enemigoAleatorio = random.Next(0, listapersonajes.Count);
                }
                while (tripulacion.Contains(listapersonajes[enemigoAleatorio]));

                enemigos.Add(listapersonajes[enemigoAleatorio]);
                listapersonajes.RemoveAt(enemigoAleatorio);
            }

            return enemigos;
        }


        static void HistoriaResistencia()
        {
            // historia  de la resistencia

            // Aterrizaje en el planeta
            // tiempo de espera y puntos suspensivos
            // si es del bando bueno

            Console.WriteLine("\nAterrizando en el planeta Tatooine...");
            MostrarPuntosDeEspera();

            // presionar enter para ir avanzando la historia
            // historia:

            Console.WriteLine();
            Console.WriteLine("Kael Varn: Bienvenido joven padawan, me llamo Kael Varn. ");
            Console.WriteLine("Kael Varn: Espero sinceramente que tu travesía por los sistemas exteriores haya sido tranquila, aunque ya sabes que en estos tiempos pocas cosas lo son. Ya sabes cómo son esas viejas rutas comerciales: peligrosas, desiertas y llenas de sorpresas desagradables.    ");

            Console.WriteLine("Kael Varn: necesitamos tu ayuda urgentemente. La situación es grave. Hemos recibido informes de que el Imperio, bajo las órdenes del Gran Moff Tarkin, está buscando unos planos antiguos que podrían permitirles construir un superarma aún más devastadora que la Estrella de la Muerte. Se rumorea que estos planos están ocultos en algún lugar de Jakku, pero aún no sabemos su ubicación exacta.");
            Console.WriteLine("Kael Varn: El Gran Almirante Thrawn y sus tropas del Imperio están rastreando cada rincón del sistema, y si consiguen esos planos, toda la galaxia estará en peligro. La gente del planeta está desesperada, y si no conseguimos interceptar a los agentes imperiales antes de que lleguen, será demasiado tarde.");

            Console.WriteLine("Kael Varn: Espero que puedas reunir a tu tripulación y venir lo antes posible. El destino de la galaxia podría depender de nosotros.");
            Console.WriteLine("Kael Varn: Que la Fuerza te acompañe, y recuerda: esta misión es nuestra última esperanza");


        }

        static void HistoriaImperio()
        {
            // historia de los malos
            Console.WriteLine("\nAterrizando en ...");

            MostrarPuntosDeEspera();

            Console.WriteLine();
            Console.WriteLine("Llegas a tiempio ................ Soy el Capitán Merek Voss, comandante del Escuadrón Umber, 5º Flotilla Imperial.");
            Console.WriteLine("Los objetivos en Tatooine han sido claros desde el principio: obtener los planos de la superarma que El Gran Almirante Thrawn necesita para consolidar su dominio sobre los sistemas exteriores. La misión es crucial, y el tiempo corre en nuestra contra. ");
            Console.WriteLine("Los informes indican que los traidores en la Alianza Rebelde están haciendo todo lo posible para evitar que recupere los planos, pero los rumores sobre su paradero nos han dado una ventaja. ");
            Console.WriteLine("Ahora, las fuerzas rebeldes se mueven rápidamente para detenernos. Pero no hay esperanza para ellos. Tatooine es solo el comienzo. La rebelión será aplastada bajo el poder del Imperio, y los traidores que se atrevan a desafiar nuestra voluntad aprenderán lo que significa enfrentarse al poder del Emperador.");
            Console.WriteLine("Capitán Merek Voss: El plan sigue en marcha. Comiencen los preparativos para aplastar acualquiera que intente deteneros. Acabaremos con cualquier pizca de esperanza que les quede. El Imperio es inevitable.");

        }

        static void MostrarPuntosDeEspera()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000); // Espera 1 segundo
            }
        }
        public static void EnterParaContinuar()
        {
            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();  // Espera a que el usuario presione Enter
        }


        public static int SeleccionarBando()
        {
            bool seleccionValida = false;
            int bandoElegido;
            do
            {
                // Solicitar al usuario que elija un bando
                Console.Write("\nElija en qué bando desea jugar: ");
                string? band = Console.ReadLine();

                // Validar la entrada
                if (!int.TryParse(band, out bandoElegido))
                {
                    Console.WriteLine("Selección inválida. Intente de nuevo.");
                }
                else if (bandoElegido < 0 || bandoElegido > 1)
                {
                    Console.WriteLine("Selección fuera de rango. Intente de nuevo.");
                }
                else
                {
                    seleccionValida = true;  // Selección válida, salimos del bucle
                }

            } while (!seleccionValida);  // El bucle continuará hasta que la selección sea válida
            return bandoElegido;
        }
    }
}





/*



namespace examen2
{
    class Miembro
        
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public int Daño { get; set; }
        public int Velocidad { get; set; }

        public Miembro(string nombre, int vida, int daño, int velocidad)
        {
            Nombre = nombre;
            Vida = vida;
            Daño = daño;
            Velocidad = velocidad;
        }

        public void Atacar(Miembro enemigo)
        {
            Console.WriteLine($"{Nombre} ataca a {enemigo.Nombre} causando {Daño} de daño.");
            enemigo.Vida -= Daño;
        }

        public bool EstaVivo()
        {
            return Vida > 0;
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<Miembro> ejercitoResistencia = new List<Miembro>();
            List<Miembro> ejercitoImperio = new List<Miembro>();

            // Crear robots para cada ejército
            for (int i = 0; i < 3; i++)
            {
                ejercitoResistencia.Add(new Miembro($"RobotA{i + 1}", rnd.Next(50, 101), rnd.Next(5, 16), rnd.Next(1, 11)));
                ejercitoImperio.Add(new Miembro($"RobotB{i + 1}", rnd.Next(50, 101), rnd.Next(5, 16), rnd.Next(1, 11)));
            }

            Console.WriteLine("¡Comienza la batalla!");
            Console.WriteLine();

            int turno = 1;
            while (ejercitoResistencia.Count > 0 && ejercitoImperio.Count > 0)
            {
                Console.WriteLine($"--- Turno {turno} ---");

                // Seleccionar primer robot de cada ejército
                Miembro r1 = ejercitoResistencia[0];
                Miembro r2 = ejercitoImperio[0];

                // El más rápido ataca primero
                if (r1.Velocidad >= r2.Velocidad)
                {
                    r1.Atacar(r2);
                    if (r2.EstaVivo())
                    {
                        r2.Atacar(r1);
                    }
                }
                else
                {
                    r2.Atacar(r1);
                    if (r1.EstaVivo())
                    {
                        r1.Atacar(r2);
                    }
                }

                // Revisar si algún robot murió
                if (!r1.EstaVivo())
                {
                    Console.WriteLine($"{r1.Nombre} ha sido destruido!");
                    ejercitoResistencia.RemoveAt(0);
                }
                if (!r2.EstaVivo())
                {
                    Console.WriteLine($"{r2.Nombre} ha sido destruido!");
                    ejercitoImperio.RemoveAt(0);
                }

                turno++;
                Console.WriteLine();
            }

            // Declarar al ganador
            if (ejercitoResistencia.Count > 0)
            {
                Console.WriteLine("¡El ejército 1 gana la batalla!");
            }
            else if (ejercitoImperio.Count > 0)
            {
                Console.WriteLine("¡El ejército 2 gana la batalla!");
            }
            else
            {
                Console.WriteLine("¡Es un empate!");
            }
        }

    }
    
}








namespace DisparoNaves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filas = 5;
            int columnas = 10;
            char[,] espacio = new char[filas, columnas];

            // Inicializar la matriz vacía
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    espacio[i, j] = '.';
                }
            }

            // Posición inicial de la nave
            int filaNave = 2;
            int columnaNave = 0;

            while (true)
            {
                Console.Clear();

                // Colocar la nave en la matriz
                espacio[filaNave, columnaNave] = 'N';

                // Mostrar el espacio
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        Console.Write(espacio[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                // Quitar la nave para el siguiente movimiento
                espacio[filaNave, columnaNave] = '.';

                Console.WriteLine("\nPresiona 'd' para disparar o Enter para continuar...");
                string entrada = Console.ReadLine();

                if (entrada == "d")
                {
                    Console.Write("¿En qué columna quieres disparar (0-" + (columnas - 1) + ")? ");
                    int disparo = int.Parse(Console.ReadLine());

                    if (disparo == columnaNave)
                    {
                        Console.WriteLine("¡Le diste a la nave!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Fallaste...");
                    }
                }

                // Mover la nave hacia la derecha
                columnaNave++;

                if (columnaNave >= columnas)
                {
                    Console.WriteLine("¡La nave escapó!");
                    break;
                }

                System.Threading.Thread.Sleep(500); // Espera medio segundo antes de moverse
            }

            Console.WriteLine("\nJuego terminado.");
        }
    }
}




 namespace EscapeDelLaberinto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definimos el laberinto
            char[,] laberinto = {
                { '#', '#', '#', '#', '#', '#', '#', '#', '#' },
                { '#', 'P', ' ', ' ', '#', ' ', ' ', ' ', '#' },
                { '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#' },
                { '#', ' ', '#', ' ', ' ', ' ', '#', ' ', '#' },
                { '#', ' ', '#', '#', '#', ' ', '#', ' ', '#' },
                { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#' },
                { '#', '#', '#', ' ', '#', '#', '#', 'S', '#' },
                { '#', '#', '#', '#', '#', '#', '#', '#', '#' },
            };

            int jugadorFila = 1;
            int jugadorColumna = 1;
            bool jugando = true;

            while (jugando)
            {
                Console.Clear();
                MostrarLaberinto(laberinto);

                Console.WriteLine("\nMover (W/A/S/D): ");
                char movimiento = Console.ReadKey(true).KeyChar;
                movimiento = char.ToUpper(movimiento); // Acepta minúsculas y mayúsculas

                int nuevaFila = jugadorFila;
                int nuevaColumna = jugadorColumna;

                switch (movimiento)
                {
                    case 'W': nuevaFila--; break;
                    case 'S': nuevaFila++; break;
                    case 'A': nuevaColumna--; break;
                    case 'D': nuevaColumna++; break;
                    default:
                        Console.WriteLine("Movimiento inválido.");
                        System.Threading.Thread.Sleep(1000);
                        continue;
                }

                // Verificar si el movimiento es válido
                if (laberinto[nuevaFila, nuevaColumna] == '#')
                {
                    Console.WriteLine("¡Chocaste contra un muro!");
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    // Mover el jugador
                    laberinto[jugadorFila, jugadorColumna] = ' '; // Deja espacio vacío donde estaba
                    jugadorFila = nuevaFila;
                    jugadorColumna = nuevaColumna;
                    laberinto[jugadorFila, jugadorColumna] = 'P';

                    // ¿Llegaste a la salida?
                    if (laberinto[jugadorFila, jugadorColumna] == 'S')
                    {
                        jugando = false;
                    }
                }

                // Comprobamos si llegó a la salida
                if (jugadorFila == 6 && jugadorColumna == 7)
                {
                    Console.Clear();
                    MostrarLaberinto(laberinto);
                    Console.WriteLine("\n¡¡¡Felicidades!!! ¡Encontraste el tesoro escondido!");
                    break;
                }
            }

            Console.WriteLine("\nJuego terminado. ¡Gracias por jugar!");
        }

        static void MostrarLaberinto(char[,] laberinto)
        {
            for (int i = 0; i < laberinto.GetLength(0); i++)
            {
                for (int j = 0; j < laberinto.GetLength(1); j++)
                {
                    Console.Write(laberinto[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
*/
