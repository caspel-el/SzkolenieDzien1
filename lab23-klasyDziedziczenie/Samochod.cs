using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab23_klasyDziedziczenie
{
    class Samochod : Pojazd
    {
        public Samochod(string marka, int rokProdukcji, int maxPredkosc)
        {
            this.Marka = marka;
            this.RokProdukcji = rokProdukcji;
            this.MaxPredkosc = maxPredkosc;


        }
    }
}
