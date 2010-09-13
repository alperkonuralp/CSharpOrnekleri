using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Indexer
{
    partial class Dizim
    {
        public string Deneme;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[5];

            dizi[0] = 1;
            dizi[1] = 2;
            dizi[2] = 3;
            dizi[3] = 4;
            dizi[4] = 5;

            Dizim d = new Dizim(5, 7);
            d[5] = CommonOperations.GetInt32("32", 0);
            d[6] = CommonOperations.GetInt32(Console.ReadLine(), 0);
            d[7] = 3;



            for (int i = 5; i <= 7; i++)
            {
                Console.WriteLine(d[i]);
            }
        }
    }
}
