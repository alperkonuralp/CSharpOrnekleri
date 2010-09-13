using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace DersDemo_CS_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ogrenciler =
                new Dictionary<int, string>();

            ogrenciler[1] = "Alper";
            ogrenciler.Add(2, "Burcu");
            ogrenciler.Add(3, "Yağmur");

            Console.WriteLine(ogrenciler[1]);

            Console.WriteLine();

            foreach (KeyValuePair<int, string> item in ogrenciler)
            {
                Console.WriteLine("{0} => {1}",
                    item.Key, item.Value);
            }

            //Console.WriteLine(ogrenciler[4]);
            string s;
            if (ogrenciler.TryGetValue(4, out s))
            {
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("Öğrenciyi Bulamadım.");
            }

            SortedDictionary<int, string> ogr2 =
                new SortedDictionary<int, string>();

            ogr2[5] = "Alper";
            ogr2[2] = "Ali";
            ogr2[3] = "Burcu";
            ogr2[1] = "Yağmur";
            ogr2[6] = "Çiğdem";
            ogr2[4] = "Ela";

            foreach (KeyValuePair<int, string> item in ogr2)
            {
                Console.WriteLine("{0} => {1}",
                    item.Key, item.Value);
            }

            
        }
    }
}
