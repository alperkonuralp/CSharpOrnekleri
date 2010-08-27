using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_If2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8.800 TL'ye kadar % 15
            // 22.000 TL'nin 8.800 TL'si için 1.320 TL, fazlası % 20
            // 50.000 TL'nin 22.000 TL'si için 3.960 TL, fazlası % 27
            // 50.000 TL'den fazlasının 50.000 TL'si için 11.520 TL, 
            // fazlası % 35

            float aylikMaas = 0, yillikMaas = 0, vergi = 0;

            Console.Write("Aylık maaşınızı giriniz: ");
            aylikMaas = float.Parse(Console.ReadLine());

            yillikMaas = aylikMaas * 12;
            Console.WriteLine("Yıllık Maaşınız : {0:C}",
                yillikMaas);

            if (yillikMaas <= 8800)
            {
                vergi = yillikMaas * 0.15f;
            }
            else if (yillikMaas <= 22000)
            {
                vergi = 8800f * 0.15f +
                    (yillikMaas - 8800f) * 0.20f;
            }
            else if (yillikMaas <= 50000)
            {
                vergi = 8800f * 0.15f +
                    (22000f - 8800f) * 0.20f +
                    (yillikMaas - 22000) * 0.27f;
            }
            else
            {
                vergi = 8800f * 0.15f +
                   (22000f - 8800f) * 0.20f +
                   (50000f - 22000) * 0.27f +
                   (yillikMaas - 50000) * 0.35f;
            }

            Console.WriteLine(
                "Ödemeniz gereken vergi : {0:C}",
                vergi);
        }
    }
}
