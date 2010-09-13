using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Method4
{
    class Program
    {
        static int ToplamAl(out double ortalama)
        {
            Console.Write("Kaç sayı gireceksiniz: ");
            int sayi = int.Parse(Console.ReadLine());

            int toplam = 0;
            for (int i = 0; i < sayi; i++)
            {
                Console.Write("{0}. sayıyı giriniz: ", i + 1);
                int sayi2 = int.Parse(Console.ReadLine());
                toplam += sayi2;
            }

            ortalama = (double)toplam / sayi;
            return toplam;
        }

        static void Main(string[] args)
        {
            //double ort;
            //Console.WriteLine("Toplam : {0}", ToplamAl(out ort));
            //Console.WriteLine("Ortalama : {0}", ort);

            int sayi;
            while (true)
            {
                Console.WriteLine("Yaşınızı giriniz: ");
                if (int.TryParse(Console.ReadLine(), out sayi))
                {
                    Console.WriteLine(
                        "10 yıl sonraki yaşınız: {0}",
                        sayi + 10);
                    break;
                }
                else
                {
                    Console.WriteLine(
                        "Üzgünüm yaşınızı algılayamadım.");
                }
            }
        }
    }
}
