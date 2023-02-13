using System;
using System.Security.Cryptography;

namespace AntiScape__cSharp
{
    public  static class Laberinto
    {
        //Segmento4 está ¡¡¡¡ FUCKING BUGGED !!!!
        //Posible sistema de logros poniendo contadores segun acciones, ej, "terminar el tutorial", "saltar"..: If (saltar){
        // ContadorSalto++;
        // }
        public static void TeTocaEscribir()
        {
            Console.WriteLine("¿Qué quieres hacer ahora?");
        }
        public static void Segmento0()
        {
            TeTocaEscribir();
            string consola = Console.ReadLine();
            

            if (consola == "ir norte")
            {
                Console.WriteLine("Te empiezas a adentrar lentamente en el laberinto. ");
                Console.WriteLine("Después de unos pasos, te topas con la primera pared y tu primera decisión. ");
                Segmento1();

            }
            else if (consola == "mirar alrededor")
            {
                Console.WriteLine("Te rodean 3 paredes forradas con hojas. Solo puedes ir al norte. ");
                Segmento0();

            }
            else
            {
                Console.WriteLine("Solo puedes ir norte. ");
                Segmento0();
            }

        }

        public static void Segmento1()
        {
            
            TeTocaEscribir();
            string consola = Console.ReadLine();


            if (consola == "ir oeste")
            {
                Console.WriteLine("Miras a tu izquierda, parece haber camino, pero también que los límites del laberinto están cerca. Te diriges al oeste. ");
                Segmento2();
            }
            else if (consola == "ir este")
            {
                Console.WriteLine("Cuando miras a tu derecha y observas el laberinto, da la sensación de que es kilométrico, y a la vez claustrofóbico. ");
                Console.WriteLine("Te diriges al este. ");
                Segmento3 ();
            }

            else if (consola == "ir sur")
            {
                Console.WriteLine("Vuelves sobre tus pisadas. ");
                Segmento0();
            }
            else if (consola == "mirar alrededor")
            {
                Console.WriteLine("¡Ésto es inmenso! Parece estar muy bien construido, las hojas... Bueno, son de plástico, pero las tonalidades verdes son perfectas. Tienes dos caminos a elegir, derecha o izquierda. O bueno, mejor dicho... ");
                Console.WriteLine("En serio? No querrás la respuesta, ¿no?");
                Segmento1();
            }
            else
            {
                Console.WriteLine("Los nuevos caminos son este y oeste. ");
                Segmento1();
            }
        }

        public static void Segmento2()
        {
            Console.WriteLine("Unos pasos más adelante te topas con la pared. ");
            TeTocaEscribir();
            string consola = Console.ReadLine();

            switch (consola)
            {
                case "ir sur":
                    Console.WriteLine("Te diriges al sur..? ");
                    Console.Read();
                    Console.WriteLine("No, antes alzas la vista y te das cuenta de que no hay salida. Por lo que mejor decides volver a la bifurcación del camino... ");
                    Console.Read();
                    Segmento1();
                    break;
                case "ir este":
                    Console.WriteLine("Vuelves sobre tus pasos... ");
                    Segmento1();
                    break;
                case "mirar alrededor":
                    Console.WriteLine("Es muy alto, pero observas que puedes ver algunas atracciones del parque, no parece ser el camino indicado... ");
                    Segmento2();
                    break;
                default:
                    Console.WriteLine("No puedes hacer eso >.<^ ");
                    Segmento2();
                    break;
            }
        }

        public static void Segmento3()
        {
            Console.WriteLine("Tras andar un poco, te encuentras unas ramas cruzadas en el camino lo suficientente larga como para molestar tu travesía. ");
            TeTocaEscribir();
            string consola = Console.ReadLine();
            int saltoContador = 0;

            switch (consola)
            {
                case "ir este":
                    Console.WriteLine("Al dar un paso de reconocimiento, te das cuenta de que es bastante frágil. Sigues tu camino, pero te hieres la pierna. ");
                    Console.Read();
                    Console.WriteLine("Pierdes una vida... Espera... ¿Cómo? ¿Cuántas tienes?");
                    TextoSegmento4();
                    break;
                case "mirar alrededor":
                    Console.WriteLine("Las ramas molestas, pero son frágiles y tienen muy poca altura. ");
                    Console.Read();
                    Console.WriteLine("Solo hay 2 caminos posibles, misma dirección u opuesta. ");
                    Segmento3();
                    break;
                case "saltar":
                    saltoContador++;
                    //RecuentoLogros(); --> Línea 306 de "Program.cs" <--
                    Console.WriteLine("Después de haberlo meditado el tiempo suficiente, te dispones, coges carrerilla y... ");
                    Console.Read();
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                    Console.WriteLine("Y... ");
                    Console.Read(); 
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("¡REALIZAS UN SALTO CON UNA AGILIDAD INESPERADA! ");
                    Console.WriteLine("Pulsa INTRO para continuar...");
                    Console.Read();
                    Console.WriteLine("Hay algo que sabes que no encaja, pero sienta bien... ");
                    Console.WriteLine("Después de sortear tu primer obstáculo, parece que el laberinto se ha complicado un poco. ");
                    Console.WriteLine("Pulsa INTRO para continuar...");
                    Console.Read();
                    Console.WriteLine("Conforme te adentras, observas que las hojas están marchitándose, " +
                        "una energía recorre tu cuerpo de pies a cabeza. ");
                    Console.WriteLine("Pulsa INTRO para continuar...");
                    Console.Read();
                    Console.Clear();
                    //Mirar bien aqui, el codigo ASCII no se refleja bien
                    //El ASCII de logros va aquí!
                    
                    if (saltoContador == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(" ¡ESPERA! ");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("¡Logro desbloqueado!");
                        Console.WriteLine("¡¡ PARKOUR !!");
                        System.Threading.Thread.Sleep(2000);

                        TextoSegmento4();
                    }
                    TextoSegmento4();
                    break;

                    
                case "ir oeste":
                    Console.WriteLine("Vuelves sobre tus pisadas. ");
                    Segmento2();
                    break;

                    default:
                    Console.WriteLine("No puedes hacer eso >.<^ ");
                    Segmento3();
                    break;
            }
        }

