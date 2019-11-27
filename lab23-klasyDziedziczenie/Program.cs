using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab23_klasyDziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod("Polonez", 1995, 160);
            Console.WriteLine($"Marka:{samochod.Marka} rok produkcji: {samochod.RokProdukcji}");
            Console.ReadKey();
        }
    }
}
