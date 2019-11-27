using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab19_Klasa_cwiczenie_
{
    class Program
    {
        static void Main(string[] args)
        {
            Zwierze pies = new Zwierze();
            Zwierze pajak = new Zwierze();
            Zwierze mucha = new Zwierze();

            pies.nazwa = "menchester terier";
            pies.iloscOczu = 2;
            pies.iloscNog = 4;

            pajak.nazwa = "krzyzak";
            pajak.iloscOczu = 4;
            pajak.iloscNog = 8;

            mucha.nazwa = "tstse";
            mucha.iloscOczu = 2;
            mucha.iloscNog = 4;

            Console.WriteLine($"Pies: {pies.nazwa} {pies.iloscOczu} {pies.iloscNog}");
            Console.WriteLine($"Pajak: {pajak.nazwa} {pajak.iloscOczu} {pajak.iloscNog}");
            Console.WriteLine($"Mucha: {mucha.nazwa} {mucha.iloscOczu} {mucha.iloscNog}");

            Console.ReadKey();
            
        }
    }
}
