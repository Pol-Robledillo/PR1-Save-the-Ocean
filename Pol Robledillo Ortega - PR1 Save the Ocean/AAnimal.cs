using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_Save_the_Ocean
{
    public abstract class AAnimal
    {
        public string? Name { get; set; }
        public ESuperFamily SuperFamily { get; set; }
        public string? Species { get; set; }
        public int GA { get; set; }
        public double Weight { get; set; }
        public abstract bool CalcNewGA(int option);
        /// <summary>
        /// Mostrem les dades de l'animal
        /// </summary>
        /// <returns>Un string amb les dades de l'animal</returns>
        public override string ToString()
        {
            return "+---------------------------------------------------------------+\r\n" +
                   "|                            FITXA                              |\r\n" +
                   "+---------------------------------------------------------------+\r\n" +
                   "|Nom\t\t|Superfamília\t|Espècie\t|Pes aproximat\t|\r\n" +
                   "+---------------------------------------------------------------+\r\n" +
                   "|{0}\t|{1}\t|{2}\t|{3}\t\t|\r\n" +
                   "+---------------------------------------------------------------+";
        }
        public abstract void ShowGA();
    }
}
