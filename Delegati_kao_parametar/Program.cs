using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati_kao_parametar
{
    public delegate void TestDelegat(string poruka);
    internal class Program
    {
        static void Main(string[] args)
        {
            TestDelegat del;
            del = KlasaA.MetodaA;
            PozivanjeDelegata(del);

            del=KlasaB.MetodaB;
            PozivanjeDelegata(del);

            del = (string p) => Console.WriteLine("Poziv preko Lambda izraza s parametrom: " + p);
            PozivanjeDelegata(del);
        }

        static void PozivanjeDelegata(TestDelegat td)
        {
            td("Zovem delegat");
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
