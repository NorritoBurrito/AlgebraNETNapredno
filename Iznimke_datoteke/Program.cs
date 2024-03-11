using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iznimke_datoteke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dat = "primjer.txt"; //kreirati će prazan tekst folder,
                                        //ako stavimo neki drugi disk i da se na njemu save-a će prijaviti exception ako ne postoji taj disk i da se nema gdje spremiti
            try
            {
                if (File.Exists(dat))
                {
                    File.Delete(dat);
                }
                Console.WriteLine("Stvaranje datoteke na disku ako postoji: ");
                using (FileStream fs = File.Create(dat))
                {
                    Console.WriteLine("Datoteka stvorena s imenom "+dat);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Greška: "+e.Message);
            }
        }
    }
}
