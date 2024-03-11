using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadaji_s_prilagodenim_klasama
{
    internal class KlasaZaStatuse:EventArgs
    {
        public bool Status { get; set; }
        public DateTime Vrijeme { get; set; }

    }
}
