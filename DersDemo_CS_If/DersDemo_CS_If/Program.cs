using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_If
{
    class Program
    {
        static void Main(string[] args)
        {
            // Öğrenci No
            Console.Write("Öğrenci No: ");
            int ogrenciNo = int.Parse(Console.ReadLine());

            // Öğrenci Adı
            Console.Write("Öğrenci Adı: ");
            string ogrenciAdi = Console.ReadLine();

            // Vize
            Console.Write("Vize : ");
            short vize = short.Parse(Console.ReadLine());

            // Final
            Console.Write("Final : ");
            short final = short.Parse(Console.ReadLine());

            // öğrenci ortalamasını hesaplayıp ekrana 
            // yazdıracağız
            short ortalama = (short)((vize * 4 + final * 6) / 10);
            Console.WriteLine("Ortalama : {0}", ortalama);

            // geçip kaldığı sonucunu yazdıracağız
            if (ortalama >= 50)
                Console.WriteLine("Geçtiniz. ");
            else
                Console.WriteLine("Kaldınız. ");
        }
    }
}
