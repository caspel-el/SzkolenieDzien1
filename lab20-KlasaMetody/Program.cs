using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab20_KlasaMetody
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod autko = new Samochod();
            autko.marka = "BMW";
            autko.rokProdukcji = 2000;
            autko.aktualnaPredkosc = 0;
            autko.maxPredkosc = 170;

            autko.Przyszpiesz(50);

            autko.PokaFure();
            autko.Zwolnij(30);


            Console.ReadKey();
        }
    }
}
