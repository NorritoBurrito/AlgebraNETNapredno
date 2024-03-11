using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonimne_metode_i_vanjske_klase
{
    delegate void DelegateBrojacTipa();

    class KreatorBrojaca
    {
        string Naziv;
        internal KreatorBrojaca(string naziv) { Naziv = naziv; }

        internal DelegateBrojacTipa KreirajBrojac(string naziv_brojaca)
        {
            int brojac = 0;
            DelegateBrojacTipa del = delegate
            {
                Console.Write(naziv_brojaca+" "+(++brojac).ToString());
                Console.WriteLine(" Brojač je izgrađen od "+Naziv);
            };
            return del;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            KreatorBrojaca tvornica1 = new KreatorBrojaca("Tvornica 1");
            KreatorBrojaca tvornica2 = new KreatorBrojaca("Tvornica 2");
            DelegateBrojacTipa brojacA=tvornica1.KreirajBrojac("Brojač A: ");
            DelegateBrojacTipa brojacB = tvornica1.KreirajBrojac("Brojač B: ");
            DelegateBrojacTipa brojacC = tvornica2.KreirajBrojac("Brojač C: ");
            brojacA();brojacA();
            brojacB();brojacB();
            brojacC();brojacC();

        }
    }
}
