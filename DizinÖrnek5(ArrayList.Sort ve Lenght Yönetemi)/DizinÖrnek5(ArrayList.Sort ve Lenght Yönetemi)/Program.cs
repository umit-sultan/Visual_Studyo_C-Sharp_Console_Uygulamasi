using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizinÖrnek5_ArrayList.Sort_ve_Lenght_Yönetemi_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = new string[6] { "ANKARA", "ERZURUM", "KARS", "SİNOP", "VAN", "ADIYAMAN" };
            Array.Sort(sehirler);
            foreach (string sehir in sehirler)
            {
                Console.WriteLine("{0}", sehir);
            }
            Console.Write("Dizideki Eleman Sayısı:{0}", sehirler.Length);
            Console.ReadKey();
        }
    }
}
