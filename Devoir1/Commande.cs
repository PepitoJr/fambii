using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoir1
{
    internal class Commande:Plat
    {
        public int Quantite { get; set; }
        public string EstServi { get; set; }
        public Commande (string nom, int prix, string categorie, int quantite, string estservi):base(nom,prix,categorie)
        {
            
            Quantite = quantite;
            EstServi = estservi;
        }
        
        public new void AfficherDetails() 
        {
            base.AfficherDetails();
            Console.WriteLine($"\nLa quantite commande :{Quantite}\nLa personne servi :{EstServi}");
        }


    }
}
