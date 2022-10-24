using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haftaucbeşincikısım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, kok1, kok2;
            Console.WriteLine("denklemin a degerini giriniz");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("denklemin b degerini giriniz");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("denklemin c degerini giriniz");
            c = double.Parse(Console.ReadLine());
            delta = Math.Pow(b, 2) - (4 * a + c);
            if (delta == 0)
            {
                kok1 = (-b) / 2 * a;
                Console.WriteLine("denklemin ckışık kökü vardır ve kok =" + kok1 + "dir");
            }
            else if (delta > 0)
            {
                kok1 = ((-b) + Math.Sqrt(delta) / (2 * a));
                kok2 = ((-b) - Math.Sqrt(delta) / (2 * a));
                Console.WriteLine("denkelmin iki kökü vardır kok1 =" + kok1 + " kok2= " + kok2);
            }
            else
            {
                Console.WriteLine("kök yoktur");
            }
            Console.ReadLine();
        }
    }
}
