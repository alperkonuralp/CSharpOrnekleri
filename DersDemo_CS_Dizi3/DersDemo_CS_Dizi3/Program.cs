using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace DersDemo_CS_Dizi3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] adlar = { 
                             "Alper",
                             "Ali",
                             "İbrahim",
                             "Anıl",
                             "Özcan",
                             "salim",
                             "yaşar",
                             "şakir",
                             "onur",
                             "Ümit",
                             "umut",
                             "ismail",
                             "ılgız",
                             "ertem"
                             };

            System.Threading.Thread.CurrentThread.CurrentCulture =
                //new CultureInfo("ja-jp");
                new CultureInfo("en-gb");
            Console.WriteLine("Para : {0:C}", 125.48);
            Console.WriteLine("Bugün : {0} {0:dddd}", DateTime.Now);
            Array.Sort(adlar);

            Array.Reverse(adlar);

            for (int i = 0; i < adlar.Length; i++)
            {
                Console.WriteLine(adlar[i]);
            }

            string[] a = adlar;
            a[0] = "YAŞAR";

            Console.WriteLine(adlar[0]);

            string[] b = (string[])adlar.Clone();


            Array.Clear(adlar, 0, adlar.Length);

            Console.WriteLine();

            Console.WriteLine(adlar[0]);
            Console.WriteLine(a[0]);
            Console.WriteLine(b[0]);

            Console.WriteLine(
                "Alper dizi içinde {0} indeksinde",
                Array.IndexOf(b, "Alper"));
            Console.WriteLine(
                "Mustafa dizi içinde {0} indeksinde",
                Array.IndexOf(b, "Mustafa"));

            Console.WriteLine();
            Console.WriteLine(
                "Alper dizi içinde {0} indeksinde",
                Array.LastIndexOf(b, "Alper"));
            Console.WriteLine(
                "Mustafa dizi içinde {0} indeksinde",
                Array.LastIndexOf(b, "Mustafa"));


            foreach (string z in b)
            {
                Console.WriteLine(z);
            }
        }
    }
}
