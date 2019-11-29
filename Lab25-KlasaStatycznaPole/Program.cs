using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab25_KlasaStatycznaPole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gracz.NextId);
            Console.WriteLine(Gracz.NextId);

            

            Gracz[] gracze = new Gracz[3];
            gracze[0] = new Gracz();
            Console.WriteLine(gracze[0].Id+ " " +gracze[0].Nick);
            gracze[0] = new Gracz("player1");
            gracze[1] = new Gracz("player2");
            gracze[2] = new Gracz("player3");

            foreach (var gracz in gracze)
            {
                Console.WriteLine(gracz.Id + " " + gracz.Nick);

            }
            Console.ReadKey();
        }
    }
}
