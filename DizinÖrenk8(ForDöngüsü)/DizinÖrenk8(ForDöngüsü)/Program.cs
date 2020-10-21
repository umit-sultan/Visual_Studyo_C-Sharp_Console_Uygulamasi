using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizinÖrenk8_ForDöngüsü_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gunler1 = new string[7] { "1", "2", "3", "4", "5", "6", "7" };
            string[] gunler2 = new string[7] { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            for (int i = 0; i <=6; i++)
            {
                Console.WriteLine(gunler1[i] + " " + gunler2[i]);
            }
            Console.ReadKey();
        }
    }
}
