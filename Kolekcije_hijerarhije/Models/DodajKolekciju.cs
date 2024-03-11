using Kolekcije_hijerarhije.Sucelja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije_hijerarhije.Models
{
    public class DodajKolekciju<T>:IDodajUKolekciju<T>
    {
        public DodajKolekciju()
        {
            this.Podaci=new Stack<T>();
        }
        protected Stack<T> Podaci { get; set; }
        public virtual int Dodaj(T element)
        {
            this.Podaci.Push(element);
            return this.Podaci.Count -1;
        }
    }
}
