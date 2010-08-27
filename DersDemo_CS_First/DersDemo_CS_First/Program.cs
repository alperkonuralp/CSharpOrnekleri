using System;

namespace DersDemo_CS_First
{

    /// <summary>
    /// Bu C# ile yaptığımız ilk uygulamadır.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Programın Başlangıç Noktasıdır.
        /// </summary>
        public static void Main(string[] args)
        {
            Console.Write("Merhaba Dünya ");
            Console.WriteLine(2 + "kg Patates'in Fiyatı: " + 3.5 + "Tl");
            Console.WriteLine("{1}kg Patates'in Fiyatı: {0}", 3.5, 2);
            Console.WriteLine("{1:D2}kg Patates'in Fiyatı: {0:C}", 3.5, 2);

            Console.Write("Adınız : ");
            string ad = Console.ReadLine();

            Console.WriteLine("Merhaba {0}, aramıza hoşgeldin.", ad);

            GetFile("asd");
            try
            {
                Console.WriteLine(args[0]);
            }
            catch {
                Console.WriteLine("Parametre tanımlanmamış.");
            }

            int a = 5;
            int b = 5;
            Console.WriteLine(a++);
            Console.WriteLine(++b);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }


        /// <summary>
        /// Gets the file.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public static void GetFile(string fileName)
        {
        }
    }
}
