using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ogrenci o1 = new Ogrenci();
            //o1.no = 123;
            //o1.ad = "Kemal";
            //o1.soyad = "Sunal";
            //o1.vize = 55;

            Ogrenci o1 = new Ogrenci(123, "Kemal", "Sunal");
            o1.vize = 55;

            Ogrenci o2 = new Ogrenci();

            Ogrenci o3 = new Ogrenci(234, "Adile", "Naşit", 55);
            Ogrenci o4 = new Ogrenci(
                234, "Müzeyyen", "Senar", 65, 75);

            Console.WriteLine(o1);

            //Ara a = new Ara();
            Ara a = Ara.Olustur();
            Ara.Olustur();
            Ara.Olustur();
            Ara.Olustur();
            Ara.Olustur();
            Ara.Olustur();
            Ara.Olustur();

            
        }
    }
}
