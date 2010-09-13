using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DersDemo_CS_StreamReaderWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw =
                new StreamWriter("c:\\ara\\ara2.txt", false, Encoding.UTF8))
            {
                sw.WriteLine("Merhaba Dünya, Bu ilk dosya örneğimiz.");
                sw.WriteLine("Bugün : {0}", DateTime.Now);
            }

            using (StreamReader sr = new StreamReader(
                "c:\\ara\\ara2.txt", Encoding.UTF8))
            {
                string s = sr.ReadToEnd();
                Console.Write(s);
            }
        }
    }
}
