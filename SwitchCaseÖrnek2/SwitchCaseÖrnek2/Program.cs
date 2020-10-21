using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseÖrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            char secim;
            Console.WriteLine("1-) Batı Karadeniz Turu");
            Console.WriteLine("2-) İç Anadolu Turu");
            Console.WriteLine("3-) Akdeniz Turu");
            Console.WriteLine("4-) Ege Turu");
            Console.WriteLine("Seçiminizi Yapınız [1,2,3,4]");
            secim = Convert.ToChar(Console.ReadLine());
            switch (secim)
            {
                case '1':
                    Console.WriteLine("Batı Karadeniz Turu");
                    Console.WriteLine("Tarih Aralığı:30.01.2017-02.02.2017");
                    Console.WriteLine("Pazartesi:Karabük Salı:Kastamonu Çarşamba:Sinop");
                    Console.Write("Fiyat:2 Kişi+0-6 yaş çocuk 600TL(Her Yetişkin İçin 200TL)");
                    break;
                case '2':
                    Console.WriteLine("İç Anadolu Turu");
                    Console.WriteLine("Tarih Aralığı:01.02.2017-03.02.2017");
                    Console.WriteLine("Çarşamba:Ankara Perşembe:Konya Cuma:Eskişehir");
                    Console.Write("Fiyat:2 Kişi+0-6 yaş çocuk 450TL(Her Yetişkin İçin 150TL)");
                    break;
                case '3':
                    Console.WriteLine("Akdeniz Turu");
                    Console.WriteLine("Tarih Aralığı:02.02.2017-04.02.2017");
                    Console.WriteLine("Pazartesi:Antalya Salı:Mersin Çarşamba:Hatay");
                    Console.Write("Fiyat:2 Kişi+0-6 yaş çocuk 900TL(Her Yetişkin İçin 225TL)");
                    break;
                case '4':
                    Console.WriteLine("Ege Turu");
                    Console.WriteLine("Tarih Aralığı:03.02.2017-05.02.2017");
                    Console.WriteLine("Pazartesi:Muğla Salı:İzmir Çarşamba:Aydın");
                    Console.Write("Fiyat:2 Kişi+0-6 yaş çocuk 1100TL(Her Yetişkin İçin 275TL)");
                    break;
            }
            Console.ReadKey();
        }
    }
}