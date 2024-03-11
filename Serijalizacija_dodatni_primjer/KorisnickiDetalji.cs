using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serijalizacija_dodatni_primjer
{
    [Serializable]
    public class KorisnickiDetalji
    {
        public int ID {  get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public KorisnickiDetalji(int id, string ime, string prezime, string prebivaliste) 
        {
            ID = id; 
            Ime = ime; 
            Prezime = prezime; 
            Adresa = prebivaliste;
        }

        public void DohvatiDetalje()
        {
            Console.WriteLine("Šifra korisnika: "+ID);
            Console.WriteLine("Ime i prezime korisnika: "+Ime+" "+Prezime);
            Console.WriteLine("Adresa prebivališta: "+Adresa);
        }
    }
}
