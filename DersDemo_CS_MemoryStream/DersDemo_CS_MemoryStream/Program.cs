using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace DersDemo_CS_MemoryStream
{
    class Program
    {
        public static readonly Random r = new Random();
        static void Main(string[] args)
        {
            Stopwatch sw1 = new Stopwatch();
            Stopwatch sw2 = new Stopwatch();
            Stopwatch sw3 = new Stopwatch();

            sw1.Start();
            // rastgele eleman sayısını bulalım.
            int elemanSayisi =
                r.Next(1024 * 1024, 20 * 1024 * 1024);

            byte[] dizi;
            using (MemoryStream ms =
                new MemoryStream(elemanSayisi))
            {
                for (int i = 0; i < elemanSayisi; i++)
                {
                    ms.WriteByte((byte)r.Next(0, 255));
                }

                dizi = ms.ToArray();
            }
            sw1.Stop();

            sw2.Start();
            using (FileStream fs = new FileStream(
                "c:\\ara\\rastgele.bin",
                FileMode.Create, FileAccess.Write))
            {
                fs.Write(dizi, 0, dizi.Length);
            }
            sw2.Stop();


            sw3.Start();
            using (FileStream fs = new FileStream(
                    "c:\\ara\\rastgele2.bin",
                    FileMode.Create, FileAccess.Write))
            {
                for (int i = 0; i < elemanSayisi; i++)
                {
                    fs.WriteByte((byte)r.Next(0, 255));
                }
            }
            sw3.Stop();

            Console.WriteLine("işlem {0}, {1} ve {2} ms sürdü",
                sw1.ElapsedMilliseconds,
                sw2.ElapsedMilliseconds,
                sw3.ElapsedMilliseconds);
        }
    }
}
