using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Dogadaji_jednostavni
{
    public delegate void DelegatEventHandler();
    internal class Program
    {
        public static event DelegatEventHandler Dodaj;
        static void Main(string[] args)
        {
            Dodaj += new DelegatEventHandler(Njemacka);
            Dodaj += new DelegatEventHandler(Austrija);
            Dodaj += new DelegatEventHandler(Engleska);
            Dodaj.Invoke();
        }

        static void Njemacka()
        {
            Console.WriteLine("Deustchland");
        }

        static void Austrija()
        {
            Console.WriteLine("Ostereich");
        }

        static void Engleska()
        {
            Console.WriteLine("England");
        }
    }
}
