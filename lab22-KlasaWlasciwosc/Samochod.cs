using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab22_KlasaWlasciwosc
{
    class Samochod
    {
        private string marka;
        private int rokProdukcji;
        public int aktualnaPredkosc;
        private int maxPredkosc;

        public string Marka { get => marka; set => marka = value; }
        public int RokProdukcji { get => rokProdukcji; set => rokProdukcji = value; }
        public int MaxPredkosc { get => maxPredkosc;
            set {
                if (value > 150)
                {
                    maxPredkosc = 150;

                }
                else maxPredkosc = value;
            }
                }

        public void PokaFure()
        {
            string nl = Environment.NewLine;
            Console.WriteLine($"Marka:{Marka}{nl}Rok produkcji:{RokProdukcji}{nl}Aktualna prędkość:{aktualnaPredkosc}{nl}Maksymalna prędkość:{MaxPredkosc}");


        }
        public void Przyszpiesz(int wartosc)
        {
            if ((aktualnaPredkosc + wartosc) <= MaxPredkosc)
            {
                aktualnaPredkosc += wartosc;
            }
            else aktualnaPredkosc = MaxPredkosc;
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
