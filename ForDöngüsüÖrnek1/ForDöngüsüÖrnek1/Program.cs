using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDöngüsüÖrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            int top = 0;
            int ort;
            for (int sayac = 1; sayac <=5; sayac++)
            {
                Console.WriteLine("{0}.Sayıyı Giriniz?", sayac);
                sayi = Convert.ToInt32(Console.ReadLine());
                top = top + sayi;
            }
            ort = top / 5;
            Console.Write("Ortalama:{0}", ort);
            Console.ReadKey();
        }
    }
}
