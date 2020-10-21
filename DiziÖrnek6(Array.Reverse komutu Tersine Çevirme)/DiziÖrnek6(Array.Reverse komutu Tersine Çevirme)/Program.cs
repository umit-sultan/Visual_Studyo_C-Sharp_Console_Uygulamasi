using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziÖrnek6_Array.Reverse_komutu_Tersine_Çevirme_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[6] { 133, 233, 333, 433, 533, 633 };
            Array.Reverse(sayilar);
            foreach (int sayi in sayilar)
            {
                Console.WriteLine("{0}", sayi);
            }
            Console.ReadKey();
        }
    }
}