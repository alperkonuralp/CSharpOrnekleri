using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Abstract2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 15, 2, 98, 78, 14, 1, 5

            // 1,                15, 2, 98, 14, 5
            // 1, 2,             15, 98, 14, 5
            // 1, 2, 5,          15, 98, 14
            // 1, 2, 5, 14       15, 98
            // 1, 2, 5, 14, 15   98

            // 2, 15, 78, 14, 1, 5, 98 ---- 6
            // 2, 15, 14, 1, 5, 78, 98 ---- 5
            // 2, 14, 1, 5, 15, 78, 98 ---- 4
            // 2, 1, 5, 14, 15, 78, 98 ---- 3
            // 1, 2, 5, 14, 15, 78, 98 ---- 2
            // 1, 2, 5, 14, 15, 78, 98 ---- 1


            int[] dizimiz = { 15, 2, 98, 78, 14, 1, 5 };
            IntSiralama intSiralama = new IntSiralama();

            intSiralama.Sirala(dizimiz);

            foreach (int item in dizimiz)
            {
                Console.WriteLine(item);
            }

        }
    }
}
