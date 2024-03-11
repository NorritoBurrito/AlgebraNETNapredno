using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sucelja_ali_eksplicitna.Sucelja;

namespace Sucelja_ali_eksplicitna.Models
{
    public class Gradanin : IStanovnik, IOsoba
    {
        public Gradanin(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }
        public string Ime {  get; private set; }

        public string Prezime {  get; private set; }

        public string Drzava {get; private set; }

        public int Godine {get; private set; }

        string IStanovnik.DohvatiImePrezime()
        {
            return "Gdin/Gđa/Gđica " + Ime + " " + Prezime;
        }
        string IOsoba.DohvatiImePrezime()
        {
            return Ime + " " + Prezime;
        }
        public string DohvatiImePrezime()
        {
            return "pozdrav od "+Ime+ " "+Prezime;
        }
    }
}
