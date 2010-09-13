using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Abstract2
{
    class IntSiralama : Siralama
    {
        public override bool Karsilastir(object a, object b)
        {
            int c = (int)a;
            int d = (int)b;
            return c > d;
        }
    }

    class StringSiralama : Siralama
    {
        public override bool Karsilastir(object a, object b)
        {
            string c = (string)a;
            string d = (string)b;
            return string.Compare(c, d, true) > 0;
        }
    }
}
