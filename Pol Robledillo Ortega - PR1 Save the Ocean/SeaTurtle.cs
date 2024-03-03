using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_Save_the_Ocean
{
    public class SeaTurtle : AAnimal
    {
        public static string[] names = { "Leonardo", "Raphael", "Donatello", "Michelangelo" };
        public static string[] species = { "Tortuga Verda", "Tortuga laud", "Tortuga boba", "Tortuga kemp" };
        public SeaTurtle(string name, int superFamily, string species, int ga, double weight)
        {
            this.Name = name;
            this.SuperFamily = (ESuperFamily)superFamily;
            this.Species = species;
            this.GA = ga;
            this.Weight = weight;
        }
        /// <summary>
        /// Valida si el rescat de l'animal ha estat exitós o no
        /// </summary>
        /// <param name="option"></param>
        /// <returns>Retorna true o fals depenent de si el GA és major o menor a 5</returns>
        public override bool CalcNewGA(int option)
        {
            this.GA = this.GA - ((this.GA - 2) * (2 * this.GA + 3)) - (option == 1? 5 : 5);
            return this.GA < 5;
        }
        /// <summary>
        /// Mostra el grau d'acceptació de l'animal
        /// </summary>
        public override void ShowGA()
        {
            Console.Write("La tortuga marina té un grau d'acceptació del {0}%. ", this.GA);
        }
    }
}
