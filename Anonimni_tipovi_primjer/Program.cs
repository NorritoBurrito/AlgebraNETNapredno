using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonimni_tipovi_primjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=======================================");
            Console.WriteLine("Anonimni tipovi - jednostavni anonimni tip");
            Console.WriteLine("=======================================");

            var polaznik = new { ID=1, Ime="Nikola", Prezime="Tesla"};
            Console.WriteLine(polaznik.ID);
            Console.WriteLine(polaznik.Ime);
            Console.WriteLine(polaznik.Prezime);

            //polaznik.Ime = "Niđo";    NE PROLAZI jer imamo prijavljene samo getere, a ne i set, znači da je read only

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=======================================");
            Console.WriteLine("Anonimni tipovi - ugnježđivanje anonimnih tipova");
            Console.WriteLine("=======================================");

            var novi_polaznik = new //prikazati će ih sa vitičastom zagradom, isto kako smo napisali i niže
            {
                ID = 2,
                Ime = "Josip",
                Prezime = "Jelačić",
                Adresa = new { ID = 1, Grad = "Zagreb", Drzava = "Hrvatska" }
            };

            Console.WriteLine(novi_polaznik);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=======================================");
            Console.WriteLine("Anonimni tipovi - kreiranje polja anonimnih tipova");
            Console.WriteLine("=======================================");

            var polaznici = new[]
            {
                new { ID = 1, Ime = "Ivana", Prezime = "Brlić Mažuranić" },
                new { ID = 2, Ime="Ruđer", Prezime="Bošković"},
                new { ID = 3, Ime="Ivo", Prezime="Andrić"}
            };
            Console.WriteLine(polaznici); //neće nam prikazati imena niti išta nego samo da se sastoji od 3 tipa i od čega se sastoji (string, int, ...)
        }
    }
}
