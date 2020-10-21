using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlavyedenVeriGirişi
{
    class Program
    {
        static void Main(string[] args)
        {
            string ogrno, ad, soyad;
            Console.Write("Öğrenci Numaranızı Giriniz?");
            ogrno = Console.ReadLine();
            Console.Write("Adınızı Giriniz?");
            ad = Console.ReadLine();
            Console.Write("Soyadınızı Giriniz");
            soyad = Console.ReadLine();
            Console.Write("Öğrenci No:{0} Adı:{1} Soyadı:{2}", ogrno, ad, soyad);
            Console.ReadKey();
        }
    }
}
