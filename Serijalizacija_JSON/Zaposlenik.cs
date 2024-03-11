using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serijalizacija_JSON
{
    public class Zaposlenik
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }

        public override string ToString()
        {
            return $"Šifra {ID}, {Ime} {Prezime}, rođen {DatumRodjenja.Date}";
        }
    }
}
