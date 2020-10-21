using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziÖrnek7_Array.IndexOf_ve_LastIndexOf_
{
    class Program
    {
       //* Array.IndexOf komutu aramaya en baştan başlar. Array.LastIndexOf komutu ise En sondan aramaya başlar.//*
       //* Ama sonuç olara iki komutta aynı sırayı verir. *//
         static void Main(string[] args)
        {
            string[] personellistesi = new string[5] { "ÜMİT SULTAN", "ADEM BÖCEK", "İSMAİL TÜRÜT", "SİBEL CAN", "DİDEM BÜYÜKAĞAÇ" };
            Console.Write(Array.IndexOf(personellistesi, "İSMAİL TÜRÜT"));
            Console.ReadKey();
        }
    }
}
