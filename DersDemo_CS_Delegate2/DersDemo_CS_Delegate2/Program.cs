using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Delegate2
{
    class Program
    {
        public static HesapMakinasi hs = new HesapMakinasi();
        static void Main(string[] args)
        {
            hs.ilkSayi = 78;
            hs.ikinciSayi = 25;

            hs.Topla();

            Console.WriteLine(hs.sonuc);

            hs.IlaveIslem = SinusAl;
            //hs.IlaveIslem = new EkIslem(SinusAl);

            hs.IlaveIslemiYap();
        }

        static void SinusAl()
        {
            hs.sonuc = Math.Sin(hs.ilkSayi * Math.PI / 180);
        }

        static void ModAl()
        {
            hs.sonuc = hs.ilkSayi % hs.ikinciSayi;
        }
    }
}
