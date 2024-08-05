using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoir1
{
    internal class Plat
    {
        public string Nom { get; set; }
        public int Prix { get; set; }
        public string Categorie { get; set; }
        public Plat (string nom,int prix,string categorie) 
        {
            Nom = nom;
            Prix = prix;
            Categorie = categorie;
        }
        public void AfficherDetails() 
        {
            Console.WriteLine($"nom du plat '{Nom}'\n Prix du plat: '{Prix}'\nCategorie du plat: '{Categorie}'");
        }
    }
}
