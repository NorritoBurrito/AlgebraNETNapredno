using Ispit.Konzola.Sucelja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola
{
    public class PametniTelefon : IPametniTelefon, ITelefon
    {
        public string Model { get; private set; }
        public PametniTelefon(string model)
        {
            Model = model;
        }

        public string Surfanje(string url)
        {
            if (ProvjeriAkoJeValidanUrl(url))
            {
                return "Moguće je surfati na URL: "+url;
            }
            else
            {
                return "Neispravan URL";
            }
        }

        public bool ProvjeriAkoJeValidanUrl(string url)
        {
            foreach (char znak in url)
            {
                if (!Char.IsDigit(znak))
                {
                    return false;
                }
            }
            return true;
        }

        public string Poziv(string telefonski_broj)
        {
            if (ProvjeriAkoJeValidanBroj(telefonski_broj))
            {
                return "Moguće je zvati broj: "+telefonski_broj;
            }
            else
            {
                return "Neispravan telefonski broj!";
            }
        }

        public bool ProvjeriAkoJeValidanBroj(string telefonski_broj)
        {
            foreach (char broj in telefonski_broj)
            {
                if (!Char.IsDigit(broj))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
