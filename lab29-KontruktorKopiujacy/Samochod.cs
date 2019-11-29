using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab29_KontruktorKopiujacy
{
    class Samochod
    {
        public string Marka { get; set; }
        public byte Drzwi { get; set; }

        public Samochod(string marka, byte drzwi)
        {
            Console.WriteLine("Kontruktor bazowy");
            this.Marka = marka;
            this.Drzwi = drzwi;
        }
        public Samochod(Samochod samochod)
        {
            Console.WriteLine("Konstruktor kopiujacy");
            this.Marka = samochod.Marka;
            this.Drzwi = samochod.Drzwi;

        }

    }
}
