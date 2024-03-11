using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati_genericki
{
    public delegate T add<T>(T p1, T p2);
    internal class Program
    {
        static void Main(string[] args)
        {
            add<int> z = Zbroj;
            Console.WriteLine(z(10,20));

            add<string> k = Konkatenacija;
            Console.WriteLine(k("Pozdrav", " svima :) "));
        }

        public static int Zbroj(int b1, int b2)
        {
            return b1 + b2;
        }

        public static string Konkatenacija(string r1, string r2)
        {
            return r1 + r2;
        }
    }
}
