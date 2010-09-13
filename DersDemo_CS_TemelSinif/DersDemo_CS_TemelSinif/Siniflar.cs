using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_TemelSinif
{
    class A { public string yazi; }

    class B : A { }

    class C : B { }

    class D { }

    class Islem<T> where T: A
    {
        public T deger;

        public void Yaz()
        {
            Console.WriteLine(deger.yazi);
        }
    }
}
