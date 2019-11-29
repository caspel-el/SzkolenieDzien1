//#define Take
//#define Skip
#define Reverse

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab36_LinqNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 20, 40, 30, 2, 45, 32, 10, 77, 22, 41 };

#if (Take)
            IEnumerable<int> modifiedNumbers = numbers.Take(3);

#elif (Skip)
            IEnumerable<int> modifiedNumbers = numbers.Skip(5);

#elif (Reverse)

            IEnumerable<int> modifiedNumbers = numbers.Reverse();
#endif

            foreach (var number in modifiedNumbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
