using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije_slijed_s_redom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Broj slijedova: ");
            var n=long.Parse(Console.ReadLine());

            var slijed=new Queue<long>();
            slijed.Enqueue(n);
            var s = n;

            for(int i=0, skipCount=0;i<49;i++)
            {
                switch (i % 3)
                {
                    case 0:
                        s=slijed.ToArray().Skip(skipCount).Take(1).ToArray()[0];
                        slijed.Enqueue(s + 1);
                        skipCount++;
                        break;
                    case 1:
                        slijed.Enqueue(s * 2 + 1);
                        break;
                    case 2:
                        slijed.Enqueue(s + 2);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(" ",slijed));
        }
    }
}
