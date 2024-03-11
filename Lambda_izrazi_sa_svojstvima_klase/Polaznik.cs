using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_izrazi_sa_svojstvima_klase
{
    internal class Polaznik
    {
        public int Id {  get; set; }
        public string Ime{get; set;}
        public string Prezime { get; set;}
        public bool Status_polaznika { get; set; } = true;
    }
}
