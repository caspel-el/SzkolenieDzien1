using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab15_listaStringow
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaStr = new List<string>();
            listaStr.Add("Adam");
            listaStr.Add("Piotr");
            listaStr.Add("Paweł");
            listaStr.Add("Tomek");
            listaStr.Add("Adam");
            listaStr.Add("Krzysztof");
            listaStr.Add("Jacek");

            Console.WriteLine($"lista ma: {listaStr.Count} elementow");

            foreach (var item in listaStr)
            {
                Console.WriteLine(item);
            }

            listaStr.RemoveAt(2);
            Console.WriteLine($"lista ma: {listaStr.Count} elementow");

            string zmienna = listaStr[0];
            Console.WriteLine($"zmienna: {zmienna} ");
            Console.WriteLine($"lista ma: {listaStr.Count} elementow");
            listaStr.Remove(zmienna);

            Console.WriteLine($"lista ma: {listaStr.Count} elementow");
            foreach (var item in listaStr)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
