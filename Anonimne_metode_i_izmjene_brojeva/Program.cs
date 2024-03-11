using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonimne_metode_i_izmjene_brojeva
{
    delegate void PromjenaBrojeva(int n);
    internal class Program
    {
        static int broj = 10;
        static void Main(string[] args)
        {
            PromjenaBrojeva promjena = delegate (int x)
            {
                Console.WriteLine("Anonimna metoda: "+x);
            };

            promjena(broj);

            promjena = new PromjenaBrojeva(DodajBroj);
            promjena(5);

            promjena = new PromjenaBrojeva(Pomnozibroj);
            promjena(2);
        }

        public static void DodajBroj(int p)
        {
            broj += p;
            Console.WriteLine("Imenovana metoda: "+broj);
        }

        public static void Pomnozibroj(int q)
        {
            broj *= q;
            Console.WriteLine("Imenovana metoda: "+broj);
        }

        public static int DohvatiBroj () { return broj; }
    }
}
