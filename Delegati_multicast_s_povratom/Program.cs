using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati_multicast_s_povratom
{
    public delegate int TestniDelegat();
    internal class Program
    {
        static void Main(string[] args)
        {
            TestniDelegat d1 = KlasaA.MetodaA;
            TestniDelegat d2=KlasaB.MetodaB;

            TestniDelegat del = d1 + d2; //prvi delegat se gubi i nestaje i pokazati će samo d2 što je 1000, return vrijednost kod delegata ostaje samo zadnja povratna vrijednost


            //TestniDelegat del = d2 + d1;
            Console.WriteLine(del());
        }
    }

    public class KlasaA
    {
        public static int MetodaA() { return 500; }
    }

    public class KlasaB
    {
        public static int MetodaB() { return 1000; }
    }
}
