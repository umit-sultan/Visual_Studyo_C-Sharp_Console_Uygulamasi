using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizinÖrnek4_Foreach_DizinSilme_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ogrenci = new int[7] { 101, 102, 103, 104, 105, 106, 107 };
            Array.Clear(ogrenci, 2, 4);
            foreach (int ogr in ogrenci)
            {
                Console.WriteLine("{0}", ogr);
            }
            Console.ReadKey();
        }
    }
}
