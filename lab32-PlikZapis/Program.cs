using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab32_PlikZapis
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = $@"d:\test.txt";

            if (File.Exists(path))
                Console.WriteLine("Plik istnieje");

            string tekst = "to jest tekst pochodzacy z naszego programu";

            //File.WriteAllText(path, tekst);
            //File.AppendAllText(path, tekst);
            //tekst = Environment.NewLine +tekst;
            //File.AppendAllText(path, tekst);

            List<string> lista = new List<string>
            {
                "linia pierwsza",
                "linia druga",
                "linia trzecia"
            };

            File.WriteAllLines(path, lista);
            File.AppendAllLines(path, lista);

            Console.ReadKey();
            
        }
    }
}
