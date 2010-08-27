using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_GirilenSayilarinOrtalamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0, i;
            for (i = 1; true; i++)
            {
                //Console.Write("{0}. sayıyı giriniz: ", i);
                //toplam += int.Parse(Console.ReadLine());

                //Console.WriteLine("Devam için enter, çıkış için herhangi birşey yazıp enter.");
                //if (Console.ReadLine() != "")
                //    break;

                Console.Write("{0}. sayıyı giriniz(Çıkış için enter): ", i);
                string st = Console.ReadLine();
                if (st == "")
                {
                    i--;
                    break;
                }
                toplam += int.Parse(st);
            }

            Console.WriteLine("Eleman sayısı : {0}", i);
            Console.WriteLine("Toplam        : {0}", toplam);
            Console.WriteLine("Ortalama      : {0}", toplam / i);
        }
    }
}
