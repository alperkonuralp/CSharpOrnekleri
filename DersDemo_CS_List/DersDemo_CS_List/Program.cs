using System;
using System.Collections.Generic;
using System.Text;
//using System.Linq;
using System.Collections.ObjectModel;

namespace DersDemo_CS_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(5);
            sayilar.Add(30);
            sayilar.Add(15);
            sayilar.AddRange(new int[] { 25, 1, 47, 9, 14, 3 });

            ReadOnlyCollection<int> roc = sayilar.AsReadOnly();

            List<string> liste2 =
                sayilar.ConvertAll<string>(ChangeToString<int>);

            // Linq kullanımı
            //List<string> list3 =
            //    sayilar.Select(x => x.ToString()).ToList();


            // sayılar listesinin içinde 15'e bölünebilen
            // sayı var mı?

            bool sonuc = sayilar.Exists(Ara);
            Console.WriteLine(sonuc ? "Var" : "Yok");

            int sayi = sayilar.Find(Ara);
            Console.WriteLine(sayi);

            sayilar.ForEach(Yaz);

            sayilar.Insert(0, 125);

            sayilar.InsertRange(3, new int[] { 3, 5, 7 });

            
        }

        static void Yaz(int i)
        {
            Console.WriteLine(i);
        }

        static bool Ara(int i)
        {
            return (i % 15) == 0;
        }

        static string ChangeToString<T>(T obj)
        {
            return obj.ToString();
        }
    }
}
