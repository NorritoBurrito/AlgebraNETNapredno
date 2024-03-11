using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_izrazi_i_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] brojevi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 13, 17 };
            foreach (int b in brojevi) Console.WriteLine($"{b} ");

            Console.WriteLine();
            Console.WriteLine();

            int[] parni = brojevi.Where(x => x % 2 == 0).ToArray();
            Console.WriteLine("Parni brojevi iz polja: ");
            foreach(int p in parni) Console.WriteLine($"{p} ");

            Console.WriteLine();
            Console.WriteLine();

            int[] neparni = brojevi.Where(x => x % 2 != 0).ToArray();
            Console.WriteLine("Neparni brojevi iz polja: ");
            foreach (int n in neparni) Console.WriteLine($"{n} ");

            Console.WriteLine();
            Console.WriteLine();

            List<string> osobe = new List<string>()
            {
                "Marko", "Ivana", "Ana", "Jure", "Anastasija", "Svetlana", "Nikola", "Mateo", "Nora", "Karlo", "Filip"
            };

            List<string> ime_pocinje_s_a = osobe.Where(o => o.StartsWith("A")).ToList();
            foreach(string o in ime_pocinje_s_a) Console.Write(o+" ");
        }
    }
}
