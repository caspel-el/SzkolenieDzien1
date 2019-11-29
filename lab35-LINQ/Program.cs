//#define Filtr1
//#define Filtr2
//#define Sort
//# define Modify
//#define Multi
#define MultiAll
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab35_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Adam", "Piotr", "Jan", "Ksawery", "Michał", "Waldemar", "Tomasz", "Agnieszka", "Łucja", "Anna" };

#if (Filtr1)

            //IEnumerable<string> modifiedNames = System.Linq.Enumerable.Where(names, n => n.Length >= 6);
            IEnumerable<string> modifiedNames = names.Where(n => n.Length >= 6);
#elif (Filtr2)

            //IEnumerable<string> modifiedNames = names.Where(x => x.Contains("A"));
            IEnumerable<string> modifiedNames = from n in names
                                                where n.Contains("A")
                                                select n;

#elif (Sort)
            //IEnumerable<string> modifiedNames = names.OrderBy(n => n);
            IEnumerable<string> modifiedNames = names.OrderBy(n => n.Length);

#elif (Modify)
            IEnumerable<int> modifiedNames = names.Select(n => n.Length);

#elif (Multi)
            IEnumerable<string> filteredNames = names.Where(n => n.Contains("a"));
            IEnumerable<string> orderedNames = filteredNames.OrderBy(n => n);
            IEnumerable<string> modifiedNames = orderedNames.Select(n => n.ToUpper());

#elif (MultiAll)
            IEnumerable<string> modifiedNames = names
                .Where(n => n.Contains("a"))
                .OrderBy(n => n)
                .Select(n => n.ToUpper()); //najczesciej uzywane


#endif

            foreach (var item in modifiedNames)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
