using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statickeVarijable
{
    class Program
    {
        static void Main(string[] args)
        {
            PrvaKlasa prvi = new PrvaKlasa("Pero", "Perić");
            Console.WriteLine(prvi.ToString());

            PrvaKlasa drugi = new PrvaKlasa("Ivica", "Ivić");
            Console.WriteLine(drugi.ToString());

            PrvaKlasa treci = new PrvaKlasa();
            Console.WriteLine(treci.ToString());

            treci.Ime = "Milorad";
            treci.Prezime = "Milić";

            Console.WriteLine(treci.ToString());
   
            Console.ReadKey();

        }
    }
}
