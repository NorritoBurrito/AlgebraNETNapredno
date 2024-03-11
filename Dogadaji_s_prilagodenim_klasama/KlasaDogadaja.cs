using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadaji_s_prilagodenim_klasama
{
    internal class KlasaDogadaja
    {
        public event EventHandler<KlasaZaStatuse> ProcesZavrsen;

        public void ProcesPocinje()
        {
            var podaci = new KlasaZaStatuse();
            podaci.Vrijeme = DateTime.Now;

            try
            {
                Console.WriteLine("Proces je počeo.");

                podaci.Status = true;
            }
            catch (Exception ex) 
            {
                podaci.Status = false;
            }
            ProcesZavrsen?.Invoke(this, podaci);
        }
    }
}
