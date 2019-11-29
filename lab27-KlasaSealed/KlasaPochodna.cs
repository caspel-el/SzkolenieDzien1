using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab27_KlasaSealed
{
    class KlasaPochodna : KlasaBazowa
    {
        public sealed override void Test() //poprzez dodanie sealed klasa bardziej pochodna juz nie moze odziedziczyc tej metody
        {
            base.Test();
            Console.WriteLine("Klasa pochodna - metoda test");
        }
    }
}
