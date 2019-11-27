using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab22_klasaWlasciwosci_cwiczenie_
{
    class Program
    {
        static void Main(string[] args)
        {
            Zwierze pajak = new Zwierze();
            pajak.IloscNog = 4;
            pajak.OpisKonsola();

            Console.ReadKey();

        }
    }
}
