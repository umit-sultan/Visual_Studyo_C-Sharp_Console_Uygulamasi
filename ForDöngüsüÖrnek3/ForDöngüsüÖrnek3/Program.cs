using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDöngüsüÖrnek3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            for (int sayac = 1; sayac <6; sayac++)
            {
                Console.Write("Bir Sayı Giriniz?");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi>0)
                {
                    Console.WriteLine("Pozitif");
                }
                else if (sayi<0)
                {
                    Console.WriteLine("Negatiftir");
                }
                else if (sayi==0)
                {
                    Console.WriteLine("Sıfır");
                }
                Console.ReadKey();
            }
        }
    }
}
