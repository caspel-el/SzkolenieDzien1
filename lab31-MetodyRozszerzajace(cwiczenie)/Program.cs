using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab31_MetodyRozszerzajace_cwiczenie_
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataUrodzin = new DateTime(1983,02,26);

            Console.WriteLine(dataUrodzin.IloscDniNaZiemi());

            Console.ReadKey();

        }
    }
}
