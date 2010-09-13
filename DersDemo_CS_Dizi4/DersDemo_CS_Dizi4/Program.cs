using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Dizi4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sınıfta kaç öğrenci var: ");
            int ogrenciSayisi = int.Parse(Console.ReadLine());

            string[] ogrenciler = new string[ogrenciSayisi];

            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Console.Write("{0}. Öğrencinin Adı: ", i + 1);
                ogrenciler[i] = Console.ReadLine();
            }

            Array.Sort(ogrenciler);

            Console.WriteLine();
            Console.WriteLine("Öğrenci Listesi");
            Console.WriteLine(new string('-', 40));

            foreach (string item in ogrenciler)
            {
                Console.WriteLine(item);
            }


        }
    }
}
