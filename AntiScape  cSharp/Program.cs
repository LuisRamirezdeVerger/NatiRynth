using System;
using System.Security.Cryptography;

namespace AntiScape__cSharp
{
    class Game    
    {
        public static int vida = 3;
        //public static string[] inventario;
        //Piensa en quitar el inventario, por ahora da mas problema del que arregla
        //public static string consola = Console.ReadLine();

        static void Main(string[] args)
        {
            //Cambiar aqui cuando termine es test
            //Laberinto.Segmento4();
            //Mejorar tutorial. Hacer saber que no tiene que esperar más de 5s para PULSAR INTRO
            Console.WriteLine("Bienvenidos a NatiRynth, este juego es una aventura textual, lo que significa que carece de gráficos. " +
                "Para jugar, deberás introducir comandos. El juego consiste en que adivines que comando he programado yo para según que situación. Si te quedas sin saber que hacer, bueno, en parte en el texto está la respuesta. ^^' ");
            Console.WriteLine("¡Sabrás hacerlo sin problemas!");
            Console.WriteLine("En algunos momentos, el texto se generará automáticamente. Si han pasado 5s y te falta texto, pulsa INTRO para continuar");
            Console.Read();
            Console.WriteLine("Lo vas pillando :)");
            Console.Read();
            Console.Clear();
            Console.WriteLine("Te recomiendo encarecidadmente leer todo minuciosamente... En el TEXTO está la respuesta y no todo se repite...");
            Console.Read();
            Console.WriteLine("¡Disfruta de la experiencia!");
            System.Threading.Thread.Sleep(3000);            
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(3000); 
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Threading.Thread.Sleep(2500);
            Console.WriteLine("En serio... En el TEXTO... está la respuesta...");
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            Juego();
        }

        public static void EscribeComando()
        {
            Console.WriteLine("Escribe tu comando:  ");
        }

        public static void Juego()
        {
            Console.WriteLine("Hola, player. Escribe tu nickname: ");

            string nick = Console.ReadLine();

            Console.WriteLine("Welcome, {0}, que comience el juego...", nick);
            Console.WriteLine("Pulsa INTRO para continuar...");

            string nick1 = nick;
            
            Console.ReadLine();

            //Mirar con calma el tema de colores, puede dar mucho juego.
            Console.ForegroundColor = ConsoleColor.White;


            Console.Read();
            Console.Clear();
            Console.WriteLine("Después de un frío y lluvioso invierno, por fin quedas con tu pandilla para ir al nuevo parque de atracciones que ha abierto en tu ciudad. ");

            Console.Read();
            Console.WriteLine("Te despiertas tarde, hoy es sábado y el cuerpo lo sabe. Te desperezas una última vez y te dispones a levantarte...\n");
            Console.Read();
            Console.WriteLine("En casa no hay nadie, hoy han salido a almorzar. Engulles el almuerzo, tus ganas de diversión son mayores que cualquier mal. ");
            Console.Read();
            Console.WriteLine("Al terminar de comer, por fin llega la hora de salir. ");
            Console.Read();
            Console.WriteLine("*CLOOOOONK*, *CLOOOOONK*. ");
            Console.Read(); 
            Console.WriteLine("Parece que tus amigos han llegado a recogerte... ");
            Console.Read();
            Console.WriteLine("Después de un corto viaje, por fin llegáis al parque de atracciones y os encamináis al laberinto.  ");
            Console.Read();
            Console.WriteLine("- Amigo0: {0}, Por fin hemos llegado a NatiRynth, ¿estás preparado para el laberinto? ", nick1);
            PrePrologo();
                        
        }

        public static void PrePrologo() 
        {
            Console.WriteLine("Escribe tu respuesta: ");
            string consola = Console.ReadLine();
          
     

            switch (consola)
            {
                case "si":                   
                    Console.WriteLine("~ Te dice con exaltación. ~ ¡Yo también! ¡Vamos, vamos! Justo allá está el laberinto. ");
                    Console.Read();
                    //Poner aquí el prologo
                    Prologo();
                    
                    break;
                case "no":
                    Console.WriteLine("~ Te dice con tono amistoso. ~ - ¿Y para qué venís? Ya lo teníamos hablado, si a vos no le gusta... Bueno, ya sabés... Siempre podés volver a casa... ");
                    //Console.Read();
                    Console.WriteLine("- ¿Vas a querer venir?");
                    PrePrologo();
                    break;
                case "callate":
                    Console.WriteLine("- Bueno, bueno, bueno. ¡No hacé falta ponerse así! ");
                    //Dejalo así
                    Console.WriteLine("Mejor callate vos y deme una respuesta. ");
                    PrePrologo();
                    break;
               
                default:
                    Console.WriteLine("- ¿Cómo? No entendí verga... ");
                    PrePrologo();
                    break;
            }
        }


