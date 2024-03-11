using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_methods.library
{
    public static class DodatnaEkstenzija
    {
        public static void DodatnaMetodaEkstenzije(this ObicnaKlasa objekt_obicne_klase)
        {
            Console.WriteLine("Proširena metoda klase ObicnaKlasa koju je netko napisao.");
        }
    }
}
