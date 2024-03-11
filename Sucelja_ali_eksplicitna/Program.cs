using Sucelja_ali_eksplicitna.Models;
using Sucelja_ali_eksplicitna.Sucelja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja_ali_eksplicitna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do {
                Console.Write("Unesite ime: ");
                string ime = Console.ReadLine();
                Console.Write("Unesite prezime: ");
                string prezime = Console.ReadLine();
                if (ime == string.Empty || prezime == "Kraj") break;

                IOsoba o=new Gradanin(ime, prezime);
                Console.WriteLine(o.DohvatiImePrezime());

                IStanovnik s = new Gradanin(ime, prezime);
                Console.WriteLine(s.DohvatiImePrezime());

                Console.WriteLine();

                Gradanin g = (Gradanin)s; //- ne može se dodijeliti klasi gradanin jer je određena na drugo sučelje, osim stavljajući i implicirajući u zagradi
                Console.WriteLine(g.DohvatiImePrezime());

            } while (true);
        }
    }
}
