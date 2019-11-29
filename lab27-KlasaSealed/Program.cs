using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab27_KlasaSealed
{
    class Program
    {
        static void Main(string[] args)
        {

            KlasaPochodna klasaPoch = new KlasaPochodna();
            klasaPoch.Test();
            KlasaBardziejPochodna bardzPoch = new KlasaBardziejPochodna();
            bardzPoch.Test();
            Console.ReadKey();
        }
    }
}
