using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab19_cwiczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal liczba1 = 0, liczba2 = 0;
            try
            {
                Console.WriteLine("Podaj dzielna:");
                liczba1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Podaj dzielnik:");
                liczba2 = Convert.ToDecimal(Console.ReadLine());
                //if (liczba2 == 0)
                    //throw new ArgumentException("Dzielnik nie może być wartościa zerową");
                Console.WriteLine(Dzielenie(liczba1, liczba2));
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Błędnie wprowadzona wartość{Environment.NewLine} {ex.Message}");
            }
            Console.ReadKey();
        }
        static decimal Dzielenie(decimal dzielna, decimal dzielnik)
        {
            if (dzielnik == 0)
                throw new DivideByZeroException("Dzielnik nie może być wartościa zerową");
            return dzielna /dzielnik; 
        }

        
    }
}
