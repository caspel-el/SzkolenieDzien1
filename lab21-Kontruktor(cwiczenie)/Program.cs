using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21_Kontruktor_cwiczenie_
{
    class Program
    {
        static void Main(string[] args)
        {

            Punkt[] pkt = new Punkt[10];
            for (int indeks = 0; indeks < pkt.Length; indeks++)
            {
                pkt[indeks] = new Punkt(indeks,indeks*3+6);
                Console.WriteLine(pkt[indeks].poleX + " " + pkt[indeks].poleY);



            }

            Console.ReadKey();
        }
    }
}