        public static void TextoSegmento4()
        {
            Console.WriteLine("Después de sortear tu primer obstáculo, parece que el laberinto se ha complicado un poco. ");
            Console.Read();
            Console.WriteLine("Conforme te adentras, observas que las hojas están marchitándose, " +
                "una energía recorre tu cuerpo de pies a cabeza. ");
            Console.Read();
            Console.Clear();
            Segmento4();
        }

        public static void TextoSegmento3SinRama()
        {
            Console.WriteLine("De repente escuchas un susurro. - ¿Y... Tus amigos? ");
            Console.Read();
            Segmento3SinRama();
        }

        public static void Segmento3SinRama()
        {
            
            Console.WriteLine("Las ramas del camino han desaparecido... Pasas sin problemas. ");
            TeTocaEscribir();
            string consola = Console.ReadLine();

            switch (consola)
            {
                case "ir este":
                    Console.WriteLine("Vuelves sobre tus pasos.  ");
                    Console.Read();
                    Segmento4();
                    break;
                case "ir oeste":
                    Console.WriteLine("Vuelves al principio. ");
                    Segmento2();
                    break;
                case "mirar alrededor":
                    Console.WriteLine("Ya no hay ramas! Ahora puedes pasar sin problema alguno... ");
                    Console.WriteLine("Pero en serio... Y los demás?");
                    Segmento3SinRama();
                    break;

                default:
                    Console.WriteLine("No puedes hacer eso >.<^ ");
                    Segmento3();
                    break;
            }
        }

        public static void Segmento4()
        { 
            Console.WriteLine("Vaya, se ha complicado un poco más el camino, ahora hay tres posibilidades. ");
            TeTocaEscribir();
            string consola = Console.ReadLine();

            //Cambiar a if/else. Solo recoge 1 input
            
            
            if (consola == "ir norte")
            {
                Console.WriteLine("Te diriges al norte, al doblar una esquina, ves otra calle sin salida. Hay que volver. ");
                Console.Read();
                Segmento4();
            }
            else if (consola == "ir sur")
            {
                TextoSegmentoPrepUerta();
                Console.WriteLine("Después de andar durante bastante tiempo, doblas una esquina, y... ");
                Console.Read();
                Console.WriteLine("Te topas con una puerta, parece diferente a la de entrada. ");
                Console.Read();
                Habitaciones.Puerta();
            }
            else if (consola == "ir este")
            {
                Console.WriteLine("Después de una esquina, no hay salida. Toca volver. ");
                Console.Read();
                Segmento4();
            }
            else if (consola == "ir oeste")
            {
                Console.WriteLine("Vuelves sobre tus pasos. ");
                Console.Read();
                Segmento2();
            }
            else if (consola == "mirar alrededor")
            {
                Console.WriteLine("Es abrumador, las paredes parecen haber crecido, la luz del sol no llega hasta aquí, pero se puede ver sin problemas... ");
                Console.WriteLine("Puedes seguir recto o cambiar de dirección. ");
                Console.Read();
                Segmento4();
            } else
            {
                Console.WriteLine("No puedes hacer eso. Segmento4 ");
                Console.Read();
                Segmento4();
            }
        }
        


        public static void TextoSegmentoPrepUerta()
        {
            Console.WriteLine("Parece que estuvieras en una cinta de andar, todo pasa a tu alrededor, pero parece que la pared no se acerca... ");
            Console.Read();
            Console.WriteLine("Atiendes al sonido y... Escuchas al mejor silencio que has escuchado en tu vida. ");
            Console.Read();
            //Laberinto.Segmento();
        }

        public static void TextoSegmento0()
        {
            //Detallar laberinto por fuera
            Console.WriteLine("Al tocarla inconscientemente abres, entras y cierras, te das cuenta de que la puerta está forrada con el mismo tipo de planta que forma el laberinto. ");
            Console.Read();
            Console.WriteLine("~Te preguntas: ~ Pero... ¿En que momento he entrado, sólo quería saber la textura de la puerta...");
            Console.Read();
            Console.WriteLine("Ves que tu lado no tiene forma de abrirse. ");
            Console.Read();
            Console.WriteLine("Ya que parece que el reto ha empezado, te concentras, respiras hondo y ... ");
            Console.ReadLine();
            Console.WriteLine("Qué empiece el juego...");
            Console.Read();
            Console.Clear();
            Console.WriteLine("Al ponerte en posición de comienzo, ves un gran laberinto de 5 metros de altura repleto de hojas con diferentes tonos del color verde. ");
            Segmento0();
        }
    }
}
