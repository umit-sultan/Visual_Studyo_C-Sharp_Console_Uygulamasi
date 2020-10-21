
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDöngüsüÖrnek4
{
    class Program
    {
        // Kullanıcı tarafından kaç sayı gireceği belirlenecek sonra girilen sayıların ortalaması alınacak? //
        static void Main(string[] args)
        {
            int sayac = 1;
            int adet = 0;
            int sayi = 0;
            int top = 0;
            int ort = 0;
            Console.Write("Kaç Adet Sayı Gireceksiniz?");
            adet = Convert.ToInt32(Console.ReadLine());
            while (sayac<=adet)
            {
                Console.Write("Sayı Giriniz?");
                sayi = Convert.ToInt32(Console.ReadLine());
                top = top + sayi;
                sayac++;
            }
            ort = top / adet;
            Console.Write("Sayıların Ortalaması:{0}", ort);
            Console.ReadKey();
        }
    }
}
