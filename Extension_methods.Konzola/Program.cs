using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extension_methods.library; //prvo moramo dodati u reference i onda ju moramo tu napisati kako bi ju mogli koristiti unutar programa

namespace Extension_methods.Konzola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObicnaKlasa ok=new ObicnaKlasa();
            Console.WriteLine(ok.Ispis());
            Console.WriteLine(ok.Printanje());
            ok.DodatnaMetodaEkstenzije();
        }
    }
}
