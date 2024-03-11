using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonimne_metode_i_delegati
{
    class Zaposlenik
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public double Placa { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Zaposlenik> lista_zaposlenika = new List<Zaposlenik>()
            {
                new Zaposlenik{ID=101, Ime="Tin", Prezime="Ujević", Placa=1000},
                new Zaposlenik{ID=102, Ime="Faust", Prezime="Vrančić", Placa=2000},
                new Zaposlenik{ID=103, Ime="Antun Gustav", Prezime="Matoš", Placa=3000},
                new Zaposlenik{ID=104, Ime="Marko", Prezime="Marulić", Placa=4000},
                new Zaposlenik{ID=105, Ime="Ivan", Prezime="Gundulić", Placa=5000}
            };

            Zaposlenik z = lista_zaposlenika.Find
                (
                delegate (Zaposlenik x)
                {
                    return x.ID == 103;
                }
                );
            Console.WriteLine($"ID: {z.ID}, Ime i prezime: {z.Ime + " " + z.Prezime}, plaća {z.Placa}");
        }
    }
}
