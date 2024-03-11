using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja_za_ferrari.Automobili
{
    public class Ferrari:Automobil
    {
        public Ferrari() { }
        public Ferrari(string vozac, string model)
        {
            Vozac = vozac;
            Model = model;
        }

        public string Model { get; private set; }
        public string Vozac { get; private set; }
        public string Gorivo()
        {
            return "Pije ko smrt";
        }
        public string Kocnice()
        {
            return "Koči!";
        }
        public override string ToString()
        {
            return $"{Model}/{Kocnice()}/{Gorivo()}/{Vozac}";
        }
    }
}
