using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab28_Interfejsy_cwiczenie_
{
    class Program
    {
        static void Main(string[] args)
        {
            KontoTypA kontoA = new KontoTypA();
            KontoTypB kontoB = new KontoTypB();

            
            Console.WriteLine($"Konto A:{kontoA.Saldo}, Konto B:{kontoB.Saldo}");


            kontoA.Wplac(500);
            kontoB.Wplac(700);
            Console.WriteLine($"Konto A:{kontoA.Saldo}, Konto B:{kontoB.Saldo}");

            kontoB.ZrobPrzelew(kontoA, 200);
            Console.WriteLine($"Konto A:{kontoA.Saldo}, Konto B:{kontoB.Saldo}");

            Console.ReadKey();

            

        }
    }
}
