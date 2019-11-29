using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab36_SingleResult
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 20, 40, 30, 2, 45, 32, 10, 77, 22, 41 };
            int firstNumber = numbers.First();




            Console.WriteLine($"first number: {firstNumber}");
            int secondNumber = numbers.Skip(1).First();

            Console.WriteLine($"first number: {secondNumber}");


            Console.ReadKey();
        }
    }
}
