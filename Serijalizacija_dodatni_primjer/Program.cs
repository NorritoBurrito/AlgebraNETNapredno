using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serijalizacija_dodatni_primjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KorisnickiDetalji kd=new KorisnickiDetalji(1, "Nikola", "Tesla", "Smiljani");
            Console.WriteLine("Prije serijalizacije objekt sadrži sljedeće podatke: ");
            kd.DohvatiDetalje();
            Console.WriteLine();

            string datoteka = @"D:\Downloads\serijalizacijaPrimjer.txt";
            if(File.Exists(datoteka) )
            {
                File.Delete(datoteka);
            }
            Stream pohrani = File.Open(datoteka, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(pohrani, kd);
            pohrani.Close();

            Console.WriteLine("Serijalizacija je uspješna!");

            Stream ucitaj = File.Open(datoteka, FileMode.Open);
            KorisnickiDetalji novi_detalji=(KorisnickiDetalji)bf.Deserialize(ucitaj);
            ucitaj.Close();

            Console.WriteLine();
            Console.WriteLine("Nakon deserijalizacije objekt sadrži: ");
            novi_detalji.DohvatiDetalje();

            //using (Stream st = File.Open(datoteka, FileMode.Open))
            //{
            //    KorisnickiDetalji novi_detalji2 = (KorisnickiDetalji)bf.Deserialize(ucitaj);
            //}
        }
    }
}
