using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja_ali_eksplicitna.Sucelja
{
    public interface IStanovnik
    {
        string Ime { get; }
        string Prezime { get; }
        string Drzava { get; }
        string DohvatiImePrezime();
    }
}
