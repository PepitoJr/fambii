using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoir1
{
    internal class Serveur 
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Serveur (string nom,string prenom) 
        {
            Nom = nom;
            Prenom = prenom;    
        }
        public void AfficherDetails() 
        {
            Console.WriteLine("Nom du serveur:'{Nom}'\nPrenom du serveur:'{Prenom}'");
        }
    }
}
