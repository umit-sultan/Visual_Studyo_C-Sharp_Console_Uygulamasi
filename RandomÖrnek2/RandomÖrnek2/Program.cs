﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomÖrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random x = new Random();
            int s1 = x.Next(1, 25);
            int s2 = x.Next(1, 25);
            int s3 = x.Next(1, 25);
            int s4 = x.Next(1, 25);
            int s5 = x.Next(1, 25);
            Console.Write("1.Öğrenci:{0} 2.Öğrenci:{1} 3.Öğrenci:{2} 4.Öğrenci{3} 5.Öğrenci:{4}", s1, s2, s3, s4, s5);
            Console.ReadKey();
        }
    }
}