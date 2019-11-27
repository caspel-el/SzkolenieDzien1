using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab22_klasaWlasciwosci_cwiczenie_
{
    class Zwierze
    {
        private string nazwa;
        private int iloscNog;
        private int iloscOczu;

        string nl = Environment.NewLine;

        public string Nazwa { get => nazwa; set => nazwa = value; }
        public int IloscNog { get => iloscNog; set => iloscNog = value; }
        public int IloscOczu { get => iloscOczu; set => iloscOczu = value; }

        /// <summary>
        /// Metoda ktora zwroci parametry danego zwierzaka
        /// </summary>
        public void OpisKonsola()
        {
            Console.WriteLine($"Nazwa:{Nazwa}{nl}Ilosc Nog:{IloscNog}{nl}IloscOczu:{IloscOczu}");
        }

        public string Opis()
        {
            return $"Nazwa:{Nazwa}{nl}Ilosc Nog:{IloscNog}{nl}IloscOczu:{IloscOczu}";
        }
    }
}
