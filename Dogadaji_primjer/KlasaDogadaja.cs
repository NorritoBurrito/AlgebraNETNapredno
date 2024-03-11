using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadaji_primjer
{
    public delegate void Notifikacija(); //delegat
    internal class KlasaDogadaja
    {
        public event Notifikacija ProcesZavrsen; //događaj

        public void ProcesPoceo()
        {
            Console.WriteLine("Ovdje je neki proces počeo.");
            //kod povezan s procesom
            KadaProcesZavrsi();
        }

        protected virtual void KadaProcesZavrsi()
        {
            ProcesZavrsen?.Invoke();
        }
    }
}
