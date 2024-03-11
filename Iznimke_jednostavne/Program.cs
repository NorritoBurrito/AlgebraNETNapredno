using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iznimke_jednostavne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Unesite broj: ");
                    int broj = int.Parse(Console.ReadLine());

                    if (broj == 0) break;

                    Console.WriteLine($"Kvadrat broja {broj} je {broj*broj}");
                }
                catch
                {
                    Console.WriteLine("Greška kod unosa! Molimo pokušajte ponovno unijeti cijeli broj.");
                    Console.WriteLine();
                }
                finally //uvijek se izvršava iako je break prije toga napravljen, bilo iznimke ili ne on će se prikazati
                {
                    Console.WriteLine("Pokušajte unijeti novi broj.");
                    Console.WriteLine();
                    Console.WriteLine("========================");
                }
            }
        }
    }
}
