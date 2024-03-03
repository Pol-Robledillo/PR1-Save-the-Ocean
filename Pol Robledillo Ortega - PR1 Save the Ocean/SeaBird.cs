using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_Save_the_Ocean
{
    public class SeaBird : AAnimal
    {
        public static string[] names = { "Piolín", "Lucas", "Donald", "Daisy" };
        public static string[] species = { "Albatros", "Pingüí", "Gavina", "Pelicà" };
        public SeaBird(string name, int superFamily, string species, int ga, double weight)
        {
            this.Name = name;
            this.SuperFamily = (SuperFamily)superFamily;
            this.Species = species;
            this.GA = ga;
            this.Weight = weight;
        }
        /// <summary>
        /// Valida si el rescat de l'animal ha estat exitós o no
        /// </summary>
        /// <param name="option">S'utilitza per saber si cures a l'animal al lloc o el portes al centre</param>
        /// <returns>Retorna true o fals depenent de si el GA és major o menor a 5</returns>
        public override bool CalcNewGA(int option)
        {
            this.GA = this.GA - (Convert.ToInt32(Math.Pow(this.GA, 2)) + (option == 1 ? 5 : 0));
            return this.GA < 5;
        }
        /// <summary>
        /// Mostra el grau d'acceptació de l'animal
        /// </summary>
        public override void ShowGA()
        {
            Console.Write("L'au marina té un grau d'acceptació del {0}%. ", this.GA);
        }
    }
}
