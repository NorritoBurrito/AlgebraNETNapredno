using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja_ali_eksplicitna.Sucelja
{
    public interface IOsoba
    {
        string Ime { get; }
        string Prezime { get; }
        int Godine { get; }
        string DohvatiImePrezime();
    }
}
