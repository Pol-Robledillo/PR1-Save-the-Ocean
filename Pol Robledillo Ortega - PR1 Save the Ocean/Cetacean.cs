using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_Save_the_Ocean
{
    public class Cetacean : AAnimal
    {
        public static string[] names = { "Tony", "Henry", "Xavier", "Vincent" };
        public static string[] species = { "Balena", "Orca", "Dofí", "Narval" };
        public Cetacean(string name, int superFamily, string species, int ga, double weight)
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
            this.GA = this.GA - Convert.ToInt32((Math.Log10(this.GA))) - (option == 1 ? 25 : 0);
            return this.GA < 5;
        }
        /// <summary>
        /// Mostrem el grau d'acceptació de l'animal
        /// </summary>
        public override void ShowGA()
        {
            Console.Write("El cetaci té un grau d'acceptació del {0}%. ", this.GA);
        }
    }
}
