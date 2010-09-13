using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DersDemo_CS_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetDirectoryNamesByDirectory();
            //GetDirectoryNamesByDirectoryInfo();
            //CreateDirectory();
            //MoveDirectory();
            //DeleteDirectory();
            //ExistsFile();
            //MoveFile();
            //WriteConfigurationFile();
            GetStorages();
        }

        public static void GetDirectoryNamesByDirectory()
        {
            string[] dizinler =
                Directory.GetDirectories("c:\\");

            foreach (string item in dizinler)
            {
                Console.WriteLine(item);
            }

        }
        public static void GetDirectoryNamesByDirectoryInfo()
        {
            DirectoryInfo di = new DirectoryInfo("c:\\");

            foreach (DirectoryInfo item in di.GetDirectories())
            {
                Console.WriteLine(item.Name);
            }
        }

        // yeni dizin oluşturmak
        public static void CreateDirectory()
        {
            // 1. Yöntem Directory ile 
            if (!Directory.Exists("c:\\ara2"))
                Directory.CreateDirectory("c:\\ara2");

            // 2. yöntem : directoryInfo ile
            DirectoryInfo di = new DirectoryInfo("c:\\ara3");
            if (!di.Exists) di.Create();
        }

        // dizinin ismini değiştirmek veya taşımak
        public static void MoveDirectory()
        {
            // 1. Yöntem Directory ile 
            Directory.Move("c:\\ara2", "c:\\ara\\ara2a");

            // 2. yöntem : DirectoryInfo ile
            DirectoryInfo di = new DirectoryInfo("c:\\ara3");
            di.MoveTo("c:\\ara\\ara3a");
        }


        // dizini silmek
        public static void DeleteDirectory()
        {
            // 1. Yöntem Directory ile 
            Directory.Delete("c:\\ara\\ara2a");

            // 2. yöntem : DirectoryInfo ile
            DirectoryInfo di = new DirectoryInfo("c:\\ara\\ara3a");
            di.Delete();

        }


        // dosyanın varlığını kontrol etmek
        public static void ExistsFile()
        {
            // 1. Yöntem : File
            Console.WriteLine("Dosya Var : {0}",
                File.Exists("c:\\ara\\rehber.dat"));

            // 2. Yöntem : FileInfo
            FileInfo fi =
                new FileInfo("c:\\ara\\rehber.dat");
            Console.WriteLine("Dosya var : {0}", fi.Exists);
        }

        // dosyayı taşıma:
        public static void MoveFile()
        {
            // 1. Yöntem : File
            if (File.Exists("c:\\ara\\rehber.dat"))
                File.Move("c:\\ara\\rehber.dat", "c:\\ara\\rehber2.dat");

            // 2. Yöntem : FileInfo
            FileInfo fi =
                new FileInfo("c:\\ara\\rehber2.dat");
            //Console.WriteLine("Dosya var : {0}", fi.Exists);
            if (fi.Exists)
                fi.MoveTo("c:\\ara\\rehber.dat");
        }

        public static void WriteConfigurationFile()
        {
            DirectoryInfo di = new DirectoryInfo(
                "c:\\Conf\\Deneme");
            if (!di.Exists) di.Create();

            File.WriteAllText(
                "c:\\conf\\deneme\\ara.conf",
                "Merhaba Dünya");

            // satır satır bilgi yazmak için kullanılır.
            //File.WriteAllLines

            // byte byte dosyaya veri yazmak için kullanılır.
            //File.WriteAllBytes

            // dosyanın arkasına parametre ile verilen yazıyı ekler.
            //File.AppendAllText

            // dosya içeriğini byte dizisi şeklinde okur.
            //File.ReadAllBytes

            // dosya içeriğini string dizisi şeklinde okur.
            //File.ReadAllLines

            // dosya içeriğini string şeklinde okur.
            //File.ReadAllText
        }

        public static void GetStorages()
        {
            DriveInfo[] drives =
                DriveInfo.GetDrives();

            foreach (DriveInfo item in drives)
            {
                Console.WriteLine(new string('-', 30));
                Console.WriteLine("Name : {0}", item.Name);
                Console.WriteLine("Is Ready: {0}",
                    item.IsReady);
                if (item.IsReady)
                {
                    Console.WriteLine("Volume Label : {0}",
                        item.VolumeLabel);
                    Console.WriteLine("Drive Format : {0}",
                        item.DriveFormat);
                    Console.WriteLine("Drive Type : {0}",
                        item.DriveType);
                    Console.WriteLine("Root Directory : {0}",
                        item.RootDirectory);
                    Console.WriteLine("Total Size : {0}",
                        item.TotalSize);
                    Console.WriteLine("Available Free Space : {0}",
                        item.AvailableFreeSpace);
                    Console.WriteLine("Total Free Space : {0}",
                        item.TotalFreeSpace);

                }
                Console.WriteLine(new string('-', 30));
            }
        }
    }
}
