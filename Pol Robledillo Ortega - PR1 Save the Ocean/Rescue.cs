using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_Save_the_Ocean
{
    public class Rescue
    {
        public static string[] locations = { "Palamós", "Calella de Palafrugell", "Platja 'Aro", "Lloret de Mar" };
        public string? NumRescue { get; set; }
        public string? Date { get; set; }
        public string? Location { get; set; }
        public Rescue(string numRescue, string date, string location)
        {
            this.NumRescue = numRescue;
            this.Date = date;
            this.Location = location;
        }
        /// <summary>
        /// Mostra la informació del rescat
        /// </summary>
        /// <returns>Retorna un string amb la informació del rescat</returns>
        public override string ToString()
        {
            return "+-----------------------------------------------------------------------+\r\n" +
                   "|                                 RESCAT                                |\r\n" +
                   "+-----------------------------------------------------------------------+\r\n" +
                   "|# Rescat|Data Rescat\t\t|Superfamilia\t|GA\t|Localització\t|\r\n" +
                   "+-----------------------------------------------------------------------+\r\n" +
                   "| {0} |{1}\t|{2}\t|{3}\t|{4}\t|\r\n" +
                   "+-----------------------------------------------------------------------+";
        }
        /// <summary>
        /// Genera un número de rescat
        /// </summary>
        /// <returns>Retorna un string amb el número del rescat</returns>
        public static string GenerateNumRescue()
        {
            return "RES" + Game.Random(10) + Game.Random(10) + Game.Random(10);
        }
    }
}
