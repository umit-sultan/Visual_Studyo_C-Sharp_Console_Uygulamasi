using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İf_ElseİfÖrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            double vize, final, not;
            Console.Write("Vize Notunuzu Giriniz?");
            vize = Convert.ToDouble(Console.ReadLine());
            Console.Write("Final Notunuzu Giriniz");
            final = Convert.ToDouble(Console.ReadLine());
            not=vize*0.4+final*0.6;
            if (not<=29)
            {
                Console.Write("{0} FF ile kaldınız.", not);
            }
            else if (not<=49)
            {
                Console.Write("{0} FD ile kaldınız.", not);
            }
            else if (not<=54)
            {
                Console.Write("{0} DC ile şartlı geçtiniz.", not);
            }
            else if (not<=59)
            {
                Console.Write("{0} DD ile şartlı geçtiniz.", not);
            }
            else if (not<=64)
            {
                Console.Write("{0} CC ile geçtiniz.", not);
            }
            else if (not<=69)
            {
                Console.Write("{0}  CB ile geçtiniz.", not);
            }
            else if (not<=79)
            {
                Console.Write("{0} BB ile geçtiniz.", not);
            }
            else if (not<=89)
            {
                Console.Write("{0} BA ile geçtiniz.", not);
            }
            else if (not<=100)
            {
                Console.Write("{0} AA ile geçtiniz.", not);
            }
            else
            {
                Console.Write("Girilen Vize ve Final Notlarında Yanlışlık Mevcuttur!",not);
            }
            Console.ReadKey();
        }
    }
}