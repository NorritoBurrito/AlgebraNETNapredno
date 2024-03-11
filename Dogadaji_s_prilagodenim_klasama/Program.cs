using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadaji_s_prilagodenim_klasama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KlasaDogadaja kd=new KlasaDogadaja();
            kd.ProcesZavrsen += Kd_ProcesZavrsen;

            kd.ProcesPocinje();
        }

        private static void Kd_ProcesZavrsen(object sender, KlasaZaStatuse e)
        {
            Console.WriteLine("Proces završio u "+e.Vrijeme.ToString());
            if(e.Status) Console.WriteLine("s dobrim uspjehom!");
            else Console.WriteLine("s neuspjehom!!");
        }
    }
}
