using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İf_ElseÖrnek3
{
    class Program
    {
     // && = Ve komutudur.İf Bloğundaki Kodların Çalışması İçin Bütün Şartların Sağlanması Gerekir!!!//
        static void Main(string[] args)
        {
            int boy, kilo;
            Console.Write("Boyunuzu Giriniz?(CM Cinsi)");
            boy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kilonuzu Giriniz?");
            kilo = Convert.ToInt32(Console.ReadLine());
            if (boy>167 && kilo<80)
            {
                Console.Write("Başvuru Koşulları Sağlanıyor.");
            }
            else
            {
                Console.Write("Başvuru Koşulları Sağlanmıyor");
            }
            Console.ReadKey();
        }
    }
}
