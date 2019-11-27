using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06_instrukcjeIF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            int pierwsza, druga, trzecia;
            int najmnejsza;
            Console.WriteLine( "Podaj pierwsza liczbe" );
            pierwsza = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe");
            druga = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj trzecia liczbe");
            trzecia = Convert.ToInt32(Console.ReadLine());
            if (pierwsza<druga && pierwsza<trzecia)
            {
                najmnejsza = pierwsza;
                Console.WriteLine(najmnejsza);
            }
            else
            {
                if (druga<pierwsza && druga<trzecia)
                {
                    najmnejsza = druga;
                    Console.WriteLine(najmnejsza);
                }
                else
                {
                    if(trzecia<druga && trzecia<pierwsza)
                    {
                        najmnejsza = trzecia;
                        Console.WriteLine(najmnejsza);
                    }
                    else
                    {
                        Console.WriteLine("nie znaleziono");
                    }
                }
            }
            
            
            Console.ReadKey();
        }
    }
}
