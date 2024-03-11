using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonimne_metode_i_vanjske_varijable
{
    internal class Program
    {
        delegate void DelegateBrojacTipova();

        static DelegateBrojacTipova KreirajBrojac(string NazivBrojaca)
        {
            int brojac = 0;
            DelegateBrojacTipova ret = delegate
            {
                Console.WriteLine(NazivBrojaca + (++brojac).ToString());
            };
            return ret;
        }
        static void Main(string[] args)
        {
            DelegateBrojacTipova brojacA = KreirajBrojac("Brojač A: ");
            DelegateBrojacTipova brojacB = KreirajBrojac("Brojač B: ");
            brojacA(); //odgovor će biti 1
            brojacA();
            brojacB(); //odgovor će biti 2
            brojacB();
            //zbog hvatanja vanjskih varijabli po referenci, garbage collector neće dopustiti da se uništi taj resurs koji se i dalje koristi zbog delegata

        }
    }
}
