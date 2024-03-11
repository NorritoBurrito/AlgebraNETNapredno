using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iznimke_korisnicki_definirane
{
    internal class Temperatura
    {
        int temperatura = 0;

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="TemperaturaJeNula"></exception>

        public void PrikaziTemperaturu()
        {
            if (temperatura == 0)
            {
                throw new TemperaturaJeNula("Temperatura je 0!!!");
            }
            else
            {
                Console.WriteLine("Temperatura je {0}", temperatura);
            }
        }
    }
}
