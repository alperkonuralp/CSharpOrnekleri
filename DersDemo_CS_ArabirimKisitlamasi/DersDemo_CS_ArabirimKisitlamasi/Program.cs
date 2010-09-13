using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_ArabirimKisitlamasi
{
    class Karsilastir<T> where T : IComparable
    {
        public T a, b;

        public bool Esitlermi()
        {
            //return a.Equals(b);
            return a.CompareTo(b) == 0;
        }

        public bool Buyukmu()
        {
            return a.CompareTo(b) > 0;
        }
    }


    class A { }

    class B {
        public B(int a)
        {

        }
    }

    class Islem<T> where T: new()
    {
        public T deger = new T();
    }


    class Islem2<T, U>
        where U: T
    {
    }


    class Islem3<T>
        where T: class, IComparable, IComparable<T>, new()
    { 
    
    }

    class Islem4<T, U>
        where T : class, IComparable, IComparable<T>, new()
        where U : struct, IComparable, IComparable<T>
    {
    }


    class Islem5<T>
    {
        public T deger;
        public Islem5()
        {
            deger = default(T);
        }
    }

    class Program
    {
        public enum KarsilastirmaSonucu { Buyuk, Esit, Kucuk }
        public static KarsilastirmaSonucu Karsilastir<T>(
            T a, T b)
            where T: IComparable
        {
            int i = a.CompareTo(b);
            if (i == 0) {
                return KarsilastirmaSonucu.Esit;
            }
            else if (i > 0)
            {
                return KarsilastirmaSonucu.Buyuk;
            }
            else
            {
                return KarsilastirmaSonucu.Kucuk;
            }
        }


        static void Main(string[] args)
        {
            Karsilastir<int> d1 = new Karsilastir<int>();
            d1.a = 3;
            d1.b = 5;

            Console.WriteLine(d1.Buyukmu());
            Console.WriteLine(Karsilastir<int>(3, 5));
            Console.WriteLine(Karsilastir<int>(25, 5));

            Karsilastir<long> d2 = new Karsilastir<long>();
            Karsilastir<string> d3 = new Karsilastir<string>();

            Islem<A> a;
            //Islem<B> b;

            Islem2<int, int> c;
            Islem2<object, int> d;
            Islem2<object, string> e;

            int f = default(int);
            string g = default(string);
        }
    }
}
