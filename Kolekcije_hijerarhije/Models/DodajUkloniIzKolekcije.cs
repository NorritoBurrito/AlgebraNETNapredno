
using Kolekcije_hijerarhije.Sucelja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije_hijerarhije.Models
{
    public class DodajUkloniIzKolekcije<T> : DodajKolekciju<T>, IDodajUkloniIzKolekcije<T>
    {
        private const int IndexZaDodavanjeNovogElementa = 0;
        public virtual T Ukloni()
        {
            return this.Podaci.Pop();
        }

        public override int Dodaj(T element)
        {
            this.Podaci=new Stack<T>(new T[] {element}.Concat(this.Podaci.Reverse()));
            return IndexZaDodavanjeNovogElementa;
        }
    }
}
