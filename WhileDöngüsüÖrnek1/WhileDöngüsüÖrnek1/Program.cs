using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDöngüsüÖrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            Console.Write("1.Sayıyı Giriniz?");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayıyı Giriniz?");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            while (sayi1<=sayi2)
            {
                Console.WriteLine(sayi1);
                sayi1++;
            }
            Console.ReadKey();
        }
    }
}
