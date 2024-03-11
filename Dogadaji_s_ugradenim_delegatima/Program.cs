using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadaji_s_ugradenim_delegatima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tvornica t=new Tvornica();
            t.ProizvodGotov += IdeUProdaju;

            t.PocniProizvodnju();
        }
        public static void IdeUProdaju(object sender, EventArgs e)
        {
            Console.WriteLine("Pakiranje proizvoda...");
            Console.WriteLine("Utovar u transport...");
            Console.WriteLine("Dostava u trgovinu...");
            Console.WriteLine("Traženje krajnjeg kupca...");
        }
    }

    class Tvornica
    {
        public event EventHandler ProizvodGotov;

        public void PocniProizvodnju()
        {
            Console.WriteLine("Materijal je primljen...");
            Console.WriteLine("Obrada...");
            //dalje što treba raditi...
            ProizvodGotov?.Invoke(this, EventArgs.Empty);
        }
    }
}
