using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int sonuc = Faktoriyel(sayi);
            Console.WriteLine("Sonuç : " + sonuc);
            Console.ReadKey();
        }

        static int Faktoriyel(int a)
        {
            if(a == 0)
            {
                return 1;
            }
            else if (a == 1)
            {
                return 1;
            }
            else
            {
                return a * Faktoriyel(a - 1);
            }
        }
    }
}
