using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab28_Interfejsy_cwiczenie_
{
    interface IKontoBankowe
    {
        decimal Saldo { get; }

        void Wplac(decimal wartosc);
        bool Wyplac(decimal wartosc);
        bool ZrobPrzelew(IKontoBankowe kontoBankowe, decimal wartosc);


    }
}
