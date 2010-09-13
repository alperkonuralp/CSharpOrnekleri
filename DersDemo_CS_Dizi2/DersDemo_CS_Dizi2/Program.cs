using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Dizi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sınıfta kaç kişi var? ");
            int sayi = int.Parse(Console.ReadLine());

            double[] boylar = new double[sayi];

            for (int i = 0; i < sayi; i++)
            {
                Console.Write("{0}. öğrencinin boyu : ", i + 1);
                double boy = double.Parse(Console.ReadLine());
                boylar[i] = boy;
            }

            double toplam = 0.0;
            for (int i = 0; i < sayi; i++)
            {
                toplam += boylar[i];
                Console.WriteLine(
                    "{0}. Öğrencinin Boyu: {1:N2}",
                    i + 1, boylar[i]);
            }
            Console.WriteLine("Ortalama Boy : {0:N2}",
                toplam / sayi);
        }
    }
}
