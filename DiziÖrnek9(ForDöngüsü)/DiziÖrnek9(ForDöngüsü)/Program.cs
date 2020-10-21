using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziÖrnek9_ForDöngüsü_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ogrenciler = new string[5] { "101", "102", "103", "104", "105" };
            int[,] notlar = new int[5, 3] { { 50, 70, 65 }, { 65, 65, 65 }, { 90, 85, 80 }, { 50, 50, 50 }, { 70, 70, 70 } };
            int j = 0;
            for (int i = 0; i <=4; i++)
            {
                double ort = (notlar[i, j] + notlar[i, j + 1] + notlar[i, j + 2]) / 3;
                Console.WriteLine("Öğrenci No:{0} Ortalama:{1}", ogrenciler[i], ort);
            }
            Console.ReadKey();
        }
    }
}
