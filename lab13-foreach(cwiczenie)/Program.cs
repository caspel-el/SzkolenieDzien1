using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13_foreach_cwiczenie_
{
    class Program
    {
        static void Main(string[] args)
        {
            string teksUzytkownika;
            int liczbaLiter=0, liczbaCyfr=0, liczbaSpacji=0, iloscZnakow=0;

            Console.WriteLine("Podaj przykładowy tekst:");
            teksUzytkownika = Console.ReadLine();

            foreach (var znak in teksUzytkownika)
            {
               if( Char.IsLetter(znak))
                {
                    liczbaLiter++;

                }

                if (Char.IsNumber(znak))
                {
                    liczbaCyfr++;
                }
                if (Char.IsWhiteSpace(znak))
                {
                    liczbaSpacji++;
                }
            }
            Console.WriteLine($"ilosc znakow: {iloscZnakow} cyfr {liczbaCyfr} spacji {liczbaSpacji}");

            Console.ReadKey();
        }
        static void SprawdzFraze(string tekst)
        {
            
        }
    }
}
