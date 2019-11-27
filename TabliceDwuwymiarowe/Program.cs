using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabliceDwuwymiarowe
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine(random.Next(200));

            int[,] tablica = new int[10, 10];
            int liczba=0, maxLiczba=0;
            int pozycjaX = 0, pozycjaY = 0 ;
            for (int rowNumber = 0; rowNumber < tablica.GetLength(0); rowNumber++)
            {
                for (int columnNumber = 0; columnNumber < tablica.GetLength(0); columnNumber++)
                {
                    tablica[rowNumber, columnNumber] = random.Next(200);
                    
                }
            }
            for (int rowNumber = 0; rowNumber < tablica.GetLength(0); rowNumber++)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("------------------------------------------------------------");
                Console.Write("| ");

                for (int columnNumber = 0; columnNumber < tablica.GetLength(0); columnNumber++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(Convert.ToString(tablica[rowNumber,columnNumber]).PadRight(3));
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write(" | ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("-------------------------------------------------------------");

            for (int rowNumber = 0; rowNumber < tablica.GetLength(0); rowNumber++)
            {
                for (int columnNumber = 0; columnNumber < tablica.GetLength(0); columnNumber++)
                {
                    liczba = tablica[rowNumber, columnNumber];
                    if (liczba >maxLiczba)
                    {
                        maxLiczba = liczba;
                        pozycjaX = rowNumber;
                        pozycjaY = columnNumber;

                    }

                }
            }
            Console.WriteLine($"MaxLiczba to: {maxLiczba} na pozycji {Environment.NewLine} {pozycjaX} {pozycjaY}");
            Console.ReadKey();
        }
    }
}
