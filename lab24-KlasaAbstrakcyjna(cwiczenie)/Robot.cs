using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab24_KlasaAbstrakcyjna_cwiczenie_
{
    public abstract class Robot
    {

        virtual public void GiveName()
        {
            Console.WriteLine($"Nazwa klasy: Robot");
        }
        public abstract string Work();
        
    }
}
