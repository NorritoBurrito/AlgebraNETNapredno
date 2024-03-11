using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serijalizacija_primjer
{
    [Serializable]
    class Polaznik
    {
        public int id { get; set; }
        public string Ime { get; set; }
    }
}
