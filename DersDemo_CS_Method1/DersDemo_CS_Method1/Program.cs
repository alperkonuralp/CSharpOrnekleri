using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Method1
{
    class Program
    {

        private static int SayiSor()
        {
            CWL("Sayıyı Giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            return sayi;
        }

        static int SayiSor2(string mesaj)
        {

            if (string.IsNullOrEmpty(mesaj))
                mesaj = "Sayıyı Giriniz: ";
            while (true)
            {
                try
                {
                    Console.Write(mesaj);
                    int i = int.Parse(Console.ReadLine());
                    return i;
                    //return int.Parse(Console.ReadLine());
                }
                catch (FormatException fex)
                {
                    Console.WriteLine("Lütfen geçerli bir sayı değeri giriniz.");
                }
            }
        }

        static void CWL(string p)
        {
            Console.WriteLine(p);
        }


        static void Main(string[] args)
        {
            //CWL("Mesaj");

            //int a = 5;
            //int b = 6;
            //int c = a + b;


            Console.WriteLine(SayiSor2("İlk Sayıyı Giriniz: ") + 10);


            Console.WriteLine(SayiSor2(null) +
                SayiSor2("ikinci sayıyı giriniz: "));

            int sayi1 = ToplamAl(15);
            Console.WriteLine(sayi1);

            Console.WriteLine(ToplamAl(20));
        }


        static int ToplamAl(int n)
        {
            int toplam = 0;

            for (int i = 1; i <= n; i++)
            {
                toplam += i;
            }

            return toplam;
        }

    }
}
