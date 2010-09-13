using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Nullable
{
    class Program
    {
        static int GetInt32(string s, int d)
        {
            int i;
            return int.TryParse(s, out i) ? i : d;
        }

        static int? GetInt32(string s)
        {
            int i;
            return int.TryParse(s, out i) ? (int?)i : null;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Yaşınız : ");
            string s = Console.ReadLine();
            int? yas = GetInt32(s);

            if (yas.HasValue)
            {
                Console.WriteLine("Yaşınız : {0}", yas);
            }
            else
            {
                Console.WriteLine("Yaşınızı girmediniz.");
            }

            Console.WriteLine(yas ?? -1);

            int? x = 5;
            int? y = null;
            int? z = x + y;
            
            Console.WriteLine(z);
        }
    }
}
