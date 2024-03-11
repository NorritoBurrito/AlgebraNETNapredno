using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullabilni_tipovi_kratice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? i = null;
            /*int i2 = (int)i;*/ //prijaviti će error jer nema value

            int j = i ?? 1; //vratiti će prvi ako je null i onda će vratiti drugi

            Console.WriteLine(j);

        }
    }
}
