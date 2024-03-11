using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullabilni_tipovi_s_uvjetima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? i = null;
            int j = 10;

            if (i < j)
            {
                Console.WriteLine("i je manji od j");
            }
            else if (i > j)
            {
                Console.WriteLine("i je veći od j");
            }
            else if(i == j)
            {
                Console.WriteLine("i je jednak j");
            }
            else
            {
                Console.WriteLine("Nemam pojma koja je relacija :/ "); //izbaciti će ovo kao rješenje jer "i" nema vrijednost i ne može ih usporediti,
                                                                       //uspoređivanje null vrijednosti sa bilo čime će dati false
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("====================");
            Console.WriteLine("Nullabilni tipovi s uvjetom i pomoćnim klasama: ");
            Console.WriteLine("====================");
            Console.WriteLine();

            if (Nullable.Compare<int>(i, j) < 0)
            {
                Console.WriteLine("i je manji od j"); //izbaciti će ovo kao rješenje
            }
            else if(Nullable.Compare<int>(i, j) > 0)
            {
                Console.WriteLine("i je veći od j");
            }
            else if(Nullable.Compare<int>(i, j) == 0)
            {
                Console.WriteLine("i je jednako j");
            }
            else
            {
                Console.WriteLine("Ne mogu napraviti usporedbu...");
            }
            Console.WriteLine();


        }
    }
}
