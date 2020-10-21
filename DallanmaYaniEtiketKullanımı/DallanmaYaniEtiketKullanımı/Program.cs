using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DallanmaYaniEtiketKullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
        BASADON:
            Console.Clear();
            Console.Write("1.Yazılı Notunuzu Giriniz?");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Yazılı Notunuzu Giriniz?");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3.Yazılı Notunuzu Giriniz?");
            int y3 = Convert.ToInt32(Console.ReadLine());
            int ort = (y1 + y2 + y3) / 3;
            Console.WriteLine("Ortalama:{0}", ort);
        SECIMYAP:
            Console.Write("Başka Bir İşlem Yapmak İster Misiniz? (e veya h)");
            char secim = Convert.ToChar(Console.ReadLine());
            if (secim=='e' || secim== 'E')
            {
                goto BASADON;
            }
            else if (secim== 'h' || secim=='H')
            {
                Console.Write("İyi Günler...");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Yanlış Seçim Yaptınız Lütfen Tekrar Deneyiniz:)");
                goto SECIMYAP;
            }
            Console.ReadKey();
        }
    }
}
