using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab22_Klasa_cwiczenie3_
{
    class Prostokat
    {
        
        int szerokosc;
        int wysokosc;
        Punkt lewyGorny;
        Punkt prawyGorny;
        Punkt lewyDolny;
        Punkt prawyDolny;

        public Prostokat(Punkt lewyGorny, int szerokosc, int wysokosc )
        {

            this.szerokosc = szerokosc;
            this.wysokosc = wysokosc;
            this.lewyGorny = lewyGorny;
            this.prawyGorny = new Punkt(lewyGorny.poleX + szerokosc, lewyGorny.poleY);
            this.lewyDolny = new Punkt(lewyGorny.poleX, lewyGorny.poleY - wysokosc);
            this.prawyDolny = new Punkt(lewyGorny.poleX + szerokosc, lewyGorny.poleY-wysokosc);
        }

        public void WyswietlWierzcholki()
        {
            Console.WriteLine($"lewyGorny:{lewyGorny.poleX},{lewyGorny.poleY}");
            Console.WriteLine($"prawyGorny:{prawyGorny.poleX},{prawyGorny.poleY}");
            Console.WriteLine($"lewyDolny:{lewyDolny.poleX},{lewyDolny.poleY}");
            Console.WriteLine($"prawyDolny:{prawyDolny.poleX},{prawyDolny.poleY}");
        }
        public void ObliczObwod()
        {
            Console.WriteLine($"Obwód=: {2*szerokosc + 2*wysokosc}");
        }
        public void ObliczPole()
        {
            
            
            Console.WriteLine($"Obwód=: {szerokosc + wysokosc}");
           
        }
    }
}
