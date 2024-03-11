using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iznimke_logiranje_svake_iznimke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Unesite cijeli broj: ");
                    int cijeli_broj = int.Parse(Console.ReadLine());

                    if (cijeli_broj == 0) break;
                    Console.WriteLine($"Unijeli ste {cijeli_broj}. Unesite 0 za kraj.");
                }
                catch (Exception e) when (GreskaSeDogodila(e.Message))
                {

                }
                catch (ArgumentNullException ex) 
                {
                    Logiraj(ex.Message);
                    Console.WriteLine("Greška argumenta");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Greška formata");
                }
                catch (OverflowException ex)
                {

                }
                catch (IOException ex)
                {

                }
                catch(Exception ex)
                {

                }
            }
        }
        private static bool GreskaSeDogodila(string s)
        {
            Logiraj(s);
            return false;
        }

        private static void Logiraj(string s)
        {
            Console.WriteLine(DateTime.Now.ToString()+ " Uhvaćena greška:");
            Console.WriteLine(s);
        }
    }
}
