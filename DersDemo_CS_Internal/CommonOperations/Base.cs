using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonOperations
{
    public class Base
    {
        protected internal string a;
        public int b;
        private int c;
        protected int d;
    }

    public class Drived1 : Base
    {
        public Drived1()
        {
            //a
            //b
            //c --- görmez private
            //d
        }
    }

    public class Outside
    {
        public Outside()
        {
            Base baseObject = new Base();
            //baseObject.a;
            //baseObject.b;
        }
    }
}
