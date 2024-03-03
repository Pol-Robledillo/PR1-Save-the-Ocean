using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_Save_the_Ocean
{
    public class Game
    {
        public static int successXP = 50;
        public static int failureXP = 20;
        /// <summary>
        /// Mostra el títol del joc
        /// </summary>
        public static void Title()
        {
            Console.WriteLine("-------------------------------\r\n" +
                              "\tSave the Ocean!\r\n" +
                              "-------------------------------");
        }
        /// <summary>
        /// Mostra les opcions d'inici del joc
        /// </summary>
        public static void ChooseStartOption()
        {
            Console.WriteLine("Què vols fer?");
            Console.WriteLine("1. Jugar!");
            Console.WriteLine("2. Sortir");
        }
        /// <summary>
        /// Mostra les opcions de tria de ocupació
        /// </summary>
        public static void ChooseOccupation()
        {
            Console.WriteLine("Que vols ser?");
            Console.WriteLine("1. Tècnic (45 XP)");
            Console.WriteLine("2. Veterinari (80 XP)");
        }
        /// <summary>
        /// Pregunta el nom del jugador
        /// </summary>
        public static void InsertNameMsg()
        {
            Console.WriteLine("Com et dius?");
        }
        /// <summary>
        /// Mostra l'enunciat del rescat
        /// </summary>
        /// <param name="player">S'utilitza per saber el nom del jugador</param>
        public static void RescueCallMsg(Player player)
        {
            Console.WriteLine("Hola, {0}! El 112 ha rebut una trucada d’avís d’un exemplar a rescatar. \r\nLes dades que ens han donat són les següents:", player.Name);
        }
        /// <summary>
        /// Missatge de dades de l'animal
        /// </summary>
        public static void AnimalInfoMsg()
        {
            Console.WriteLine("Aquí tens la seva fitxa, per a més informació:");
        }
        /// <summary>
        /// Mostra les opcions de tria de tractament
        /// </summary>
        public static void ChooseOption()
        {
            Console.WriteLine("Què vols fer?");
            Console.WriteLine("1. Curar aquí");
            Console.WriteLine("2. Traslladar al centre");
        }
        /// <summary>
        /// Valida que l'opció sigui correcta
        /// </summary>
        /// <param name="option">Opció escollida</param>
        /// <returns>True o false depenent de si la opció és 1 o 2 o no és cap</returns>
        public static bool ValidateOption(int option)
        {
            return option == 1 || option == 2;
        }
        /// <summary>
        /// Valida l'opció d'inici del joc
        /// </summary>
        /// <param name="option">Opció escollida</param>
        /// <returns>True o fals depenent de si la opció és 1 o no</returns>
        public static bool ValidateStartGame(int option)
        {
            return option == 1;
        }
        /// <summary>
        /// Valida l'opció de finalitzar el joc
        /// </summary>
        /// <param name="option">Opció escollida</param>
        /// <returns>True o fals depenent de si la opció és 2 o no</returns>
        public static bool ValidateEndGame(int option)
        {
            return option == 2;
        }
        /// <summary>
        /// Genera un número aleatori
        /// </summary>
        /// <param name="max">Indica el número màxim +1</param>
        /// <returns>Retorna un número aleatori entre 0 i el número máxim introduït +1</returns>
        public static int Random(int max)
        {
            Random random = new Random();
            return random.Next(max);
        }
        /// <summary>
        /// Genera un número aleatori entre dos valors
        /// </summary>
        /// <param name="min">Indica el número mínim</param>
        /// <param name="max">Indica el número màxim +1</param>
        /// <returns>Retorna un número aleatori entre el número mínim introduït i el número máxim introduït +1</returns>
        public static int Random(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        /// <summary>
        /// Genera un número decimal aleatori entre dos valors
        /// </summary>
        /// <param name="min">Indica el número mínim</param>
        /// <param name="max">Indica el número màxim +1</param>
        /// <returns>Retorna un número decimal aleatori entre el número mínim introduït i el número máxim introduït +1</returns>
        public static double RandomDouble(double min, double max)
        {
            Random random = new Random();
            return random.NextDouble() * (max - min) + min;
        }
        /// <summary>
        /// Mostra el missatge d'exit del rescat per l'animal de tipus SeaTurtle
        /// </summary>
        /// <param name="animal">S'utilitza per saber el GA</param>
        public static void RescueSuccess(SeaTurtle animal)
        {
            Console.WriteLine("El tractament aplicat ha reduït el GA fins al {0}%. L’exemplar està recuperat i pot tornar al seu hàbitat. \r\nLa teva experiència ha augmentat en +{1}XP.", animal.GA, successXP);
        }
        /// <summary>
        /// Mostra el missatge de fracàs del rescat per l'animal de tipus SeaTurtle
        /// </summary>
        /// <param name="animal">S'utilitza per saber el GA</param>
        public static void RescueFailure(SeaTurtle animal)
        {
            Console.WriteLine("El tractament aplicat ha reduït el GA fins al {0}%. No ha estat prou efectiu i cal traslladar l’exemplar al centre. \r\nLa teva experiència s’ha reduït en -{1}XP.", animal.GA, failureXP);
        }
        /// <summary>
        /// Mostra el missatge d'exit del rescat per l'animal de tipus SeaBird
        /// </summary>
        /// <param name="animal">S'utilitza per saber el GA</param>
        public static void RescueSuccess(SeaBird animal)
        {
            Console.WriteLine("El tractament aplicat ha reduït el GA fins al {0}%. L’exemplar està recuperat i pot tornar al seu hàbitat. \r\nLa teva experiència ha augmentat en +{1}XP.", animal.GA, successXP);
        }
        /// <summary>
        /// Mostra el missatge de fracàs del rescat per l'animal de tipus SeaBird
        /// </summary>
        /// <param name="animal">S'utilitza per saber el GA</param>
        public static void RescueFailure(SeaBird animal)
        {
            Console.WriteLine("El tractament aplicat ha reduït el GA fins al {0}%. No ha estat prou efectiu i cal traslladar l’exemplar al centre. \r\nLa teva experiència s’ha reduït en -{1}XP.", animal.GA, failureXP);
        }
        /// <summary>
        /// Mostra el missatge d'exit del rescat per l'animal de tipus Cetacean
        /// </summary>
        /// <param name="animal">S'utilitza per saber el GA</param>
        public static void RescueSuccess(Cetacean animal)
        {
            Console.WriteLine("El tractament aplicat ha reduït el GA fins al {0}%. L’exemplar està recuperat i pot tornar al seu hàbitat. \r\nLa teva experiència ha augmentat en +{1}XP.", animal.GA, successXP);
        }
        /// <summary>
        /// Mostra el missatge de fracàs del rescat per l'animal de tipus Cetacean
        /// </summary>
        /// <param name="animal">S'utilitza per saber el GA</param>
        public static void RescueFailure(Cetacean animal)
        {
            Console.WriteLine("El tractament aplicat ha reduït el GA fins al {0}%. No ha estat prou efectiu i cal traslladar l’exemplar al centre. \r\nLa teva experiència s’ha reduït en -{1}XP.", animal.GA, failureXP);
        }
        /// <summary>
        /// Mostra el missatge de finalització del rescat
        /// </summary>
        public static void RescueEnd()
        {
            Console.WriteLine("Fins al proper rescat! (Prem qualsevol tecla per continuar)");
        }
        /// <summary>
        /// Mostra el missatge de finalització del joc
        /// </summary>
        public static void EndGame()
        {
            Console.WriteLine("Gràcies per jugar!");
        }
    }
}
