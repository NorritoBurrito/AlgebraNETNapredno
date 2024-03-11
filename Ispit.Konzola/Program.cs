using Ispit.Konzola.Sucelja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola
{
    public class Program:PametniTelefon
    {
        public Program(string model) : base(model)
        {
        }

        static void Main(string[] args)
        {
            PametniTelefon telefon = new PametniTelefon("Neki model");
            TestirajTelefon(telefon);
        }

        static void TestirajTelefon(IPametniTelefon telefon)
        {
            Console.Write("Unesite telefonski broj: ");
            string telefonski_broj=Console.ReadLine();
            Console.Write("Unesite URL: ");
            string url = Console.ReadLine();

            string rezultatPoziva=telefon.Poziv(telefonski_broj);
            string rezultatSurfanja=telefon.Surfanje(url);

            Console.WriteLine(rezultatSurfanja);
            Console.WriteLine(rezultatPoziva);
        }
    }
}
