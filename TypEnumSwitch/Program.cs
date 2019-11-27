using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypEnumSwitch
{
    class Program
    {
        enum State
        {
            off,
            On,
            Unknown

        }
        static void Main(string[] args)
        {
            State state= State.On;

            switch (state)
            {
                case State.off:
                    Console.WriteLine("wyłączony");
                    break;
                case State.On:
                    Console.WriteLine("Włączony");
                    break;
                case State.Unknown:
                    Console.WriteLine("nieznany");
                    break;
                default:
                    break;
            }
            Console.ReadKey();

        }
    }
}
