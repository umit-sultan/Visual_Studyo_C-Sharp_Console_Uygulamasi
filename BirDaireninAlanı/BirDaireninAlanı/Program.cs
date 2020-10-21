using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirDaireninAlanı
{
    class Program
    {
        // const bir değişkene kalıcı bir değer vermemizi sağlar.Asla değiştiremeyiz!!!//
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double yaricap,alan;
            Console.Write("Yarıçap Değerini Giriniz?");
            yaricap = Convert.ToDouble(Console.ReadLine());
            alan = pi * (yaricap * yaricap);
            Console.Write("ALAN:{0}", alan);
            Console.ReadKey();
        }
    }
}
