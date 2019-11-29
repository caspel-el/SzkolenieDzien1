using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab29_KontruktorKopiujacy
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod1 = new Samochod("BMW", 5);
            Samochod samochod2 = samochod1;

            Console.WriteLine(samochod1.Marka + " " +samochod1.Drzwi);
            Console.WriteLine(samochod2.Marka + " " + samochod2.Drzwi);

            samochod2.Drzwi = 3;
            Console.WriteLine(samochod1.Marka + " " + samochod1.Drzwi);
            Console.WriteLine(samochod2.Marka + " " + samochod2.Drzwi);

            Samochod samochod3 = new Samochod(samochod1);

            Console.WriteLine(samochod1.Marka + " " + samochod1.Drzwi);
            Console.WriteLine(samochod2.Marka + " " + samochod2.Drzwi);
            Console.WriteLine(samochod3.Marka + " " + samochod3.Drzwi);

            samochod2.Drzwi = 33;

            Console.WriteLine(samochod1.Marka + " " + samochod1.Drzwi);
            Console.WriteLine(samochod2.Marka + " " + samochod2.Drzwi);
            Console.WriteLine(samochod3.Marka + " " + samochod3.Drzwi);

            Console.ReadKey();
        }
    }
}
