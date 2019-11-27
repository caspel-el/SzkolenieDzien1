using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab24_KlasaAbstrakcyjna_cwiczenie_
{
    class CarRobot:Robot
    {
        public override string Work()
        {
            return "Produkuje samochody";
        }
        public override void GiveName()
        {
            Console.WriteLine("Klasa CarRobot");
        }
    }
}
