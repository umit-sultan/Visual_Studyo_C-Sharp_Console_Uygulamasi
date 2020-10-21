using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İf_ElseİfÖrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Bir Sayı Giriniz?");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi<0)
            {
                Console.Write("Sayı Negatiftir.");
            }
            else if (sayi>0)
            {
                Console.Write("Sayı Pozitiftir.");
            }
            else
            {
                Console.Write("Sayı Sıfıra Eşittir.");
            }
            Console.ReadKey();
        }
    }
}
