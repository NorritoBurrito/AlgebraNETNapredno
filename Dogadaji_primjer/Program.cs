using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadaji_primjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KlasaDogadaja kd=new KlasaDogadaja();
            kd.ProcesZavrsen += ProcesJeZavrsio;

            kd.ProcesPoceo();
        }

        public static void ProcesJeZavrsio()
        {
            Console.WriteLine("......");
            Console.WriteLine("------");
            Console.WriteLine(",,,,,,");
            Console.WriteLine("Proces je završio.");
        }
    }
}
