using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_While
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1'den n'e kadar olan sayılardan toplamı 
            // 1000'in altında olan en büyük n sayısını 
            // bulunuz.
            // 1+2+3+4+5+6+7+8+9+10 = 55

            int toplam = 0;
            int i = 0;
            while (toplam < 1000)
            {
                toplam += ++i;
            }
            Console.WriteLine(
                "n değeri : {0}", (i - 1));
            Console.WriteLine(
                "toplam değeri : {0}", (toplam - i));
        }
    }
}
