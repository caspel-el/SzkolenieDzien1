using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab30_MetodyParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Dodaj(2,4,3,10));

            Console.ReadKey();
        }
        class Math
        {
            public static int Dodaj(params int[] parametry)
            {
                int suma = 0;
                for (int i = 0; i < parametry.Length; i++)
                {
                    suma += parametry[i];
                }
                return suma;
            }
        }
    }
}
