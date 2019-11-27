using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10_typEnum_cwiczenie_
{
    class Program
    {
        enum WielkoscKawy
        {
            mala,
            normalna,
            duza
        }
        static void Main(string[] args)
        {
            WielkoscKawy jakaKawa = WielkoscKawy.duza;
            switch (jakaKawa)
            {
                case WielkoscKawy.mala:
                    Console.WriteLine($"Cena kawy to: 3pln");
                    break;
                case WielkoscKawy.normalna:
                    Console.WriteLine($"Cena kawy to: 4pln");
                    break;
                case WielkoscKawy.duza:
                    Console.WriteLine($"Cena kawy to: 6pln");
                    break;
                default:
                    break;
            }
         
            Console.ReadKey();
            
        }
    }
}
