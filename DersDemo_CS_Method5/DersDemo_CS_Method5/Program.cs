using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Method5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Topla3(12, 35, 78));
            Console.WriteLine(Topla(12, 35, 78));

            Console.WriteLine(Topla4(12, 35, 78, 154));
            Console.WriteLine(Topla(12, 35, 78, 154));

            Console.WriteLine(Topla(12, 35, 78, 154, 1, 74, 13));

            //int[] id = { 2, 3, 4, 5, 6 };
            //Console.WriteLine(Topla(id));

            //Console.WriteLine(Topla());

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", 1, 2, 3, 4, 5);
        }

        static int Topla(int a, int b, params int[] pars)
        {
            int toplam = a + b;
            for (int i = 0; i < pars.Length; i++)
            {
                toplam += pars[i];
            }
            return toplam;
        }

        static int Topla2(int a, int b)
        {
            return a + b;
        }
        static int Topla3(int a, int b, int c)
        {
            return a + b + c;
        }
        static int Topla4(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    }
}
