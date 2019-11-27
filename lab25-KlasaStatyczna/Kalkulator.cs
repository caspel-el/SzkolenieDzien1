using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab25_KlasaStatyczna
{
    class Kalkulator
    {
        public static decimal Dodaj(decimal a, decimal b)
        {
            return a + b;
        }
        public static decimal Odejmij(decimal a, decimal b)
        {
            return a - b;
        }
        public static decimal Pomnoz(decimal a, decimal b)
        {
            return a * b;
        }
        public static decimal Podziel(decimal a, decimal b)
        {
            return a / b;
        }
    }
}
