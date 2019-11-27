using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrukcjaSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch (6)
            //{
            //    case 1:
            //        Console.WriteLine("jeden");
            //        break;
            //    case 2:
            //        Console.WriteLine("dwa");
            //        break;
            //    case 5:
            //    case 6:
            //        Console.WriteLine("pięć lub szesc");
            //        break;
            //    default:
            //        Console.WriteLine("nie 1,2,3,4");
            //        break;
            //}

            //programik

            
            Console.WriteLine(DateTime.Now.DayOfWeek);
            switch (Convert.ToString(DateTime.Now.DayOfWeek))
            {
                case "Monday":
                    Console.WriteLine("jest poniedziałek");
                break;
                    //default;
            }

            Console.ReadKey();
        }
    }
}
