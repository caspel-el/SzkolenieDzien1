using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab28_Interfejsy
{
    interface IPojazd
    {
        string Marka { get; set; }
        int RokProdukcji { get; set; }
        int AktualnaPredkosc { get; set; }
        int MaxPredkosc { get; set; }
        bool WlaczonySilnik { get; set; }



        void Uruchom();
        void Zatrzymaj();
        void Przyspiesz(int wartosc);
        void Zwolnij(int wartosc);
    }
}
