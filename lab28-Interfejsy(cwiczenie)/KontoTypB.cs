using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab28_Interfejsy_cwiczenie_
{
    class KontoTypB : IKontoBankowe
    {
        

        public decimal Saldo { get; private set; }

        public void Wplac(decimal wartosc)
        {
            Saldo += wartosc;

        }

        public bool Wyplac(decimal wartosc)
        {
            if (Saldo >= wartosc)
            {
                Saldo -= wartosc;
                return true;
            }
            Console.WriteLine("Za mało środków na koncie");
            return false;
        }

        public bool ZrobPrzelew(IKontoBankowe kontoBankowe, decimal wartosc)
        {
            bool wyplacono = this.Wyplac(wartosc);
            if (wyplacono)
            {
                kontoBankowe.Wplac(wartosc);
            }
            return wyplacono;
        }
    }
}
