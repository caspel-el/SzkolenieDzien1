using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZmienneTypyDanych
{
    class Program
    {
        static void Main(string[] args)
        {
            //typ zmiennej tekstowej/////
            string nazwaZmiennej;


            ///typy liczbowe - liczby calkowite////
            byte vByte = 255;
            Console.WriteLine($"zmienna {vByte}");
            Console.WriteLine($"byteMIN {Byte.MinValue.ToString()}, byteMax {Byte.MaxValue.ToString()}");
            sbyte vSByte = 7;
            Console.WriteLine($"zmienna {vSByte}");
            Console.WriteLine($"byteMIN {SByte.MinValue.ToString()}, byteMax {SByte.MaxValue.ToString()}");
            short vShort = 1024;
            Console.WriteLine($"zmienna {vShort}");
            Console.WriteLine($"byteMIN {Int16.MinValue.ToString()}, byteMax {Int16.MaxValue.ToString()}");
            ushort vUShort = 1024;
            Console.WriteLine($"zmienna {vUShort}");
            Console.WriteLine($"byteMIN {UInt16.MinValue.ToString()}, byteMax {UInt16.MaxValue.ToString()}");
            int vInt = 1024;
            Console.WriteLine($"zmienna {vInt}");
            Console.WriteLine($"byteMIN {Int32.MinValue.ToString()}, byteMax {Int32.MaxValue.ToString()}");
            uint vUInt = 1024;
            Console.WriteLine($"zmienna {vUInt}");
            Console.WriteLine($"byteMIN {UInt32.MinValue.ToString()}, byteMax {UInt32.MaxValue.ToString()}");
            long vLong = 1024;
            Console.WriteLine($"zmienna {vLong}");
            Console.WriteLine($"byteMIN {Int64.MinValue.ToString()}, byteMax {Int64.MaxValue.ToString()}");
            int vUlong = 1024;
            Console.WriteLine($"zmienna {vUlong}");
            Console.WriteLine($"byteMIN {UInt64.MinValue.ToString()}, byteMax {UInt64.MaxValue.ToString()}");

            ////Typy zmiennoprzecinkowe///
            float vfloat = 0.455f;
            Console.WriteLine($"zmienna {vfloat}");
            Console.WriteLine($"byteMIN {Single.MinValue.ToString()}, byteMax {Single.MaxValue.ToString()}");

            Console.WriteLine($"Wartosc po formatowaniu {vfloat.ToString("0.00")}");
            Console.WriteLine($"Wartosc po formatowaniu {vfloat.ToString("#.00")}");

            double vdouble = 0.455;
            Console.WriteLine($"zmienna {vdouble}");
            Console.WriteLine($"byteMIN {Double.MinValue.ToString()}, byteMax {Double.MaxValue.ToString()}");

            decimal vdecimal = 0.56m;
            Console.WriteLine($"zmienna {vdecimal}");
            Console.WriteLine($"byteMIN {Decimal.MinValue.ToString()}, byteMax {Decimal.MaxValue.ToString()}");

            bool vBool = true;
            Console.WriteLine($" bool: {vBool}");

            int? zmienna = null; // znak ? oznacza ze zmienna moze przyjac wartosc null

            ////typ znakowy/////
            char vchar = 'a';

            //łancuch znakow///
            string imie = "Jan";
            string nazwisko = "   Kowalski";
            string nazwisko2 = "Kowalski";
            Console.WriteLine($"duzymi znakami: {imie.ToUpper()} "); //na duze litery
            Console.WriteLine($"duzymi znakami: {nazwisko.ToLower()} "); //na male litery
            Console.WriteLine($"duzymi znakami: {imie} {nazwisko}");
            Console.WriteLine($"duzymi znakami: {imie.Trim()} {nazwisko.Trim()}"); //wycina spacje
            Console.WriteLine($"duzymi znakami: {nazwisko2.Substring(2,2)} "); //

            string sciezka1 = "c:\\windows\\Users\\Pawel";
            string sciezka2 = $@" c:\Windows\Users\Pawel";
            Console.WriteLine(sciezka1);
            Console.WriteLine(sciezka2);

            var vvar = 0;
            Console.WriteLine($"jakas zmienna {vvar.GetType()}");

            //typ dynamic///
            dynamic vdynamic = 0;
            Console.WriteLine($"jakas zmienna {vdynamic.GetType()}");
            vdynamic = "hello world";
            Console.WriteLine($"jakas zmienna {vdynamic.GetType()}");


            ////typ object//

            //object obiekt = 0;
            //Console.WriteLine(obiekt);
            //Console.WriteLine(obiekt.GetType());
            //obiekt = "hello world";
            //Console.WriteLine(obiekt);
            //Console.WriteLine(obiekt.GetType());

            ////dataTime
            //Console.WriteLine($"teraz {DateTime.Now}");
            //Console.WriteLine($"teraz {DateTime.Today}");
            //Console.WriteLine($"teraz {DateTime.Today.AddDays(-1)}");
            //Console.WriteLine($"teraz {DateTime.Today.AddDays(1)}");
            //Console.WriteLine($"teraz {DateTime.Today.DayOfYear}");
            //Console.WriteLine($"teraz {DateTime.UtcNow}");

            //DateTime date1 = DateTime.Now;
            //DateTime date2 = DateTime.UtcNow;
            //Console.WriteLine(date2 + " ==>" + date2.ToLocalTime());

            //Console.WriteLine($"data krotki format { date1.ToShortDateString()}");
            //Console.WriteLine($"data dlugi format { date1.ToLongDateString()}");
            //Console.WriteLine($"czas krotki format { date1.ToShortTimeString()}");
            //Console.WriteLine($"czas krotki format { date1.ToLongTimeString()}");
            //Console.WriteLine($"nasz wybrany format { date1.ToString("yyyy/MM/dd HH:mm:ss")}");
            //Console.WriteLine($"nasz wybrany format { date1.ToString("yyyy/MM/dd hh:mm:ss")}");

            //DateTime dateTime = new DateTime(2017,9,18);
            //dateTime.ToLongDateString();
            //Console.WriteLine(dateTime);

            //////typeof/////
            //Console.WriteLine(typeof(string));
            //Console.WriteLine(typeof(decimal));
            //Console.WriteLine(typeof(int));
            //Console.WriteLine(typeof(DateTime));

            ////program przykładowy
            //DateTime aktData = DateTime.Today;
            //Console.WriteLine($"Dzien roku: {aktData.DayOfYear}");
            //Console.WriteLine($"Czy rok przestepny: {DateTime.IsLeapYear(DateTime.Today.Year)}");

            ////program przykładowy

            //DateTime dataAkt = DateTime.Now;
            //DateTime jutro = DateTime.Today.AddDays(1);
            //Console.WriteLine(jutro.DayOfWeek);


            //program

            //string imieUser;
            //string nazwiskoUser;
            //Console.WriteLine("Podaj imie");
            //imieUser = Console.ReadLine();
            //Console.WriteLine("Podaj nazwisko");
            //nazwiskoUser = Console.ReadLine();
            //Console.WriteLine($"Twoje inicjały: {imieUser.Substring(0,1).ToUpper()} {nazwiskoUser.Substring(0, 1).ToUpper()}");


            //program
            int a, b, iloraz;
            a = 4;
            b = 0;
            iloraz = a / b;
            Console.WriteLine(iloraz);



            Console.ReadKey();

        }
    }
}
