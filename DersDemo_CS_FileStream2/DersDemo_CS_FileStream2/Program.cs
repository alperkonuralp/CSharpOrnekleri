using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DersDemo_CS_FileStream2
{
    class Program
    {
        static void Main(string[] args)
        {
            // dosyanın büyük olmasından dolayı 
            // hafızayı doldurmaması için
            // işlemde tampon kullanacağım.
            byte[] tampon = new byte[1024 * 1024];

            //dosyaları açalım
            // okunacak dosya : 
            using (FileStream fsRead = new FileStream(
                "c:\\DersDemolari\\20100706.rar",
                FileMode.Open, FileAccess.Read,
                FileShare.None))
            using (FileStream fsWrite = new FileStream(
                "c:\\ara\\20100706.rar",
                FileMode.Create, FileAccess.Write,
                FileShare.None))
            {
                int elemanSayisi;
                do
                {
                    elemanSayisi =
                        fsRead.Read(tampon, 0, tampon.Length);

                    fsWrite.Write(tampon, 0, elemanSayisi);

                } while (elemanSayisi == 1024 * 1024);
            }
        }
    }
}
