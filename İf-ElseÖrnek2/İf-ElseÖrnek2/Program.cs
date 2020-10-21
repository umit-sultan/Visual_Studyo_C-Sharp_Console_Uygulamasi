using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İf_ElseÖrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, sonuc;
            Console.Write("Bir Sayı Giriniz?");
            sayi = Convert.ToInt32(Console.ReadLine());
            sonuc = sayi % 2;
            if (sonuc==0)
            {
                Console.Write("Girilen Sayı Çift Sayıdır.");
            }
            else
            {
                Console.Write("Girilen Sayı Tek Sayıdır.");
            }
            Console.ReadKey();
        }
    }
}
