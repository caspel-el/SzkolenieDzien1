using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab20_KlasaMetody
{
    class Samochod
    {
        public string marka;
        public int rokProdukcji;
        public int aktualnaPredkosc;
        public int maxPredkosc;


        public void PokaFure()
        {
            string nl = Environment.NewLine;
            Console.WriteLine($"Marka:{marka}{nl}Rok produkcji:{rokProdukcji}{nl}Aktualna prędkość:{aktualnaPredkosc}{nl}Maksymalna prędkość:{maxPredkosc}");


        }
        public void Przyszpiesz(int wartosc)
        {
            if ((aktualnaPredkosc + wartosc) <= maxPredkosc)
            {
                aktualnaPredkosc += wartosc;
            }
            else aktualnaPredkosc = maxPredkosc;
        }
        public void Zwolnij(int wartosc)
        {
            if ((aktualnaPredkosc - wartosc) < 0)
            {
                aktualnaPredkosc += wartosc;
            }
            else aktualnaPredkosc = 0;
        }
    }
}
