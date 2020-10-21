using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_Arrays_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gunler1 = new string[7] { "1", "2", "3", "4", "5", "6", "7" };
            string[] gunler2 = new string[7] { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            Console.Write("Haftanın {0}. Günü {1} Günüdür.", gunler1[5], gunler2[5]);
            Console.ReadKey();
        }
    }
}
