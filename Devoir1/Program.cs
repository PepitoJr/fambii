using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoir1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plat plat = new Plat("Riz",2,"Principal");
            Commande command = new Commande("patate",5,"resistance",1,"Pepito");
            //plat.AfficherDetails();
            command.AfficherDetails();
        }
    }
}
