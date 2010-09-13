using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Dizi1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a;
            int[] dizi = new int[5];

            //a = 5;
            dizi[0] = 1;
            dizi[1] = 3;
            dizi[2] = 12;
            dizi[3] = 144;
            dizi[4] = 64;

            // int a = 5;
            int[] dizi2 = { 1, 3, 12, 144, 64 };

            Console.WriteLine(dizi2[2]);

            int toplam = 0;
            for (int i = 0; i < dizi2.Length; i++)
            {
                toplam += dizi2[i];
            }

            Console.WriteLine(toplam);
        }
    }
}
