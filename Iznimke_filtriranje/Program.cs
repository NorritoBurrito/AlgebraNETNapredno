using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iznimke_filtriranje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Unesite broj koji želite da bude podijeljen sa 130: ");
                try
                {
                    int broj = int.Parse(Console.ReadLine());
                    int rez = 130 / broj;
                    Console.WriteLine($"130 / {broj} = {rez}");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Nije moguće dijeliti s 0!");
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine("Neispravna operacija!");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Unos nije prepoznat!");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Uneseni broj je prevelik!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Došlo je do greške, pokušajte ponovno!");
                }
            }
        }
    }
}
