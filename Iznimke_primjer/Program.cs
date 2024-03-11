using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iznimke_primjer
{
    internal class Program
    {
        static int rezultat = 0;
        static void Main(string[] args)
        {
            Dijeljenje(13, 0);
            Console.WriteLine();
            Console.WriteLine();

            Dijeljenje(55, 11);
            Console.WriteLine();
            Console.WriteLine();

        }

        static void Dijeljenje(int b1, int b2)
        {
            try
            {
                rezultat = b1 / b2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Uhvaćena iznimka {0}", e);
            }
            finally
            {
                Console.WriteLine("Rezultat je {0}",rezultat);
            }
        }
    }
}
