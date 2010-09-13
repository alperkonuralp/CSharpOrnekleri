using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Ogrenci o = new Ogrenci();
            Console.WriteLine(o.OkulAdi());
            

            EgeOgrencisi eo = new EgeOgrencisi();
            Console.WriteLine(eo.OkulAdi());

            Ogrenci o2 = eo;
            Console.WriteLine(o2.OkulAdi());
        }
    }
}
