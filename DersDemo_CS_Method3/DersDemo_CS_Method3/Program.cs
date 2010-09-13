using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Method3
{
    class Program
    {
        static void Ekle(int a)
        {
            a++;
        }

        // 1. yöntem geri dönüş değeri ile sonuca ulaşmak.
        static int Ekle2(int a)
        {
            return ++a;
        }

        // 2. Yöntem in/out türünde bir parametre kullanma.
        // ref kelimesinden yararlanılır.
        // bu yöntem değer türündeki değişkenlerde anlamlıdır.
        static void Ekle3(ref int a) {
            a++;
        }

        static void Main(string[] args)
        {
            int z = 5;
            //Ekle(z);
            //Ekle(5);
            //z = Ekle2(z);
            Ekle3(ref z);

            Console.WriteLine(z);
        }
    }
}
