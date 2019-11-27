using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab20_KlasaMetodyCwiczenie
{
    class Zwierze
    {
        public string nazwa;
        public int iloscNog;
        public int iloscOczu;

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
