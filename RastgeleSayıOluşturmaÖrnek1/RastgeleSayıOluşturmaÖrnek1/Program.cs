using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastgeleSayıOluşturmaÖrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rastgelesayi = rnd.Next(-50, 50);
            Console.Write("Üretilen Rastgele Sayı:{0}", rastgelesayi);
            Console.ReadKey();
        }
    }
}
