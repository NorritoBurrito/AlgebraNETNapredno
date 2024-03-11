using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_izrazi_vs_delegati
{
    internal class Program
    {
        const int _max = 10000000;
        static void Main(string[] args)
        {
            int[] niz = { 1 };
            Func<int, bool> verzijaDelegata = delegate (int argument)
            {
                return argument == 1;
            };

            //upotreba lambda izraza za brojanje
            var s1=Stopwatch.StartNew();
            for(int i =0;i<_max;i++)
            {
                if (niz.Count(element => element == 1) == 0)
                {
                    return;
                }
            }
            s1.Stop();

            //upotreba delegata za brojanje
            var s2=Stopwatch.StartNew();
            for(int i =0;i<_max; i++)
            {
                if (niz.Count(verzijaDelegata) == 0)
                {
                    return;
                }
            }
            s2.Stop();

            Console.WriteLine
                (
                 "Lambda izraz: " + ((double)(s1.Elapsed.TotalMilliseconds*1000000)/_max).ToString("0.00 ns")
                );
            Console.WriteLine
                (
                 "Delegat: " + ((double)(s2.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ns")
                );

        }
    }
}
