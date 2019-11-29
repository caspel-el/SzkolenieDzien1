using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab33_PlikOdczyt
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = $@"d:\test.txt";

            if (File.Exists(path))
            { 
                Console.WriteLine("Plik istnieje");
                string tekst = File.ReadAllText(path);
                Console.WriteLine(tekst);
                Console.WriteLine("=======================");

                string[] lines = File.ReadAllLines(path);
                foreach (var item in lines)
                {
                    Console.WriteLine(item);
                }
            }
            else Console.WriteLine("Plik nie istnieje");
                Console.ReadKey();
        }
    }
}
