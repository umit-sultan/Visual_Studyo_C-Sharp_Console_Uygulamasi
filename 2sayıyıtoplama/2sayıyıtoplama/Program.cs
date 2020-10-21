using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sayıyıtoplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, top;
            Console.Write("1. Sayıyı Giriniz?");
            sayi1 = Convert.ToInt32 (Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz?");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            top = sayi1 + sayi2;
            Console.Write("Sayıların Toplamı:{0}", top);
            Console.ReadKey();
        }
    }
}
