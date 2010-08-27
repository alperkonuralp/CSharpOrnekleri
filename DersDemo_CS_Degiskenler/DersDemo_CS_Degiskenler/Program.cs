using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Değişkenlerde dönüşüm
            int i = 1;
            long j = i; // implicit yapılan değişim

            int k = (int)j; // explicit olarak yapılan değişim.

            // string -> sayı , sayı -> string dönüşümleri
            // bir sayıyı string'e çevirmek için .ToString()
            // metodu kullanılır

            string yazi1 = i.ToString();
            string yazi2 = j.ToString();

            // bir yazıyı sayıya çevirmek için tipin .Parse()
            // metodu kullanılır.
            int x = int.Parse(yazi1);
            long y = long.Parse(yazi2);

            // string -> tarihi çevirimi
            DateTime dt = DateTime.Parse("01.01.2010");

            string dts2 = "01.01.2010";
            DateTime dt2 = DateTime.Parse(dts2);

            //DateTime dt3 = DateTime.Parse(Console.ReadLine());


            DateTime dt4 = new DateTime(2010, 1, 15);

            int year = 2010;
            int month = 8;
            int day = 27;

            DateTime dt5 = new DateTime(year, month, day, 10, 14, 25);

            DateTime dtNow = DateTime.Now;
            DateTime dtToday = DateTime.Today;

            DateTime dt10Day = dtNow.AddDays(10);


            // Stok Bilgi Girişi Yapıldığını Düşünelim
            int stokKodu;
            Console.Write("Stok Kodunu Giriniz: ");
            stokKodu = int.Parse(Console.ReadLine());

            // stok adı
            Console.Write("Stok Adını Giriniz: ");
            string stokAdi = Console.ReadLine();

            // birim fiyatı
            Console.Write("Birim Fiyatı Giriniz: ");
            float birimFiyat = float.Parse(Console.ReadLine());

            // stok adedi
            Console.Write("Stok Adedini giriniz: ");
            int stokAdedi = int.Parse(Console.ReadLine());

            // stok bilgilerini ekrana yazdıralım.
            Console.WriteLine();
            Console.WriteLine("Girdiğiniz stok bilgileri : ");
            Console.WriteLine("Kodu : {0}", stokKodu);
            Console.WriteLine("Adı : {0}", stokAdi);
            Console.WriteLine("Birim Fiyatı : {0}", birimFiyat);
            Console.WriteLine("Adedi : {0}", stokAdedi);

            float toplamFiyat = birimFiyat * stokAdedi;

            Console.WriteLine("Toplam Fiyat : {0}", toplamFiyat);

        }
    }
}
