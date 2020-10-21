using System;

namespace İf_ElseÖrnek4
{
    class Program
    {
        // || = VEYA KODU Bu Kodda Koşullardan Biri Doğru Olsa Bile İf Bloğu Çalışır.!!! // 
        static void Main(string[] args)
        {
            string kullaniciadi, sifre;
            Console.Write("Kullanıcı Adınızı Giriniz?");
            kullaniciadi = Console.ReadLine();
            Console.Write("Şifrenizi Giriniz");
            sifre = Console.ReadLine();
            if (kullaniciadi != "BeşiktAŞK" || sifre!= "1903") 
            {
                Console.Write("Kullanıcı Adı Veya Şifre Hatalı!");
            }
            else
            {
                Console.Write("Giriş Başarılı,Hoşgeldiniz.");
            }
            Console.ReadKey();
        }
    }
}
