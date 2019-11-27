using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18_ObslugaBledow
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Wprowadz długosc boku kwadratu");
            //    int dlugoscBoku = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pole kwadratu:"  );
            //    Console.WriteLine(dlugoscBoku*dlugoscBoku);
            //    Console.WriteLine("Obwód kwadratu:");
            //    Console.WriteLine(4 * dlugoscBoku);

            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine($"Błędnie wprowadzona liczba {Environment.NewLine} {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("koniec programu");
            //}
            //try
            //{
            //    int firstNumber = 1;
            //    int socondNumber = 0;
            //    firstNumber = firstNumber / socondNumber;


            //}

            //catch (ArgumentException)
            //{

            //    Console.WriteLine("ArgumentException");
            //}
            //catch (DivideByZeroException)
            //{

            //    Console.WriteLine("Próba dzielenia przez 0");
            //}
            //catch (Exception) //nie moze byc na samej gorze bo jest rodzicem wszystkich exception
            //{

            //    Console.WriteLine("Exception");
            //}
            //finally
            //{
            //    Console.WriteLine("Blok finally");
            //}

            try
            {
                Console.WriteLine("Wprowadz długosc boku kwadratu");
                int dlugoscBoku = Convert.ToInt32(Console.ReadLine());
                if (dlugoscBoku < 0)
                    throw new ArgumentException("Długość boku kwadratu nie może byc wartoscia ujemna");
                Console.WriteLine("Pole kwadratu:");
                Console.WriteLine(dlugoscBoku * dlugoscBoku);
                Console.WriteLine("Obwód kwadratu:");
                Console.WriteLine(4 * dlugoscBoku);

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Błędnie wprowadzona wartość{Environment.NewLine} {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
