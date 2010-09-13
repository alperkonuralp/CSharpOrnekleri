using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            Ogrenci[] dizi = new Ogrenci[6];

            TrabzonLisesiOgrencisi o1 =
                new TrabzonLisesiOgrencisi();
            o1.no = 123;
            o1.adSoyad = "Anıl Kurt";
            o1.matematikNeti = 100;
            o1.turkceNeti = 50;

            dizi[0] = o1;

            KarsiyakaAnadoluOgrencisi o2 =
                new KarsiyakaAnadoluOgrencisi(80, 80, 85);

            o2.no = 234;
            o2.adSoyad = "İbrahim Çınaroğlu";

            dizi[1] = o2;



            TrabzonLisesiOgrencisi o3 =
                new TrabzonLisesiOgrencisi();
            o3.no = 457;
            o3.adSoyad = "Yaşar Çetin";
            o3.matematikNeti = 74;
            o3.turkceNeti = 52;

            dizi[2] = o3;

            KarsiyakaAnadoluOgrencisi o4 =
                new KarsiyakaAnadoluOgrencisi(45, 87, 88);

            o4.no = 657;
            o4.adSoyad = "Hakan Çalışır";

            dizi[3] = o4;




            TrabzonLisesiOgrencisi o5 =
                new TrabzonLisesiOgrencisi();
            o5.no = 117;
            o5.adSoyad = "Nazan Özel";
            o5.matematikNeti = 11;
            o5.turkceNeti = 22;

            dizi[4] = o5;

            KarsiyakaAnadoluOgrencisi o6 =
                new KarsiyakaAnadoluOgrencisi(83, 56, 57);

            o6.no = 663;
            o6.adSoyad = "İsmail XY";

            dizi[5] = o6;
            

            IFen ife = o2;
            Console.WriteLine(ife.FenNeti());

            Console.WriteLine();

            IMatematik[] Matematikciler =
                new IMatematik[6];

            Matematikciler[0] = o1;
            Matematikciler[1] = o2;
            Matematikciler[2] = o3;
            Matematikciler[3] = o4;
            Matematikciler[4] = o5;
            Matematikciler[5] = o6;

            foreach (IMatematik item in Matematikciler)
            {
                Console.WriteLine(item.MatematikNeti());
            }


            Console.WriteLine();

            IFen[] Fenciler =
                new IFen[3];

            Fenciler[0] = o2;
            Fenciler[1] = o4;
            Fenciler[2] = o6;

            foreach (IFen item in Fenciler)
            {
                Console.WriteLine(item.FenNeti());
            }
        }
    }
}
