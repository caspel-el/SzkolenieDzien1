using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypWyliczeniowy
{
    class Program
    {
        enum State1
        {
            off,
            On,
            Unknown

        }
        enum State2
        {
            off,
            On=10,
            Unknown

        }
        static void Main(string[] args)
        {
            State1 state1 = State1.Unknown;
            Console.WriteLine($"Stan - {state1},{Convert.ToInt32(state1)}");

            State2 state2 = State2.Unknown;
            Console.WriteLine($"Stan - {state1},{Convert.ToInt32(state2)}");
            Console.ReadKey();
        }
    }
}
