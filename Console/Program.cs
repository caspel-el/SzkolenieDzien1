using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("hello");
            //string firstName = "Jan";
            //string lastName = "Kowalski";
            //System.Console.WriteLine(firstName+ " " +lastName);
            //System.Console.WriteLine("Hello {0} {1}", firstName, lastName);
            //System.Console.WriteLine($"Hello {firstName} {lastName}");

            //Console.WriteLine("Podaj swoje imie");
            //string yourName = Console.ReadLine();
            //Console.WriteLine($"Hello {yourName);


            //Console.WriteLine("Podaj swoje imie");
            //string yourName = Console.ReadLine();
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine($"Hello {yourName}");
            //Console.ResetColor();
            //Console.WriteLine("hello");


            string komunikat = "To moja aplikacja";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Beep();
            Console.WriteLine(komunikat);


            System.Console.ReadKey();
        }
    }
}
