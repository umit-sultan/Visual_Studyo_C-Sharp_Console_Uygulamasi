using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseYapısı
{
    class Program
    {
        static void Main(string[] args)
        {
            string plaka;
            Console.Write("Plaka Kodunu Giriniz?");
            plaka = Console.ReadLine();
            switch (plaka)
            {
                case "33":
                    Console.Write("33 MERSİN");
                    break;
                case "06":
                    Console.Write("06 ANKARA");
                    break;
                case "34":
                    Console.Write("34 İSTANBUL");
                    break;
                default:
                    Console.Write("Hatalı Veri Girişi");
                    break;
            }
            Console.ReadKey();
        }
    }
}
