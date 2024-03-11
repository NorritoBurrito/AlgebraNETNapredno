using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja_za_ferrari.Automobili
{
    public interface Automobil //kod interface ne smijemo imati nikakvu interpretaciju nego samo nabrojimo što će nam biti unutra
    {
        string Model { get; }
        string Vozac { get; }
        string Kocnice();
        string Gorivo();

    }
}
