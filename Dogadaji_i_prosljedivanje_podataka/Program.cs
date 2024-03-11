using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadaji_i_prosljedivanje_podataka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KlasaDogadaja kd=new KlasaDogadaja();
            kd.ProcesZavrsen += ProcesJeZavrsio;

            kd.ProcesPocinje();
        }

        public static void ProcesJeZavrsio(object sender, bool status)
        {
            if (status)
            {
                Console.WriteLine("Proces je uspješno završio.");
            }
            else
            {
                Console.WriteLine("Proces nije uspjeo!");
            }
        }
    }
}
