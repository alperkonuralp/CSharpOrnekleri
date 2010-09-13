using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci.GecisNotu = 80;

            Ogrenci o1 = new Ogrenci();
            o1.no = 123;
            o1.adi = "Kemal Sunal";
            o1.vize = 55;
            o1.final = 65;

            Console.WriteLine(o1.no);
            Console.WriteLine(o1.adi);
            Console.WriteLine(o1.vize);
            Console.WriteLine(o1.final);
            Console.WriteLine(o1.Ortalama());
            Console.WriteLine(o1.GectiKaldi());

            Console.WriteLine();

            Ogrenci o2 = new Ogrenci();
            o2.no = 234;
            o2.adi = "Adile Naşit";
            o2.vize = 66;
            o2.final = 80;

            Console.WriteLine(o2.no);
            Console.WriteLine(o2.adi);
            Console.WriteLine(o2.vize);
            Console.WriteLine(o2.final);
            Console.WriteLine(o2.Ortalama());
            Console.WriteLine(o2.GectiKaldi());
        }
    }
}
