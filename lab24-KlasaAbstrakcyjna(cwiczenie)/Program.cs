using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab24_KlasaAbstrakcyjna_cwiczenie_
{
    class Program
    {
        static void Main(string[] args)
        {
            CarRobot cr = new CarRobot();
            Console.WriteLine(cr.Work());
            cr.GiveName();

            Console.ReadKey();

        }
    }
}
