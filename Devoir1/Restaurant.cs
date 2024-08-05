using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoir1
{
    internal class Restaurant
    {
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Plats { get; set; }
        public string Tables { get; set; }
        public string Serveurs { get; set; }
        public Restaurant(string nom,string adresse,string plats,string tables,string serveurs) 
        {
            Nom = nom;
            Adresse = adresse;
            Plats = plats;
            Tables = tables;
            Serveurs = serveurs;

        }
    }
}
