using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_Arrays_Örnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] notlar = new int[4, 2] { { 50, 40 }, { 60, 70 }, { 70, 80 }, { 80, 90 } };
            Console.WriteLine("1.Satır 1.Eleman{0}", notlar[0, 0]);
            Console.WriteLine("2.Satır 2.Eleman{0}", notlar[1, 1]);
            Console.WriteLine("3.Satır 1.Eleman{0}", notlar[2, 0]);
            Console.WriteLine("4.Satır 2.Eleman{0}", notlar[3, 1]);
            Console.ReadKey();
        }
    }
}
