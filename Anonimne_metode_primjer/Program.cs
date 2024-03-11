using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonimne_metode_primjer
{
    public delegate void Printaj(int vrijednost);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Anonimne metode - jednostavna metoda");
            Console.WriteLine("=================================");

            Printaj printer = delegate (int broj)
            {
                Console.WriteLine("Ja sam unutar anonimne metode s brojem " + broj);
            };

            printer(100);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("Anonimne metode - s varijablama ");
            Console.WriteLine("=================================");

            printer = delegate (int broj)
            {
                broj += 10;
                Console.WriteLine("Ja sam unutar anonimne metode s brojem "+broj);
            };

            printer(100);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("Anonimne metode - metoda kao parametar ");
            Console.WriteLine("=================================");

            PrintajHelperMetoda
                (
                    delegate (int broj)
                    {
                        Console.WriteLine("Anonimna metoda kao parametar "+broj);
                    },
                    100
                );
        }

        public static void PrintajHelperMetoda(Printaj printer, int broj)
        {
            broj += 13;
            printer(broj);
        }
    }
}
