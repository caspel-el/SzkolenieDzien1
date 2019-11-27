using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab22_Klasa_cwiczenie3_
{
    class Program
    {
        static void Main(string[] args)
        {

            Prostokat prostokat = new Prostokat(new Punkt(2, 5), 4, 3);

            prostokat.ObliczObwod();
            prostokat.ObliczPole();
            prostokat.WyswietlWierzcholki();

            Console.ReadKey();

        }
    }
}
