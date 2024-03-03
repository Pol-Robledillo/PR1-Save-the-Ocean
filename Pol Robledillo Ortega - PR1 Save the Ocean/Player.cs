using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_Save_the_Ocean
{
    public class Player
    {
        public string? Name { get; set; }
        public EOccupation Occupation { get; set; }
        public int Exp { get; set; }
        public Player(string name, int occupation, int exp)
        {
            this.Name = name;
            this.Occupation = (EOccupation)occupation;
            this.Exp = exp;
        }
        public Player() { }
        /// <summary>
        /// Mostra la informació del jugador
        /// </summary>
        /// <returns>Retorna un string amb la informacio del jugador</returns>
        public override string ToString()
        {
            return "+-----------------------------------------------+\r\n" +
                   "|                    JUGADOR                    |\r\n" +
                   "+-----------------------------------------------+\r\n" +
                   "|Nom\t\t|Ocupació\t|Experiència\t|\r\n" +
                   "+-----------------------------------------------+\r\n" +
                   "|{0}\t\t|{1}\t\t|{2}\t\t|\r\n" +
                   "+-----------------------------------------------+\r\n";
        }
    }
}
