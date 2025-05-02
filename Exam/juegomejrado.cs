using System;

namespace EjercicioBucleFor6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("Bandos disponibles: ");
            List<string> bandos = new List<string> { "La Resistencia", "El Imperio" };
            for (int i = 0; i < bandos.Count; i++)
            {
                Console.WriteLine(bandos[i] + " (" + i + ")");
            }
            int bandoElegido = SeleccionarBando();


            Console.WriteLine("Quiere pertenecer al bando: " + bandos[bandoElegido]);

            List<string> personajesResistencia = new List<string> { "Luke Skywalker", "Leia Organa", "Han Solo", "Chewbacca", "Obi Wan Kenoby", "Yoda", "R2-D", "C3-PO", "Finn" };
            List<string> personajesImperio = new List<string> { "Darth Vader", "Emperador Palpatine", "Kylo Ren", "Darth Maul", "GEneral Hux", "Gran Moff Tarking", "Conde Dooku", "Grievous" };

            if (bandoElegido == 0)

                SeleccionarPersonaje(personajesResistencia);
            else
                SeleccionarPersonaje(personajesImperio);

            MostrarPuntosDeEspera();

            Console.WriteLine("Bienvenido a la guerra de las galaxias");
            Historia(bandoElegido);

            EnterParaContinuar();

            Console.WriteLine("Lo primero es elegir a tu tripulacion, tenga en cuenta que cada uno tendra una habilidad diferente");

            Random rnd = new Random();
            int[] daño = new int[8];
            GenerarHabilidad(daño, 20, 101); // rellena el vector daño
            int[] vida = new int[8];
            GenerarHabilidad(vida, 30, 101);
            int[] velocidad = new int[8];
            GenerarHabilidad(velocidad, 1, 10);

            if (bandoElegido == 0)
            {
                MostrarBando(personajesResistencia, vida, daño, velocidad);
            }
            else
            {
                MostrarBando(personajesImperio, vida, daño, velocidad);
            }

            List<string> tripulacion = new List<string>();

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Seleccione un personaje para tu tripulacion: ");
                string? seleccion = Console.ReadLine();
                if (!int.TryParse(seleccion, out int seleccionPersonaje))
                {
                    Console.WriteLine("Seleccion invalida. Intentelo de nuevo");
                    i--;
                    continue;
                }
                else if (seleccionPersonaje < 0 || seleccionPersonaje > 8)
                {
                    Console.WriteLine("Seleccion fuera de rango");
                    i--;
                    continue;
                }
                else
                {
                    if (bandoElegido == 0)
                    {
                        tripulacion.Add(personajesResistencia[seleccionPersonaje - 1]);
                    }
                    else if (bandoElegido == 1)
                    {
                        tripulacion.Add(personajesImperio[seleccionPersonaje - 1]);
                    }
                }
            }
            Console.WriteLine("Tu tripulacion es: ");
            Console.WriteLine(string.Join(", ", tripulacion));

            EnterParaContinuar();

            //BAtalla

            Console.WriteLine("La batalla ha comenzado...");
            Console.WriteLine("El enemigo se acerca, preparate para el combate");
            MostrarPuntosDeEspera();

            List<string> enemigos = new List<string>();
            if (bandoElegido == 0)
                EquipoEnemigoAleatorio(enemigos, personajesImperio);
            else
                EquipoEnemigoAleatorio(enemigos, personajesResistencia);

            int[] vidaEnemigos = new int[8];
            GenerarHabilidad(vidaEnemigos, 20, 101); // rellena el vector vida
            int[] dañoEnemigos = new int[8];
            GenerarHabilidad(dañoEnemigos, 20, 101); // rellena el vector daño
            int[] velocidadEnemigos = new int[8];
            GenerarHabilidad(vidaEnemigos, 1, 10);

            Console.WriteLine("Los enemigos a los que te vas a enfrentar son: ");
            Console.WriteLine(string.Join(", ", enemigos));

            int turno = 1;
            int j = 0; // contador de enemigos
            int miembroElegido;
            while (tripulacion.Count > 0 && enemigos.Count > 0)
            {
                Console.WriteLine($"Turno {turno}");

                Console.WriteLine("Elija un personaje para el enfrentamiento");
                for (int i = 0; i < tripulacion.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tripulacion[i]}");
                }

                bool SeleccionValida = false;

                do
                {
                    Console.WriteLine("Miembro: ");
                    string? miembro = Console.ReadLine();
                    if (!int.TryParse(miembro, out miembroElegido))
                    {
                        Console.WriteLine("Seleccion invalida. Intentelo de nuevo");
                    }
                    else if (miembroElegido < 0 || miembroElegido > tripulacion.Count)
                    {
                        Console.WriteLine("Seleccion fuera de rango");
                    }
                    else
                    {
                        SeleccionValida = true;
                    }

                } while (!SeleccionValida);

                string personajeElegido = tripulacion[miembroElegido - 1];
                string enemigoElegido = enemigos[j];

                //el mas rapido ataca primero
                if (velocidad[miembroElegido - 1] >= velocidadEnemigos[j])
                {
                    Atacar(personajeElegido, enemigoElegido, daño, vidaEnemigos, miembroElegido - 1, j);
                    if (EstarVivo(vidaEnemigos, j))
                    {
                        Atacar(enemigoElegido, personajeElegido, dañoEnemigos, vida, j, miembroElegido - 1);
                    }
                }
                else
                {
                    Atacar(enemigoElegido, personajeElegido, dañoEnemigos, vida, j, miembroElegido - 1);
                    if (EstarVivo(vida, j))
                    {
                        Atacar(personajeElegido, enemigoElegido, daño, vidaEnemigos, miembroElegido - 1, j);
                    }

                }
                // Comprobar si el enemigo ha muerto
                if (!EstarVivo(vidaEnemigos, j))
                {
                    Console.WriteLine($"{enemigoElegido} ha sido derrotado.");
                    enemigos.RemoveAt(j);
                    vidaEnemigos[j] = 0;
                }
                // Comprobar si el personaje ha muerto
                if (!EstarVivo(vida, miembroElegido - 1))
                {
                    Console.WriteLine($"{personajeElegido} ha sido derrotado.");
                    tripulacion.RemoveAt(miembroElegido - 1);
                    vida[miembroElegido - 1] = 0;
                }
                turno++;
                j++;
                Console.WriteLine();

            }

            //detectar ganador
            if (tripulacion.Count > 0)
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
        }

        static int SeleccionarBando()
        {
            bool selecionValida = false;
            int bandoElegido;
            do
            {
                // SOlicite al usuario que elija un bando
                Console.WriteLine("Elige un bando: ");
                string? bando = Console.ReadLine();

                if (!int.TryParse(bando, out bandoElegido))
                {
                    Console.WriteLine("Seleccion invalida. Intentelo de nuevo");
                }
                else if (bandoElegido < 0 || bandoElegido > 1)
                {
                    Console.WriteLine("Seleccion fuera de rango");
                }
                else
                {
                    selecionValida = true;
                }
            } while (!selecionValida);

            return bandoElegido;

        }

        public static int SeleccionarPersonaje(List<string> personajes)
        {
            bool SeleccionValida = false;
            int personajeElegido;


            Console.WriteLine("personajes disponibles: ");
            for (int i = 0; i < personajes.Count; i++)
            {
                Console.WriteLine(i + ". " + personajes[i]);
            }
            do
            {
                Console.WriteLine("Elige un personaje: ");
                string? personaje = Console.ReadLine();

                if (!int.TryParse(personaje, out personajeElegido))
                {
                    Console.WriteLine("Seleccion invalida. Intentelo de nuevo");
                }
                else if (personajeElegido < 0 || personajeElegido > personajes.Count)
                {
                    Console.WriteLine("Seleccion fuera de rango");
                }
                else
                {
                    SeleccionValida = true;

                }

            } while (!SeleccionValida);
            Console.WriteLine("Has elegido a: " + personajes[personajeElegido]);
            personajes.RemoveAt(personajeElegido - 1);
            return personajeElegido;
        }

        static int Atacar(string miembro1, string miembro2, int[] daño, int[] vida, int i, int j)
        {
            Console.WriteLine($"{miembro1} ataca a {miembro2} causando {daño[i]} de daño.");
            vida[j] -= daño[i];
            return vida[j];
        }
        static bool EstarVivo(int[] vida, int i)
        { 
            return vida[i] > 0;

        }
        public static void MostrarPuntosDeEspera()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(". ");
                System.Threading.Thread.Sleep(1000); // Espera 1 seg 
            }

        }
        public static void Historia(int bando)
        {
            Console.WriteLine("Aterrizando en el planeta Tatooine...");
            MostrarPuntosDeEspera();
            Console.WriteLine("Aterrizaje completado.");
            if (bando == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Kael Varn: Bienvenido joven padawan, me llamo Kael Varn. ");
                Console.WriteLine("Kael Varn: Espero sinceramente que tu travesía por los sistemas exteriores haya sido tranquila, aunque ya sabes que en estos tiempos pocas cosas lo son. Ya sabes cómo son esas viejas rutas comerciales: peligrosas, desiertas y llenas de sorpresas desagradables.    ");

                Console.WriteLine("Kael Varn: necesitamos tu ayuda urgentemente. La situación es grave. Hemos recibido informes de que el Imperio, bajo las órdenes del Gran Moff Tarkin, está buscando unos planos antiguos que podrían permitirles construir un superarma aún más devastadora que la Estrella de la Muerte. Se rumorea que estos planos están ocultos en algún lugar de Jakku, pero aún no sabemos su ubicación exacta.");
                Console.WriteLine("Kael Varn: El Gran Almirante Thrawn y sus tropas del Imperio están rastreando cada rincón del sistema, y si consiguen esos planos, toda la galaxia estará en peligro. La gente del planeta está desesperada, y si no conseguimos interceptar a los agentes imperiales antes de que lleguen, será demasiado tarde.");

                Console.WriteLine("Kael Varn: Espero que puedas reunir a tu tripulación y venir lo antes posible. El destino de la galaxia podría depender de nosotros.");
                Console.WriteLine("Kael Varn: Que la Fuerza te acompañe, y recuerda: esta misión es nuestra última esperanza");

            }
            else
            {
                Console.WriteLine("Llegas a tiempio ................ Soy el Capitán Merek Voss, comandante del Escuadrón Umber, 5º Flotilla Imperial.");
                Console.WriteLine("Los objetivos en Tatooine han sido claros desde el principio: obtener los planos de la superarma que El Gran Almirante Thrawn necesita para consolidar su dominio sobre los sistemas exteriores. La misión es crucial, y el tiempo corre en nuestra contra. ");
                Console.WriteLine("Los informes indican que los traidores en la Alianza Rebelde están haciendo todo lo posible para evitar que recupere los planos, pero los rumores sobre su paradero nos han dado una ventaja. ");
                Console.WriteLine("Ahora, las fuerzas rebeldes se mueven rápidamente para detenernos. Pero no hay esperanza para ellos. Tatooine es solo el comienzo. La rebelión será aplastada bajo el poder del Imperio, y los traidores que se atrevan a desafiar nuestra voluntad aprenderán lo que significa enfrentarse al poder del Emperador.");
                Console.WriteLine("Capitán Merek Voss: El plan sigue en marcha. Comiencen los preparativos para aplastar acualquiera que intente deteneros. Acabaremos con cualquier pizca de esperanza que les quede. El Imperio es inevitable.");

            }

        }

        static void EnterParaContinuar()
        {
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadLine();
        }

        static int[] GenerarHabilidad(int[] habilidad, int inicio, int fin)
        {
            Random rnd = new Random();

            for (int i = 0; i < habilidad.Length; i++)
            {
                habilidad[i] = rnd.Next(inicio, fin);
            }
            return habilidad;
        }

        static void MostrarBando(List<string> personajes, int[] vida, int[] daño, int[] velocidad)
        {
            for (int i = 0; i < personajes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {personajes[i]} - Vida: {vida[i]}, Daño: {daño[i]}, Velocidad: {velocidad[i]}");
            }
        }
        static List<string> EquipoEnemigoAleatorio(List<string> enemigos, List<string> listaPersonaes)
        {
            Random rnd = new Random();

            for (int i = 0; i < 4; i++)
            {
                int enemigoAleatorio;
                enemigoAleatorio = rnd.Next(0, listaPersonaes.Count);
                enemigos.Add(listaPersonaes[enemigoAleatorio]);
                listaPersonaes.RemoveAt(enemigoAleatorio);
            }
            return enemigos;
        }

        static void EncuentreLosPlanos()
        { 
            // Definimos el laberinto
            char[,] laberinto = new char[,]
            {
                { '#', '#', '#', '#', '#', '#', '#', '#', '#' },
                { '#', 'P', ' ', ' ', '#', ' ', ' ', ' ', '#' },
                { '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#' },
                { '#', ' ', '#', ' ', ' ', ' ', '#', ' ', '#' },
                { '#', ' ', '#', '#', '#', ' ', '#', ' ', '#' },
                { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#' },
                { '#', '#', '#', ' ', '#', '#', '#', 'P', '#' },
                { '#', '#', '#', '#', '#', '#', '#', '#', '#' },

            };

            int jugadorFila = 1;
            int jugadorColumna = 1;
            bool jugando = true;

            while (jugando)
            {
                Console.Clear();
                // Mostrar el laberinto
                for (int i = 0; i < laberinto.GetLength(0); i++)
                {
                    for (int j = 0; j < laberinto.GetLength(1); j++)
                    {
                        Console.Write(laberinto[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\nMover (W/A/S/D): ");
                char movimiento = Console.ReadKey().KeyChar;
                movimiento = char.ToUpper(movimiento);

                int nuevafila = jugadorFila;
                int nuevaColumna = jugadorColumna;

                switch (movimiento)
                {
                    case 'W':
                        nuevafila--;
                        break;
                    case 'S':
                        nuevafila++;
                        break;
                    case 'A':
                        nuevaColumna--;
                        break;
                    case 'D':
                        nuevaColumna++;
                        break;
                    default:
                        Console.WriteLine("Movimiento invalido");
                        System.Threading.Thread.Sleep(1000);

                        continue;
                }

                // Comprobar si el movimiento es valido
                if (laberinto[nuevafila, nuevaColumna] == '#')
                {
                    Console.WriteLine("Movimiento invalido");
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    // Actualizar la posicion del jugador
                    laberinto[jugadorFila, jugadorColumna] = ' ';
                    jugadorFila = nuevafila;
                    jugadorColumna = nuevaColumna;
                    laberinto[jugadorFila, jugadorColumna] = 'P';
                    // Comprobar si el jugador ha encontrado los planos
                    if (laberinto[jugadorFila, jugadorColumna] == 'P')
                    {
                        Console.WriteLine("¡Has encontrado los planos!");
                        jugando = false;
                    }
                }


            }

        }
    }
}
