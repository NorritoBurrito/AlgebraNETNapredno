using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Serijalizacija.Library
{
    public class MetodeZaSerijalizaciju
    {
        public void SerijalizirajNesto()
        {
            List<KlasaZaSerijalizaciju> kzs=new List<KlasaZaSerijalizaciju> ();
            kzs.Add(new KlasaZaSerijalizaciju()
            {
                Ime = "Nora",
                Prezime = "Mamula",
                Godine = 24,
            });
            kzs.Add(new KlasaZaSerijalizaciju()
            {
                Ime = "Nikola",
                Prezime = "Tesla",
                Godine = 78,
            });
            kzs.Add(new KlasaZaSerijalizaciju()
            {
                Ime = "Tin",
                Prezime = "Ujević",
                Godine = 102,
            });
            kzs.Add(new KlasaZaSerijalizaciju()
            {
                Ime = "Bruce",
                Prezime = "Lee",
                Godine = 42,
            });
            IFormatter format = new BinaryFormatter();
            Stream pohrani = new FileStream("primjer.dat", FileMode.Create, FileAccess.Write);
            format.Serialize(pohrani, kzs);
            pohrani.Close();
        }

        public void DeserijalizirajNesto()
        {
            List<KlasaZaSerijalizaciju> lista;

            IFormatter formatter = new BinaryFormatter();
            Stream procitaj=new FileStream("primjer.dat",FileMode.Open, FileAccess.Read);
            lista = (List<KlasaZaSerijalizaciju>)formatter.Deserialize(procitaj);
            procitaj.Close();

            foreach(var item in lista)
            {
                Console.WriteLine("Ime i prezime: "+item.Ime+" "+item.Prezime);
                Console.WriteLine("Godine: "+item.Godine);
                Console.WriteLine("Naziv tvrtke: "+KlasaZaSerijalizaciju.NazivTvrtke);
                Console.WriteLine();
            }
        }
    }
}
