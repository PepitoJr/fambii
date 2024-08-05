using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoir1
{
    public class Table
    {
         public int Numero { get; set; }
        public int NombreDePlaces { get; set; }
        public Table (int numero, int nombredeplaces) 
        {
            Numero = numero;
            NombreDePlaces = nombredeplaces;
        }
        public void AfficherDetails() 
        {
            Console.WriteLine("Numero du plat:'{Numero}'\nNombre de places disponible:'{NombreDePlaces}'");
        }
    }
}
