using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İf_ElseÖrnek5
{
    class Program
    {
        static void Main(string[] args)
        {
            int kenar1, kenar2, kenar3;
            Console.Write("Kenar1 Değerini Giriniz?");
            kenar1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kenar2 Değerini Giriniz?");
            kenar2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kenar3 Değerini Giriniz?");
            kenar3 = Convert.ToInt32(Console.ReadLine());
            if (kenar1==kenar2 || kenar1==kenar3 || kenar2==kenar3)
            {
                Console.Write("Üçgen İkizkenar Üçgendir.");
            }
            else
            {
                Console.Write("Üçgen İkizkenar Üçgen Değildir.");
            }
            Console.ReadKey();
        }
    }
}
