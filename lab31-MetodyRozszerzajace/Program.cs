using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab31_MetodyRozszerzajace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz tekst:");
            string jakisTekst = Console.ReadLine();
            Console.WriteLine(jakisTekst.ZliczSlowa());


            Console.ReadKey();
        }
    }
}
