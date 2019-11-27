using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12_petle
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //programik
            //WypiszLiczbyNieparzyste();
            //WypiszLiczbyPierwsze();
            List<int> lista = new List<int>()
            {
                1,2,3,5,7
            };
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(i);
            }

            foreach (var item in "Rafal")
            {
                Console.WriteLine(item);

            }
            Console.ReadKey();
        }

        private static void WypiszLiczbyNieparzyste()
        {
            int liczba;
            Console.WriteLine("Podaj liczbe:");
            liczba = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < liczba; i++)
            {
                if (!(i % 2 == 0)) //nieparzyste // parzysste (i % 2 == 0)
                    Console.WriteLine(i);

            }
        }
        private static void WypiszLiczbyPierwsze()
        {
            int liczba;
            Console.WriteLine("Podaj liczbe:");
            liczba = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= liczba; i++)
            {
                if ((liczba % i  == 0)) //nieparzyste // parzysste (i % 2 == 0)
                {
                    if(i==liczba)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"To jest liczba pierwsza {liczba}");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"To nie jest liczba pierwsza {liczba}");
                    }
                }
               
                    

            }

        }

        
        


    }
}
