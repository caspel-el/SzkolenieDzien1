using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21_KlasaKontruktor_czwiczenie1_
{
    class Zwierze
    {
        public string nazwa;
        public int iloscNog;
        public int iloscOczu;

        public Zwierze(string nazwa, int iloscOczu, int iloscNog)
        {
            this.nazwa = nazwa;
            this.iloscNog = iloscNog;
            this.iloscOczu = iloscOczu;

        }
        public Zwierze(string nazwa, int iloscOczu) : this(nazwa,iloscOczu, 4)
        {
            this.nazwa = nazwa;
            this.iloscOczu = iloscOczu;
        }



        string nl = Environment.NewLine;
        /// <summary>
        /// Metoda ktora zwroci parametry danego zwierzaka
        /// </summary>
        public void OpisKonsola()
        {
            Console.WriteLine($"Nazwa:{nazwa}{nl}Ilosc Nog:{iloscNog}{nl}IloscOczu:{iloscOczu}");
        }

        public string Opis()
        {
            return $"Nazwa:{nazwa}{nl}Ilosc Nog:{iloscNog}{nl}IloscOczu:{iloscOczu}";
        }
    }
}
