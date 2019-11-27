using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab24_KlasaAbstrakcyjna_cwiczenie_
{
    class TrainRobot:Robot
    {

        public override string Work()
        {
            return "Produkuje pociagi";
        }
        public override void GiveName()
        {
            Console.WriteLine("Klasa TrainRobot");
        }
    }
}
