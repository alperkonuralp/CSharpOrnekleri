using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DersDemo_CS_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            // yazının oluşturulması
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(
                "Merhaba Dünya, Bu ilk dosya örneğimiz.");
            sb.Append("Bugün : ");
            sb.AppendLine(DateTime.Now.ToString());

            string s = sb.ToString();

            // yazıyı byte dizisi haline çevirmek.
            byte[] dizi = Encoding.UTF8.GetBytes(s);

            // filestream ile çalışma
            using (FileStream fs = new FileStream(
                "c:\\ara\\ara.txt", FileMode.Create,
                FileAccess.Write, FileShare.None))
            {
                fs.Write(dizi, 0, dizi.Length);
            }

            dizi = null;

            // dosyadan okuma
            using (FileStream fs = new FileStream(
                "c:\\ara\\ara.txt", FileMode.Open,
                FileAccess.Read, FileShare.None))
            {
                dizi = new byte[fs.Length];
                fs.Read(dizi, 0, dizi.Length);

                // yazıyı utf8 olarak oluşturmak
                string yazi = Encoding.UTF8.GetString(dizi);

                Console.Write(yazi);
            }
        }
    }
}