        public static void Prologo()
        {
            Console.Read();
            Console.WriteLine("Vais directos hacia el laberinto. Alrededor hay muchas atracciones de todo tipo. Justo frente a ti hay un ");
            //Describir mejor el edificio
            Console.WriteLine("gran cartel en el que está escrito 'NATIRYNTH' en una tipografía un tanto tenebrosa. Al acercaros, ves un pequeño edificio morado. ");
            Console.Read();

            Console.WriteLine("Hay un tipo con rasgos siniestros. ");
            Console.Read();
            Console.WriteLine("Parece que es el recibidor...");
            //Console.BackgroundColor = ConsoleColor.Green;
            //Hacer saber que el tío es creepy
            Console.WriteLine("Se le ve muy amable y cordial. Cuando cruzáis las miradas, todo cambia...");
            Console.Read();
            Console.WriteLine("Su rostro torna a seriedad absoluta mientras os estáis mirando.");
            Console.Read();
            Console.WriteLine("A los pocos segundos, sin parpadear ni dejar de mirarte, empieza a esbozar una sonrisa. ");
            Console.Read();
            Console.WriteLine("Sigue sin parpadear... ");
            Console.Read();
            Console.WriteLine("Esa mirada de asesino... Parece que nunca termina de esbozar la sonrisa...  Te hace pensar, pero al mirar alrededor y ver" +
                " a tus amigos flipando con la actuación, te relajas. ");
            Console.Read();
            Console.WriteLine("Por fin parpadea! Todo va bien. Os saluda a todos y garraspea su garganta. ");
            Console.Read();
            Console.WriteLine("De repente, una voz de ultratumba sale del 'recibidor'. " +
                "¡¡¡BIEEENVENIDOS A NATIRYNTH!!! Un laberinto en el que toooodos saben entrar, pero ¡NO! tooooodos saben entrar! ");
            Console.Read();
            Console.Clear();
            Console.WriteLine("¿Creéis que sois más inteligentes que nosotros?");
            Console.Read();
            Console.WriteLine("ADELAAAAANTE. Dudo que entréis, y mucho menos que completéis el dilema... ");
            Console.Read();
            Console.WriteLine("¡Gracias! Y... ¡Buena suerte!");
            Console.Read();
            Console.WriteLine("La verdad es que te ha dado grima, pero tus amigos aplauden y silban por lo bien que lo ha hecho. 'No sé Rick, parece falso...'");
            Console.Clear();
            Console.WriteLine("Justo antes de entrar, os para con un: '¡HEY!' ");
            Console.Read();
            Console.WriteLine("¿Sabéis qué? Me habéis caído bien, os voy a dar una pista de como jugar: ");
            Console.Read();
            Console.WriteLine("Una vez cerréis la puerta, vuestros pensamientos serán los que os dirijan. ");
            Console.Read();
            Console.WriteLine("Si estáis un poco perdidos, sugestiono 'mirar alrededor', siempre es bueno saber donde estáis, ¿no creéis?");
            Console.Read();
            Console.WriteLine("Así que ojito con lo que escrib... *¡ejem!* Pensáis. ");
            Console.Read();
            Console.WriteLine("Al momento, vuelve a su puesto. Vosotros, os adentráis y veis una sala completamente blanca con una puerta para cada persona. ");
            Console.Read();
            Console.WriteLine("Hay algo en la puerta que te llama mucho la atención, es una puerta ordinaria con colores muy llamativos, pero parece de plastilina. ");
            Console.Read();
            Console.WriteLine("No puedes evitar tus ganas de tocarla...");
            System.Threading.Thread.Sleep(5000);
            //PrePrologo();

            Laberinto.TextoSegmento0();
        }

        

        public static void PruebaReinicio(){

            string consola = Console.ReadLine();


            switch (consola)
            {
                case "ir derecha":
                    Console.WriteLine("Te chocas contra la pared de tu derecha.");
                    MenosVida();
                    Console.WriteLine("Pierdes una vida");
                    if (Game.vida <= 0)
                    {
                    Reinicio();
                    }
                    else
                    {
                        //Console.WriteLine(Game.vida);
                        Prologo();
                    }
                    break;
                case "ir izquierda":
                    Console.WriteLine("Vas a la izquierda");
                    Laberinto.Segmento0();
                    Prologo();
                    
                    break;
                case "mirar alrededor":
                    Console.WriteLine("descripcion de la room");
                    Prologo();
                    break;
                case "saltar":
                    Console.WriteLine("Saltas de plano");
                    Habitacion10();
                    break;
                default:
                    Console.WriteLine("Error codigo no encontrado.");
                    Prologo();
                    break;
            }

        }

        public static void Habitacion10()
        {
            Console.Clear();
            //Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Estas en un plano astral");
            Console.Read();
        }

        public static void Reinicio()
        {
            do
            {

                if (Game.vida <= 0)
                {

                    Console.WriteLine("Te has quedado sin vida. Reiniciar? Si/No ");
                    string consola = Console.ReadLine();
                    

                    if (consola == "Si")
                    {
                        Console.WriteLine("Pulsa una tecla... ");
                        Console.Read(); 
                        Juego();

                    }
                    else if (consola == "No")
                    {
                        Console.Read();
                        Console.WriteLine("Fin del juego");
                        FinDelJuego();
                    }
                    else if (consola == "Sí")
                    {
                        Console.Read();
                        Console.WriteLine("Tú sí que sabes..s.");
                        Console.Read();
                        Console.WriteLine("Aun así...");
                        FinDelJuego();
                    }
                    else
                    {
                        Console.ReadLine();
                        Console.WriteLine("Hemos dicho, Si o No, tu dirás ...");
                        Reinicio();
                    }

                }

                
            }
            while (Game.vida > 0);

            
        }

        //Idea para limpiar el código
        public static void TeTocaEscribir()
        {
            Console.WriteLine("¿Qué quieres hacer ahora?");
            Console.Read();
            string console = Console.ReadLine();

        }

        public static void RecuentoLogros(int recuentoLogros = 0)
        {
             
            if (recuentoLogros > 0)
            {
                //Se podria crear un contador en "Program.cs", crear uno en "Laberinto.cs" y sumarlos en Program para que quede centralizado.
                Console.WriteLine("Tus logros totales son {0}", recuentoLogros);
            }
        }
        
        
        public static void MenosVida()
        {
            Game.vida--;
        }

        private static void FinDelJuego()
        {
            Console.WriteLine("Cagooon");
            Console.Read();
        }

    }


    


}