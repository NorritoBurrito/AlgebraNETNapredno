using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serijalizacija.Library
{
    [Serializable]
    public class KlasaZaSerijalizaciju
    {
        public int Godine {  get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public static string NazivTvrtke { get; set; } = "Svi smo mi jedna tvrtka";
    }
}
