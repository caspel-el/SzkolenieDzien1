using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17_ParametryMetod
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Kubus"; //
            Console.WriteLine(firstName);
            Upper(firstName); //tutaj pracujemy na kopii
            Console.WriteLine(firstName);

            string lastName = "Puchatek";
            Console.WriteLine(lastName);
            Lower(ref lastName); //tutaj pracujemy na oryginale 
            Console.WriteLine(lastName);

            int lengthA = 555;
            GetWordLength(lastName, out lengthA);
            Console.WriteLine(lengthA);

            GetWordLength(lastName, out int lengthB);
            Console.WriteLine(lengthB);

            Console.ReadKey();
        }
        static void Upper(string word)
        {
            word = word.ToUpper();
            Console.WriteLine(word);
        }

        static void Lower (ref string word)
        {
            word = word.ToLower();
            Console.WriteLine(word);
        }
        static void GetWordLength(string word, out int length)
        {
            length = word.Length;
        }

    }
}
