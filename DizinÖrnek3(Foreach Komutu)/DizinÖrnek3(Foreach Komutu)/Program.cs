using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizinÖrnek3_Foreach_Komutu_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = new string[5] { "ANKARA", "İSTANBUL", "YOZGAT", "AFYON", "ÇANKIRI" };
            foreach (string eleman in sehirler)
            {
                Console.WriteLine("{0}", eleman);
            }
            Console.ReadKey();
        }
    }
}
