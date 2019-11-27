using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab20_KlasaMetodyCwiczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Zwierze pies = new Zwierze();
            pies.nazwa = "menchester terier";
            pies.iloscOczu = 2;
            pies.iloscNog = 4;

            Zwierze pajak = new Zwierze();
            pajak.nazwa = "krzyzak";
            pajak.iloscOczu = 4;
            pajak.iloscNog = 8;

            Zwierze mucha = new Zwierze();
            mucha.nazwa = "tstse";
            mucha.iloscOczu = 2;
            mucha.iloscNog = 4;

            pies.OpisKonsola();
            Console.WriteLine(mucha.Opis());

            Console.ReadKey();
        }
    }
}
