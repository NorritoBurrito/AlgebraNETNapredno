using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja_i_logika_jednakosti
{
    public class UpraviteljUsporedivanjaOsoba : IEqualityComparer<Osoba>
    {
        public bool Equals(Osoba x, Osoba y)
        {
            return x.CompareTo(y)==0;
        }

        public int GetHashCode(Osoba obj)
        {
            return $"{obj.Ime} {obj.Prezime} {obj.Dob}".GetHashCode();
        }
    }
}
