using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] tablica1;
            //tablica1 = new int[] { 1, 3, 6, 8 };
            //Console.WriteLine($"dlugosc tablicy: {tablica1.Length}");

            //Console.WriteLine($"Wartosc elementu spod indeksu nr 2: {tablica1[2]}");

            //foreach (var item in tablica1)
            //{
            //    Console.WriteLine(item);
            //}

            int[] tablica2 = new int[] { 1, 4, 6, 7, 8 };

            int[] tablica3 = new int[10];

            WypiszTablice(tablica3);

            Console.ReadKey();
        }

        private static void WypiszTablice(int[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
                Console.Write(" " + tablica[i]);
        }
    }
}
