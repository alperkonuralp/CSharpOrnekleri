using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menü");
            Console.WriteLine("1-Toplama");
            Console.WriteLine("2-Çıkartma");
            Console.WriteLine("3-Çarpma");
            Console.WriteLine("4-Bölme");
            Console.Write("Seçiminiz: ");
            int secim = int.Parse(Console.ReadLine());

            decimal sayi1, sayi2;

            Console.Write("1. Sayı : ");
            sayi1 =
               decimal.Parse(Console.ReadLine());
            Console.Write("2. Sayı : ");
            sayi2 =
               decimal.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1: // toplama seçildi ise 
                    
                    Console.WriteLine("{0} + {1} = {2}",
                        sayi1, sayi2, sayi1 + sayi2);
                    break;

                case 2: // Çıkartma seçildi ise 

                    Console.WriteLine("{0} - {1} = {2}",
                        sayi1, sayi2, sayi1 - sayi2);
                    break;

                case 3: // Çarpma seçildi ise 

                    Console.WriteLine("{0} * {1} = {2}",
                        sayi1, sayi2, sayi1 * sayi2);
                    break;

                case 4: // Bölme seçildi ise 

                    Console.WriteLine("{0} / {1} = {2}",
                        sayi1, sayi2, sayi1 / sayi2);
                    break;
                default:
                    Console.WriteLine(
                        "Lütfen geçerli bir seçim yapınız.");
                    break;
            }
        }
    }
}
