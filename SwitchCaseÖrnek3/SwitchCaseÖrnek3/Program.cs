using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseÖrnek3
{
    class Program
    {
       // 5 Adet Sayının Hesaplanıp Ekrana Yazdıran Program? //
        static void Main(string[] args)
        {
            int sayac = 1;
            int sayi = 0;
            int top = 0;
            while (sayac <= 5)
            {
                Console.Write("{0}.Sayıyı Giriniz?", sayac);
                sayi = Convert.ToInt32(Console.ReadLine());
                top = top + sayi;
                sayac++;
            }
            Console.Write("Sayıların Toplamı:{0}", top);
            Console.ReadKey();
        }
    }
}
