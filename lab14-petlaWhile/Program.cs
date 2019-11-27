using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14_petlaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int licznik = 0;

            while (licznik <10)
            {
                Console.WriteLine(licznik);
                licznik++;
            }

            licznik = 0;

            do
            {
                Console.WriteLine(licznik);
                licznik++;
            } while (licznik<0);

            Console.ReadKey();
        }
    }
}
