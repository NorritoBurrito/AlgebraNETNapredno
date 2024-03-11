using Sucelja_za_ferrari.Automobili;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja_za_ferrari
{
    internal class Program
    {
        private const string Model = "F40";
        static void Main(string[] args)
        {
            Console.Write("Unesite vozača: ");
            string vozac=Console.ReadLine();
            var auto=new Ferrari(vozac, Model);
            Console.WriteLine(auto);

            string fnk=typeof(Ferrari).Name;
            string AutomobilIN = typeof(Automobil).Name;
            Console.WriteLine("Ime klase je "+fnk);
            Console.WriteLine("Ime sučelja je "+AutomobilIN);

            object o = auto;
            Console.WriteLine("Klasa objekta o je "+o.GetType().Name);

            switch(o.GetType().Name)
            {
                case "Ferrari":
                    Console.WriteLine("ferrari klasa");
                    break;
            }

            bool jeKreiran=typeof(Automobil).IsInterface;
            if (!jeKreiran)
            {
                throw new Exception("Nije stvoreno sučelje za automobil!");
            }
            Automobil iautomobil = auto;
            Console.WriteLine(iautomobil.Gorivo());
            Console.WriteLine(iautomobil.ToString());

        }
    }
}
