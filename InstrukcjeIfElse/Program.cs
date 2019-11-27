using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrukcjeIfElse
{
    class Program
    {
        static void Main(string[] args)
        {

            //if (1 == 2)
            //{
            //    Console.WriteLine("prawda");
            //}
            //else
            //{
            //    Console.WriteLine("falsz");
            //}
            //int a = 4;
            //int b = 3;

            //if (a > b)
            //{
            //    Console.WriteLine($"zmienna a[{a}] jest wiekasza od zmiennej b[{b}]");
            //}
            //else if(a<b)
            //{
            //    Console.WriteLine($"zmienna a[{a}] nie jest wiekasza od zmiennej b[{b}]");
            //}
            //else
            //{
            //    Console.WriteLine($"zmienna a[{a}] jest równa zmiennej b[{b}]");
            //}

            //int a = 5;
            //if (a>=1 && a<=10) //sprawdzenie czy a jest w zbiorze
            //{
            //    Console.WriteLine("a znajduje sie w zbiorze od 1 do 10");
            //}

            double waga, wzrost, BMI;
            Console.WriteLine("Podaj wage:");
            waga = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wzrost");
            wzrost = Convert.ToDouble(Console.ReadLine());
            BMI = Math.Round(waga / Math.Pow(wzrost, 2), 2);
            Console.WriteLine($"Twoje BMI to: {BMI}");
            string komunikat;
            //if (BMI<16)
            //{
            //    Console.WriteLine($"Oznacza stan: wygłodzenia");
            //}
            //else if (BMI>=16 && BMI<=16.99)
            //{
            //    Console.WriteLine($"Oznacza stan: wychudzenia");
            //}
            //else if (BMI >= 18.5 && BMI <= 24.99)
            //{
            //    Console.WriteLine($"Oznacza stan: wartość prawidłowa");
            //}
            //else if (BMI >= 25 && BMI <= 29.99)
            //{
            //    Console.WriteLine($"Oznacza stan: nadwaga");
            //}
            //else if (BMI >= 30 && BMI <= 34.99)
            //{
            //    Console.WriteLine($"Oznacza stan: I stopien otyłosci");
            //}
            //mozna inaczej
            if (BMI<16)
            {
                komunikat = "wygłodzenie";
            }

            /*mniej niż 16 - wygłodzenie
            16 - 16.99 - wychudzenie
            17 - 18.49 - niedowaga
            18.5 - 24.99 - wartość prawidłowa
            25 - 29.99 - nadwaga
            30 - 34.99 - I stopień otyłości
            35 - 39.99 - II stopień otyłości
            powyżej 40 - otyłość skrajna*/

            Console.ReadKey();
        }
    }
}
