using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab23_klasyDziedziczenie
{
    class Pojazd
    {
        private string marka;
        private int rokProdukcji;
        private int aktualnaPredkosc;
        private int maxPredkosc;

        public string Marka { get => marka; set => marka = value; }
        public int RokProdukcji { get => rokProdukcji; set => rokProdukcji = value; }
        public int MaxPredkosc
        {
            get => maxPredkosc;
            set
            {
                if (value > 150)
                {
                    maxPredkosc = 150;

                }
                else maxPredkosc = value;
            }
        }

    }
}
