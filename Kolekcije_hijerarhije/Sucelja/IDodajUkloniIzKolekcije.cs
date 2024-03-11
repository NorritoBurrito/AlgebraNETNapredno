using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije_hijerarhije.Sucelja
{
    public interface IDodajUkloniIzKolekcije<T>:IDodajUKolekciju<T>
    {
        T Ukloni();
    }
}
