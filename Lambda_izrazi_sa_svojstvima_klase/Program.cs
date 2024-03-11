using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_izrazi_sa_svojstvima_klase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Polaznik> polaznici=new List<Polaznik>()
            {
                new Polaznik { Id = 1, Ime = "Nikola", Prezime = "Tesla" },
                new Polaznik { Id = 2, Ime = "Ivana", Prezime = "Brlić Mažuranić", Status_polaznika = false },
                new Polaznik { Id = 3, Ime = "Ruđer", Prezime = "Bošković" },
                new Polaznik { Id = 4, Ime = "Stjepan", Prezime = "Radić", Status_polaznika=false },
                new Polaznik { Id = 5, Ime = "Ivo", Prezime = "Andrić" },
                new Polaznik { Id = 6, Ime = "Josip", Prezime = "Jelačić", Status_polaznika=true }
            };

            var sortirano = polaznici.OrderBy(x => x.Prezime);
            Console.WriteLine("Polaznici sortirani po prezimenu: ");
            foreach(Polaznik p in sortirano)
            {
                Console.WriteLine(p.Id+ "  "+p.Ime+"  "+p.Prezime);
            }

            Console.WriteLine();
            Console.WriteLine();

            sortirano.ToList().ForEach(x => Console.WriteLine($"{x.Id} {x.Ime} {x.Prezime}"));

            Console.WriteLine();
            Console.WriteLine();

            var inicijali_polaznika = polaznici.Select(x => new
            {
                Id=x.Id,
                SlovoImena = x.Ime[0],
                SlovoPrezimena = x.Prezime[0]
            });
            foreach(var p in inicijali_polaznika)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();
            Console.WriteLine();

            var samo_aktivni = polaznici.Where(x => x.Status_polaznika == true);
            Console.WriteLine("Aktivni polaznici: ");
            foreach(Polaznik a in samo_aktivni)
            {
                Console.WriteLine(a.Id + "  " + a.Ime + "  " + a.Prezime);
            }
        }
    }
}
