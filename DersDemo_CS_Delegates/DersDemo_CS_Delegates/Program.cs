using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Delegates
{
    public delegate int Islem(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            Islem i;

            i = new Islem(Topla);
            Console.WriteLine(i(25, 64));

            i = new Islem(Cikart);
            Console.WriteLine(i(25, 64));

        }

        public static int Topla(int i1, int i2)
        {
            return i1 + i2;
        }

        private static int Cikart(int a, int b)
        {
            return a - b;
        }

        public int Carp(int a, int b)
        {
            return a * b;
        }

        private int Bol(int a, int b)
        {
            return a / b;
        }
    }
}
