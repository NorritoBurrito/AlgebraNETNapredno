using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iznimke_ugnjezdivanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite 0: ");

            try
            {
                int broj = int.Parse(Console.ReadLine());
                try
                {
                    Console.WriteLine(100/broj);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Exception inseption :D");
                }
            }
            catch 
            {
                Console.WriteLine("Level 1 inseption :)");
            }
        }
    }
}
