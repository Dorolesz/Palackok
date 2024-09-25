using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palackok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Palack p1 = new Palack("baracklé", 500, 300);
            Palack p2 = new Palack("almalé", 500, 200);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

            p1.HozzaOnt(p2);
            Console.WriteLine("Hozzáöntes után: " + p1.ToString());

            VisszavalthatoPalack vp1 = new VisszavalthatoPalack("kóla", 1000, 800, 50);
            Console.WriteLine(vp1.ToString());

            Rekesz rekesz = new Rekesz(2000);
            rekesz.UjPalack(p1);
            rekesz.UjPalack(vp1);

            Console.WriteLine("Rekesz súlya: " + rekesz.Suly());
            Console.WriteLine("Visszaváltási osszeg: " + rekesz.OsszesPenz() + " Ft");

            Console.ReadKey();
        }
    }
}
