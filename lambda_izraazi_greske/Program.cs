using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_izraazi_greske
{
    class Osoba
    {
        public string Ime { get; set; }
        public int Dob { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3, 4, 5 };
            var rez = Array.Find(array, element => element==2); //ne može se staviti bez element==2 jer će nam prijavljivati grešku

            var osobe = new Osoba[] 
            {
                new Osoba {Ime="Matko", Dob=20},
                new Osoba {Ime="Ana", Dob=30},
                new Osoba {Ime="Matej", Dob=18},
                new Osoba {Ime="Nora", Dob=23},
            };

            var osoba = Array.Find(osobe, o => o.Dob == 18);
        }
    }
}
