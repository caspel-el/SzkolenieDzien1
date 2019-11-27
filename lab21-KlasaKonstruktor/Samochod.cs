using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21_KlasaKonstruktor
{

    class Samochod
    {
        public string marka;
        public int rokProdukcji;
        public int aktualnaPredkosc;
        public int maxPredkosc;

        public Samochod(string marka, int rokProdukcji, int maxPredkosc)
        {
            this.marka = marka;
            this.rokProdukcji = rokProdukcji;
            this.maxPredkosc = maxPredkosc;
            this.aktualnaPredkosc = 0;

        }

        public Samochod(string marka, int rokProdukcji) : this(marka, rokProdukcji, 200) //mozemy przekazac trzeci parametr
        {

        }
        public Samochod(string marka) //domyslny kontruktor musimy zdefiniowac kiedy chcemy tworzyc jeszacze obiekty bez podawania parametrow w kontruktore
        {
            this.marka = marka;
        }



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
