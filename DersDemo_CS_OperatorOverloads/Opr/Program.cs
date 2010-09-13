using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opr
{
    class Program
    {
        static void Main(string[] args)
        {
            Zaman z1 = new Zaman(10, 33, 41);
            Zaman z6 = new Zaman(10, 33, 41);
            Zaman z2 = new Zaman(5, 32, 57);

            Zaman z3 = z1 + z2;

            Console.WriteLine(z3);

            Zaman z4 = z1 - z2;
            Zaman z5 = z2 - z1;
            Console.WriteLine(z4);
            Console.WriteLine(z5);

            Console.WriteLine();

            Console.WriteLine(z1 > z2);

            Console.WriteLine();

            Console.WriteLine(z1 == z2);
            Console.WriteLine(z1.Equals(z2));

            Console.WriteLine();

            object o1 = z1, o2 = z2;
            Console.WriteLine(o1 == o2);
            Console.WriteLine(o1.Equals(o2));


            Console.WriteLine();

            Console.WriteLine(z1 == z6);
            Console.WriteLine(z1.Equals(z6));

            Console.WriteLine();

            object o3 = z1, o4 = z6;
            Console.WriteLine(o3 == o4);
            Console.WriteLine(o3.Equals(o4));


            int a = z1; // implicit değişim
            Zaman z7 = (Zaman)a; // explicit değişim

            Console.WriteLine();

            Console.WriteLine(a);
            Console.WriteLine(z7.ToString());

            Zaman z8 = z1 + 5800;
            Console.WriteLine(z8.ToString());
        }
    }
}
