using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21_KlasaKonstruktor
{
    class Program
    {

        static void Main(string[] args)
        {
            Samochod samochod = new Samochod("BMW", 2000, 180);
            samochod.PokaFure();

            Samochod samochod2 = new Samochod("Audi", 1999);
            samochod2.PokaFure();

            Console.ReadKey();

            
        }
    }
}
