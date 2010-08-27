using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            long b = a; //implicit : otomatik tip dönüşümü
            // Küçük tipten büyük tipe çevirim yapılır
            b += 12357094543;


            long x = long.MaxValue;
            int y = (int)x;
            Console.WriteLine("{0} = {1}", x, y);
        }
    }
}
