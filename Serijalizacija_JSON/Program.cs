using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Serijalizacija_JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zaposlenik z = new Zaposlenik
            {
                ID = 1,
                Ime = "Nora",
                Prezime = "Mamula",
                DatumRodjenja = new DateTime(2000, 05, 29)
            };

            Console.WriteLine("Sadržaj objekta: ");
            Console.WriteLine(z.ToString());
            Console.WriteLine();
            string json=JsonSerializer.Serialize(z);
            Console.WriteLine(json);

            string datoteka = "serialization.txt";

            System.IO.File.WriteAllText(datoteka, json);

            string procitano_json=System.IO.File.ReadAllText(datoteka);
            Console.WriteLine("Pročitano iz datoteke: "+procitano_json);

            Zaposlenik novi_zaposlenik = JsonSerializer.Deserialize<Zaposlenik>(procitano_json);
            Console.WriteLine("Sadržaj deserijaliziranog objekta: ");
            Console.WriteLine(novi_zaposlenik.ToString());
        }
    }
}
