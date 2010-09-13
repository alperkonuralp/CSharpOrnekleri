using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DersDemo_CS_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ogrenciler = new ArrayList();

            ArrayList og1 = new ArrayList();
            og1.Add("Alper");
            og1.Add("Konuralp");
            og1.Add(45);
            og1.Add(55);

            ogrenciler.Add(og1);

            ArrayList og2 = new ArrayList();
            og2.Add("Burcu");
            og2.Add("Konuralp");
            og2.Add(55);
            og2.Add(65);

            ogrenciler.Add(og2);

            ArrayList og3 = new ArrayList();
            og3.Add("Yağmur");
            og3.Add("Konuralp");
            og3.Add(65);
            og3.Add(75);

            ogrenciler.Add(og3);

            foreach (ArrayList item in ogrenciler)
            {
                Console.WriteLine(
                    "{0,-20} {1,-20} {2:D2} {3:D2} {4:D2}",
                    item[0],
                    item[1],
                    item[2],
                    item[3],
                    ((int)item[2] * 4 + (int)item[3] * 6) / 10);
            }

            ArrayList[] dizi =
                (ArrayList[])ogrenciler.ToArray(typeof(ArrayList));

            ArrayList ogr2 = new ArrayList(dizi);


            ArrayList sayilar = new ArrayList();
            sayilar.Add(15);
            sayilar.AddRange(
                new int[] { 17, 13, 1, 2, 47, 8 });

            int[] dizi2 =
                (int[])sayilar.ToArray(typeof(int));

            
        }
    }
}
