using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_Metody
{
    class Program
    {
        static void Main(string[] args)
        {
            string inicjaly = DajInicjaly("Paweł", "Banaszkiewicz");
            Console.WriteLine(inicjaly);
            Console.WriteLine(DajInicjaly("Paweł", "Banaszkiewicz"));

            Console.WriteLine(ObliczDlugoscWyrazu("absdfrfre"));
            WypiszLiczby(4, 5);
            WypiszLiczby(2, 6, 10);
            
            Console.ReadKey();
            
        }
        static string DajInicjaly(string imie, string nazwisko)
        {
            return imie[0] + "." + nazwisko[0] + ".";
        }
        static int ObliczDlugoscWyrazu(string jakisWyraz)
        {
            return jakisWyraz.Length;
        }
        static void WypiszLiczby(int liczba1, int liczba2)
        {
            Console.WriteLine($"Twoje liczby: {liczba1} , {liczba2}");
        }
        static void WypiszLiczby(int liczba1, int liczba2, int liczba3) //przeciazanie metod
        {
            Console.WriteLine($"Twoje liczby: {liczba1} , {liczba2}, {liczba3}");
        }
        static void WypiszLiczby(double liczba1, double liczba2, double liczba3) //przeciazanie metod typami
        {
            Console.WriteLine($"Twoje liczby: {liczba1} , {liczba2}, {liczba3}");
        }
        static void WypiszLiczby(double liczba1, int liczba2, int liczba3) //przeciazanie metod
        {
            Console.WriteLine($"Twoje liczby: {liczba1} , {liczba2}, {liczba3}");
        }

    }
}
