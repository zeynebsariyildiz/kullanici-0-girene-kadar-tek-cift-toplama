using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullanici_0_girene_kadar_tek_cift_toplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Bir Sayı Giriniz");
            Console.ReadLine();
            int sayi = 0;
            if (sayi % 2 == 0)
            {
                Console.Write("Girilen Sayı Çifttir");
                Console.ReadLine();
            }
            else
            {
                Console.Write("Girilen Sayı Tektir");
                Console.ReadLine();
            }
           
        }
    }
}
