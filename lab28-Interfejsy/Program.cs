using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab28_Interfejsy
{
    class Program
    {
        static void Main(string[] args)
        {
            Pojazd pojazd = new Pojazd(); //IPojazd pojazd = new Pojazd();
            pojazd.Marka = "bmw";
            pojazd.AktualnaPredkosc = 20;
            pojazd.MaxPredkosc = 200;
            pojazd.Uruchom();

            Console.WriteLine(pojazd.Marka + " " +pojazd.AktualnaPredkosc);

            pojazd.Przyspiesz(55);
            Console.WriteLine(pojazd.Marka + " " + pojazd.AktualnaPredkosc);

            Console.ReadKey();

        }
    }
}
