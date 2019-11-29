using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab28_Interfejsy
{
    class Pojazd : IPojazd
    {
        private string marka;
        private int rokProdukcji;
        private int aktualnaPredkosc;
        private int maxPredkosc;

        private bool wlaczonySilnik;

        public string Marka { get => marka; set => marka = value; }
        public int RokProdukcji { get => rokProdukcji; set => rokProdukcji = value; }
        public int AktualnaPredkosc { get => aktualnaPredkosc; set => aktualnaPredkosc = value; }
        public int MaxPredkosc { get => maxPredkosc; set => maxPredkosc = value; }
        public bool WlaczonySilnik { get => wlaczonySilnik; set => wlaczonySilnik = value; }


        public void Przyspiesz(int wartosc)
        {
            if (WlaczonySilnik)
            {

                if ((AktualnaPredkosc + wartosc) <= MaxPredkosc)
                {
                    AktualnaPredkosc += wartosc;
                }
                else AktualnaPredkosc = MaxPredkosc;
            }
            else Console.WriteLine("Najpier uruchom silnik");
        }

        public void Uruchom()
        {
            WlaczonySilnik = true;
        }

        public void Zatrzymaj()
        {
            WlaczonySilnik = true;
        }

        public void Zwolnij(int wartosc)
        {
            if (WlaczonySilnik)
            {
                if ((AktualnaPredkosc - wartosc) < 0)
                {
                    AktualnaPredkosc += wartosc;
                }
                else AktualnaPredkosc = 0;
            }
            else Console.WriteLine("Najpier uruchom silnik");
        }
    }
}
