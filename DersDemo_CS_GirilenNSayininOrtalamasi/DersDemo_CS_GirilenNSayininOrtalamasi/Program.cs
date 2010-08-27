using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_GirilenNSayininOrtalamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            // kullanıcı kaç tane sayı gireceğini söyleyecek
            // bu sayı kadar bir sayı girmesi sağlanacak.
            // ve sayıların ortalaması alınacak.

            Console.Write("Kaç adet sayı gireceksiniz? ");
            int n = int.Parse(Console.ReadLine());
            int toplam = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0}. sayıyı giriniz: ", i);
                toplam += int.Parse(Console.ReadLine());
            }

            Console.WriteLine(
                "Girilen sayıların toplamı: {0}", toplam);
            Console.WriteLine(
                "Girilen sayıların ortalaması: {0}", toplam / n);
        }
    }
}
