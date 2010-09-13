using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Method2
{
    class Program
    {
        static void YaziYaz2(string s1, string s2)
        {
            Console.WriteLine("{0}{1}", s1, s2);
        }

        static void Main(string[] args)
        {
            YaziYaz2("Merhaba ", "Dünya");

            string y1 = "Merhaba ";
            string y2 = "Dünya";

            YaziYaz2(y1, y2);

            Console.Write("Adınız : ");
            string ad = Console.ReadLine();

            YaziYaz2("Merhaba ", ad);

            Console.Clear();

            YaziYaz(ad);
            YaziYazTers(ad);
            // Alper
            // A
            //  l
            //   p
            //    e
            //     r

            //     A
            //    l
            //   p
            //  e
            // r

            // A   A
            //  l l
            //   p
            //  e e
            // r   r

            //Console.Clear();
            //Console.SetCursorPosition(20, 20);
            //Console.WriteLine("Deneme");
        }

        static void YaziYaz(string yazi)
        {
            for (int i = 0; i < yazi.Length; i++)
            {
                // 1. Yöntem
                //for (int j = 0; j < i; j++)
                //{
                //    Console.Write(" ");
                //}
                //Console.WriteLine(yazi[i]);

                // 2. Yöntem
                //Console.WriteLine("{0}{1}",
                //    new string(' ', i),
                //    yazi[i]);

                // 3. yöntem
                

                Console.SetCursorPosition(i, i);
                Console.Write(yazi[i]);

            }
            Console.WriteLine();
        }
        static void YaziYazTers(string yazi)
        {
            for (int i = 0; i < yazi.Length; i++)
            {
                // 1. Yöntem
                for (int j = i + 1; j < yazi.Length; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(yazi[i]);

                // 2. Yöntem
                //Console.WriteLine("{0}{1}",
                //    new string(' ', yazi.Length - 1 - i),
                //    yazi[i]);
            }
        }
    }
}
