using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21_KlasaKontruktor_czwiczenie1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Zwierze pies = new Zwierze("reksio", 4, 2);
            Zwierze mucha = new Zwierze("bzyczucha", 2);

            pies.OpisKonsola();
            mucha.OpisKonsola();

            Console.ReadKey();
        }
    }
}
