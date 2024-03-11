using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Net.Http;

namespace Serijalizacija_HNB
{
    public class Tecaj
    {
        public string Drzava { get; set; }
        public string Drzava_iso { get; set; }
        public string Valuta { get; set; }
        public string Kupovni_tecaj { get; set; }
        public string Srednji_tecaj { get; set; }
        public string Prodajni_tecaj { get; set; }
    }
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress=new Uri("https://api.hnb.hr")
            };

            List<Tecaj> tecaji;
            tecaji = await client.GetFromJsonAsync<List<Tecaj>>("/tecajn-eur/v3");

            foreach(var tecaj in tecaji)
            {
                Console.WriteLine($"{tecaj.Valuta} {tecaj.Kupovni_tecaj} {tecaj.Prodajni_tecaj}");
            }
        }
    }
}
