using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab22_KlasaWlasciwosc
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod autko = new Samochod();
            autko.Marka = "BMW";
            autko.RokProdukcji = 2000;
            autko.aktualnaPredkosc = 0;
            autko.MaxPredkosc = 200;



            autko.Przyszpiesz(50);

            autko.PokaFure();
            autko.Zwolnij(30);

            Console.ReadKey();
        }
    }
}
