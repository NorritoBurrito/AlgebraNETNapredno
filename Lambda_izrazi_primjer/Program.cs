using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_izrazi_primjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> brojevi = new List<int>() { 66, 34, 12, 7, 8, 18, 25, 43, 13, 634, 87, 56 };

            Console.WriteLine("Lista brojeva: ");
            foreach (int i in brojevi)
            {
                Console.Write("{0} ",i);
            }

            Console.WriteLine();
            Console.WriteLine();

            var kvadrati_brojevi = brojevi.Select(x => x * x); //direktno preko lambda izraza izračunamo kvadrate svih navedenih brojeva
            Console.WriteLine("Kvadrati brojeva: ");
            foreach(var k in kvadrati_brojevi)
            {
                Console.Write("{0} ", k);
            }

            Console.WriteLine();
            Console.WriteLine();

            List<int> djeljivi_s_3=brojevi.FindAll(x => x % 3 == 0); //a ovdje preko lambde izračunamo brojeve iz liste djeljive sa 3
            Console.WriteLine("Brojevi iz liste djeljivi s 3: ");

            foreach(int broj in djeljivi_s_3)
            {
                Console.Write("{0} ",broj);
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
