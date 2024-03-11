using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Delegati_multicast
{
    public delegate void TestDelegat(string poruka);
    internal class Program
    {
        static void Main(string[] args)
        {
            TestDelegat d1 = KlasaA.MetodaA;
            TestDelegat d2 = KlasaB.MetodaB;

            TestDelegat del = d1 + d2;
            del("Prvi poziv!");
            Console.WriteLine("===================");

            TestDelegat d3 = (string p) => Console.WriteLine("Poziv preko lambda izraza: " + p);
            del += d3;
            del("Drugi poziv!");
            Console.WriteLine("===================");

            del = del - d2;
            del("Treći poziv!");
            Console.WriteLine("===================");

            del -= d2; //a u minus ne možemo ići više nego jednom, jednom kad pomaknemo više je neće biti i ako se ponovi kod neće se ništa desiti
            del("Četvrti poziv!");
            Console.WriteLine("===================");

            del += d1; //više puta se može jedna te ista metoda izvršiti !!
            del("Peti poziv!");
            Console.WriteLine("===================");

            del -= d1; //ovim slučajem miče samo jednu ne oba d1
            del("Šesti poziv!");
            Console.WriteLine("===================");

        }
    }

    public class KlasaA
    {
        public static void MetodaA(string poruka)
        {
            Console.WriteLine("Pozvali smo KlasaA.MetodaA() s parametrom: " + poruka);
        }
    }

    public class KlasaB
    {
        public static void MetodaB(string poruka)
        {
            Console.WriteLine("Pozvali smo KlasaB.MetodaB() s parametrom: " + poruka);
        }
    }

}
