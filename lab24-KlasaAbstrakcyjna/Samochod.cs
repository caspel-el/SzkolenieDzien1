using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab24_KlasaAbstrakcyjna
{
    class Samochod : Pojazd
    {
        public Samochod(string marka, int rokProdukcji, int maxPredkosc)
        {
            this.Marka = marka;
            this.RokProdukcji = rokProdukcji;
            this.MaxPredkosc = maxPredkosc;


        }
        public void PokaFure()
        {
            string nl = Environment.NewLine;
            Console.WriteLine($"Marka:{Marka}{nl}Rok produkcji:{RokProdukcji}{nl}Aktualna prędkość:{AktualnaPredkosc}{nl}Maksymalna prędkość:{MaxPredkosc}");


        }
        public override void Przyspiesz(int wartosc)
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
        public override void Zwolnij(int wartosc)
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
        public override void Uruchom()
        {
            WlaczonySilnik = true;
        }
        public override void Zatrzymaj()
        {
            WlaczonySilnik = true;
        }
        public override void PokazPredkosc()
        {
            base.PokazPredkosc();
            if(AktualnaPredkosc==0)
            {
                Console.WriteLine("Stoisz w miejscu");
            }
            else if(AktualnaPredkosc>90)
            {
                Console.WriteLine("Jedziesz za szybko");
            }
        }
    }
}
