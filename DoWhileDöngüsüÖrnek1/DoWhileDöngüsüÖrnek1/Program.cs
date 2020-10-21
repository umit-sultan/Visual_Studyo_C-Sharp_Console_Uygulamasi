using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDöngüsüÖrnek1
{
    class Program
    {
        // !!!NOT= Eğer bir program parçacığında bazı komutların en az 1 kere çalışmasını istiyorsak do while döngüsü kullanılır.
        //ÖRN= Sistemdeki Kullanıcı Adı ve Şifre ile klavyeden girilen kullanıcı adı ve şifrenin uyuşup uyuşmadığını gösteren program? 
        static void Main(string[] args)
        {
            string kad = "Beşiktaş", ksifre = "1903";
            string kullaniciad, kullanicisifre;
            int hak = 3;
            do
            {
                Console.Write("Kıllanıcı Adınızı Griniz?");
                kullaniciad = Console.ReadLine();
                Console.Write("Şifrenizi Giriniz");
                kullanicisifre = Console.ReadLine();
                if (kullaniciad == kad && kullanicisifre == ksifre)
                {
                    Console.Write("HOŞGELDİNİZ:)");
                }
                else
                {
                    hak--;
                    if (hak == 0)
                    {
                        Console.Write("3 Defada Kullanıcı Adı ve Şifrenizi Giremediniz,Müşteri Hizmetlerini Arayınız!");
                    }
                }
            } while ((kullaniciad == kad || kullanicisifre == ksifre) && hak == 0);
        Console.ReadKey();
        }
    }
}
