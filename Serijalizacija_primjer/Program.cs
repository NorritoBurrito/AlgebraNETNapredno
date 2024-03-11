using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary; //da bi nam napravio binarni format kod spremanja

namespace Serijalizacija_primjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Polaznik p = new Polaznik();
            p.id = 1;
            p.Ime = "Nora";

            IFormatter form = new BinaryFormatter();
            Stream pohrani = new FileStream("primjer.txt",FileMode.Create, FileAccess.Write);

            form.Serialize(pohrani, p);
            pohrani.Close();

            Stream procitaj=new FileStream("primjer.txt",FileMode.Open, FileAccess.Read);
            Polaznik novi_polaznik= (Polaznik)form.Deserialize(procitaj);

            Console.WriteLine("Nakon deserijalizacije: ");
            Console.WriteLine("ID = "+novi_polaznik.id);
            Console.WriteLine("Ime = "+novi_polaznik.Ime);
        }
    }
}
