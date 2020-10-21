using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDöngüsüÖrnek2
{
    class Program
    {
       // Ekrandan 1-100 arasındaki 10 ve katı sayıyı görüntüleyen program? // 
        static void Main(string[] args)
        {
            int x = 1;
            while (x<=100)
            {
                if (x%10==0)
                {
                    Console.WriteLine(x);
                }
                x++;
            }
            Console.ReadKey();
        }
    }
}
