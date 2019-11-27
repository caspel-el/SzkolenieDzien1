using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatoryArytmetyczne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2+2="  +(2+2));
            Console.WriteLine("5-2=" +(5-2));
            Console.WriteLine("5*2=" +(5*2));
            Console.WriteLine("5/2=" +(5.0 / 2));
            Console.WriteLine("2^3=" +(Math.Pow(2,3)));
            Console.WriteLine("2%3=" + (2%3)); //reszta z dzielenia

            int a = 5;
            a = a + 1;
            Console.WriteLine(a);

            int b = 5;
            
            Console.WriteLine(b++);

            int c = 5;
            
            Console.WriteLine(++c);

            int d = 6;
            int e = 4;
            d += e; //to samo co d= d+e;
            Console.WriteLine(d);

            Console.Clear();

            //program przykładowy wyliczenie BMI
            //double waga, wzrost, BMI;
            //Console.WriteLine("Podaj wage:");
            //waga = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Podaj wzrost");
            //wzrost = Convert.ToDouble(Console.ReadLine());
            //BMI =  Math.Round(waga/Math.Pow(wzrost,2),2);
            //Console.WriteLine($"Twoje BMI to: {BMI}");


            ////Program liczacy pole kwadratu
            //double dlugoscBoku, poleKw;
            //Console.WriteLine("podaj długość boku:");
            //dlugoscBoku = Convert.ToDouble(Console.ReadLine());
            //poleKw = Math.Pow(dlugoscBoku, 2);
            //Console.WriteLine($"Pole kwadratu wynosi: {poleKw}");

            //program przykładowy- obliczanie sumy, roznicy, mnozenie, dzielenie

            decimal zmienna1, zmienna2, suma, roznica,iloczyn, iloraz;
            Console.WriteLine("Podaj liczbe 1");
            zmienna1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Podaj liczbe 2");
            zmienna2 = Convert.ToDecimal(Console.ReadLine());
            suma = zmienna1 + zmienna2;
            roznica = zmienna1 - zmienna2;
            iloczyn = zmienna1 * zmienna2;
            iloraz = zmienna1 / zmienna2;
            Console.WriteLine($"Suma:,Iloczyn,Iloraz: {suma} | Roznica {roznica} {iloczyn} {iloraz}");

            Console.ReadKey();
            
        }
    }
}
